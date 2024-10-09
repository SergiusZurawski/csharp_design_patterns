using csharp_design_patterns.creational.builder.implementation;

namespace csharp_design_patterns.creational.builder;

public interface IMealBuilder
{
    IMealBuilder AddMainCourse(string mainCourse);
    IMealBuilder AddSideDish(string sideDish);
    IMealBuilder AddDrink(string drink);
    IMealBuilder AddDessert(string dessert);
    Meal Build();
}

