
using csharp_design_patterns.behavioural.strategy.implementaion;

namespace csharp_design_patterns.behavioural.strategy.client;

public static class Example
{
    public static void ExecuteExample()
    {
        var data = new List<int> { 5, 1, 4, 2, 8 };

        // Using QuickSort
        var context = new SortContext(new QuickSortStrategy());
        var sortedData = context.Sort(data);
        Console.WriteLine(string.Join(", ", sortedData));

        // Switching to BubbleSort at runtime
        context.SetStrategy(new BubbleSortStrategy());
        sortedData = context.Sort(data);
        Console.WriteLine(string.Join(", ", sortedData));
    }

}