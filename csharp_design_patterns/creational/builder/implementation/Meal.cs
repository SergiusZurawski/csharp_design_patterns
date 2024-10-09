namespace csharp_design_patterns.creational.builder.implementation;

public class Meal
{
    public string MainCourse { get; set; }
    public string SideDish { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }

    public override string ToString()
    {
        return $"Meal includes: Main Course - {MainCourse}, Side Dish - {SideDish}, " +
               $"Drink - {Drink}, Dessert - {Dessert}.";
    }
}

