using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private readonly List<IObserver<BaggageInfo>> _observers;
        private readonly IObserver<BaggageInfo> _observer;

        public Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }
        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
