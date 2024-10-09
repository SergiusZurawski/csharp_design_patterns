namespace csharp_design_patterns.creational.prototype;

public interface IShape
{
    IShape Clone();
    void GetInfo();
}