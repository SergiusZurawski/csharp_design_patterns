
using csharp_design_patterns.behavioural.observer.implementation;

namespace csharp_design_patterns.behavioural.observer.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var data = new List<int> { 5, 1, 4, 2, 8 };

        Market market = new Market();
        Investor investorA = new Investor("Alice");
        Investor investorB = new Investor("Bob");

        market.Subscribe(investorA);
        market.Subscribe(investorB);

        market.Notify(new StockPrice { Symbol = "AAPL", Price = 150.50m });
        market.Notify(new StockPrice { Symbol = "MSFT", Price = 250.75m });

        market.Unsubscribe(investorB);
        market.Notify(new StockPrice { Symbol = "GOOG", Price = 2725.00m }); // Bob won't receive this update
    }

}