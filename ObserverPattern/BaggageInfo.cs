using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BaggageInfo
    {
        private int _flightNo;
        private string _origin;
        private int _location;

        internal BaggageInfo(int flightNo, string from, int carousel)
        {
            this._flightNo = flightNo;
            this._origin = from;
            this._location = carousel;
        }

        public int FlightNumber
        {
            get
            {
                return this._flightNo;
            }
        }

        public string From
        {
            get
            {
                return this._origin;
            }
        }

        public int Carousel
        {
            get
            {
                return this._location;
            }
        }
    }
}
