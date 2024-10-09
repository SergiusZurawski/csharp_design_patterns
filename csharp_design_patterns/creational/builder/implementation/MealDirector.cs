namespace csharp_design_patterns.creational.builder.implementation;
//Optional
public class MealDirector
{
    public void ConstructStandardMeal(IMealBuilder builder)
    {
        builder.AddMainCourse("Steak")
            .AddSideDish("Fries")
            .AddDrink("Cola")
            .AddDessert("Ice Cream");
    }

    public void ConstructVegetarianMeal(IMealBuilder builder)
    {
        builder.AddMainCourse("Veggie Burger")
            .AddSideDish("Salad")
            .AddDrink("Orange Juice")
            .AddDessert("Fruit Salad");
    }
}