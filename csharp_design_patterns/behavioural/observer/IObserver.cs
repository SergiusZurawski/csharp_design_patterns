namespace csharp_design_patterns.behavioural.observer;

public interface IObserver<T>
{
    void Update(T data);
}