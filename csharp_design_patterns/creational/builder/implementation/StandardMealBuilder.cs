namespace csharp_design_patterns.creational.builder.implementation;

public class StandardMealBuilder : IMealBuilder
{
    private Meal _meal = new Meal();

    public IMealBuilder AddMainCourse(string mainCourse)
    {
        _meal.MainCourse = mainCourse;
        return this;
    }

    public IMealBuilder AddSideDish(string sideDish)
    {
        _meal.SideDish = sideDish;
        return this;
    }

    public IMealBuilder AddDrink(string drink)
    {
        _meal.Drink = drink;
        return this;
    }

    public IMealBuilder AddDessert(string dessert)
    {
        _meal.Dessert = dessert;
        return this;
    }

    public Meal Build()
    {
        return _meal;
    }
}