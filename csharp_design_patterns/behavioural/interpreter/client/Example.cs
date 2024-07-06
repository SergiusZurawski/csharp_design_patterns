
using csharp_design_patterns.behavioural.interpreter.implementation;


namespace csharp_design_patterns.behavioural.interpreter.client;

public static class Example
{
    public static void ExecuteExample()
    {
        // Creating a sample expression: (3 + 5) - 2
        IExpression expression = new SubtractExpression(
            new AddExpression(
                new NumberExpression(3),
                new NumberExpression(5)
            ),
            new NumberExpression(2)
        );

        Console.WriteLine("Result: " + expression.Interpret()); // Output: 6
    }

}