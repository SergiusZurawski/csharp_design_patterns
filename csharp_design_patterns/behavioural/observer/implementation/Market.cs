namespace csharp_design_patterns.behavioural.observer.implementation;
// Concrete Observable
public class Market : observer.IObservable<StockPrice>
{
    private List<IObserver<StockPrice>> observers = new List<IObserver<StockPrice>>();

    public void Subscribe(IObserver<StockPrice> observer)
    {
        if (!observers.Contains(observer))
            observers.Add(observer);
    }

    public void Unsubscribe(IObserver<StockPrice> observer)
    {
        if (observers.Contains(observer))
            observers.Remove(observer);
    }

    public void Notify(StockPrice data)
    {
        foreach (var observer in observers)
            observer.Update(data);
    }
}