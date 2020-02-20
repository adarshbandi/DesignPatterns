using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class ArrivalsMonitor:IObserver<BaggageInfo>
    {
        private string name;
        private List<string> flightInfos = new List<string>();
        private IDisposable cancellation;
        private string fmt= "{0,-20} {1,5}  {2, 3}";

        public ArrivalsMonitor(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("The observer must be assigned a name");                
            }
            this.name = name;
        }

        public virtual void Subscribe(BaggageHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void UnSubscribe()
        {
            cancellation.Dispose();
            flightInfos.Clear();
        }

        public virtual void OnCompleted()
        {
            flightInfos.Clear();
        }

        public virtual void OnError(Exception ex)
        {

        }

        // Update information
        public virtual void OnNext(BaggageInfo info)
        {
            bool updated = false;

            // flight has unloaded its baggage, remove from the monitor
            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<string>();
                string flighNo = string.Format("{0,5}", info.FlightNumber);
                foreach(var flightInfo in flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flighNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }

                foreach(var flightToRemove in flightsToRemove)
                {
                    flightInfos.Remove(flightToRemove);
                }

                flightsToRemove.Clear();
            }
            else
            {
                // Add flight if does not exist in the collection
                string flightInfo = string.Format(fmt, info.From, info.FlightNumber, info.Carousel);
                if (!flightInfos.Contains(flightInfo))
                {
                    flightInfos.Add(flightInfo);
                    updated = true;
                }
            }

            if (updated)
            {
                flightInfos.Sort();
                Console.WriteLine($"Arrivals information from {this.name}");
                foreach(var flightInfo in flightInfos)
                {
                    Console.WriteLine(flightInfo);
                }
            }
            Console.WriteLine();
        }
    }
}
