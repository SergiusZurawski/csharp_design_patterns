namespace csharp_design_patterns.behavioural.strategy.implementaion;

public class QuickSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> dataset)
    {
        // Implementation of Quick Sort
        return dataset.OrderBy(x => x).ToList();
    }
}

