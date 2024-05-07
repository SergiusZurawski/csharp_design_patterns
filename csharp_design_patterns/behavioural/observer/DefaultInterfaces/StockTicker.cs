namespace csharp_design_patterns.behavioural.observer.DefaultInterfaces;

using System;
using System.Collections.Generic;

public class StockTicker : System.IObservable<decimal>
{
    private List<IObserver<decimal>> observers;

    public StockTicker()
    {
        observers = new List<IObserver<decimal>>();
    }

    public IDisposable Subscribe(IObserver<decimal> observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);
        return new Unsubscriber(observers, observer);
    }

    public void Notify(decimal price)
    {
        foreach (var observer in observers)
            observer.OnNext(price);
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<decimal>> _observers;
        private IObserver<decimal> _observer;

        public Unsubscriber(List<IObserver<decimal>> observers, IObserver<decimal> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}