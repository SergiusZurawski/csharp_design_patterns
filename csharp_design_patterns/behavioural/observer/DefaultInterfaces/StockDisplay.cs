namespace csharp_design_patterns.behavioural.observer.DefaultInterfaces;

public class StockDisplay : System.IObserver<decimal>
{
    private IDisposable unsubscriber;

    public void Subscribe(System.IObservable<decimal> provider)
    {
        unsubscriber = provider.Subscribe(this);
    }

    public void OnNext(decimal price)
    {
        Console.WriteLine($"New stock price: {price:C}");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"An error occurred: {error.Message}");
    }

    public void OnCompleted()
    {
        Console.WriteLine("Additional stock price updates will not be received.");
    }

    public void Unsubscribe()
    {
        unsubscriber.Dispose();
    }
}