namespace csharp_design_patterns.behavioural.observer.implementation;

// Concrete Observer
public class Investor : IObserver<StockPrice>
{
    public string Name { get; set; }

    public Investor(string name)
    {
        Name = name;
    }

    public void Update(StockPrice data)
    {
        Console.WriteLine($"{Name} notified of {data.Symbol} price change to {data.Price:C}");
    }
}
