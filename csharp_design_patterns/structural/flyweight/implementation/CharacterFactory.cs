namespace csharp_design_patterns.structural.flyweight.implementation;

public class CharacterFactory
{
    private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

    public ICharacter GetCharacter(char symbol)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol);
        }
        return _characters[symbol];
    }
}
