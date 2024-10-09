using csharp_design_patterns.creational.builder.implementation;

namespace csharp_design_patterns.creational.builder.client;



/*
  
 When to Use the Builder Pattern
Complex Object Creation: When creating an object involves multiple steps or configurations.
Readable Code: To improve code readability and maintainability by avoiding long parameter lists in constructors.
Immutable Objects: When you want to build immutable objects by only exposing the object once it's fully constructed.
Different Representations: When the construction process can create different representations of the object.

Components of the Builder Pattern
Product: The complex object to be created (e.g., Meal).
Builder Interface: Specifies methods for creating the parts of the Product (e.g., IMealBuilder).
Concrete Builder: Implements the Builder Interface to construct and assemble parts (e.g., VegetarianMealBuilder).
Director (Optional): Controls the construction process (e.g., MealDirector).
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        var director = new MealDirector();

        // Build a standard meal
        IMealBuilder standardMealBuilder = new StandardMealBuilder();
        director.ConstructStandardMeal(standardMealBuilder);
        Meal standardMeal = standardMealBuilder.Build();
        Console.WriteLine(standardMeal);

        // Build a vegetarian meal
        IMealBuilder vegetarianMealBuilder = new VegetarianMealBuilder();
        director.ConstructVegetarianMeal(vegetarianMealBuilder);
        Meal vegetarianMeal = vegetarianMealBuilder.Build();
        Console.WriteLine(vegetarianMeal);

        // Build a custom meal
        IMealBuilder customMealBuilder = new StandardMealBuilder();
        Meal customMeal = customMealBuilder
            .AddMainCourse("Chicken Wrap")
            .AddDrink("Lemonade")
            .Build();
        Console.WriteLine(customMeal);
        
    }

}