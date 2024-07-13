namespace csharp_design_patterns.structural.flyweight.implementation;

public class Character : ICharacter
{
    private char _symbol;

    public Character(char symbol)
    {
        _symbol = symbol;
    }

    public void Display(int fontSize, int position)
    {
        Console.WriteLine($"Character: {_symbol}, FontSize: {fontSize}, Position: {position}");
    }
}