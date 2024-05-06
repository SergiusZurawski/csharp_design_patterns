namespace csharp_design_patterns.behavioural.strategy.implementaion;

public class BubbleSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> dataset)
    {
        // Implementation of Bubble Sort
        int temp;
        for (int j = 0; j <= dataset.Count - 2; j++)
        {
            for (int i = 0; i <= dataset.Count - 2; i++)
            {
                if (dataset[i] > dataset[i + 1])
                {
                    temp = dataset[i + 1];
                    dataset[i + 1] = dataset[i];
                    dataset[i] = temp;
                }
            }
        }
        return dataset;
    }
}