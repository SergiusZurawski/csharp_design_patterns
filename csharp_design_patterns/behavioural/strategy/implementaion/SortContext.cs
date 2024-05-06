namespace csharp_design_patterns.behavioural.strategy.implementaion;

public class SortContext
{
    private ISortStrategy _sortStrategy;

    public SortContext(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void SetStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public List<int> Sort(List<int> data)
    {
        return _sortStrategy.Sort(data);
    }
}
