using csharp_design_patterns.structural.flyweight.implementation;

namespace csharp_design_patterns.structural.flyweight.client;

public static class Example
{
    public static void ExecuteExample()
    {
        string document = "ABRACADABRA";
        char[] chars = document.ToCharArray();

        CharacterFactory factory = new CharacterFactory();

        int fontSize = 12;
        for (int i = 0; i < chars.Length; i++)
        {
            ICharacter character = factory.GetCharacter(chars[i]);
            character.Display(fontSize, i);
        }
    }

}