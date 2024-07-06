namespace csharp_design_patterns.structural.bridge.client;

/*
 The Bridge design pattern is used to separate an abstraction from its implementation so that the two can vary independently.
 This pattern involves an interface which acts as a bridge, making the functionality of concrete classes independent from interface implementer classes.
 Both types of classes can be altered structurally without affecting each other. 
 */
public static class Example
{
    public static void ExecuteExample()
    {
         IDevice tv = new TV();
         RemoteControl basicRemote = new BasicRemote(tv);
                basicRemote.TogglePower();
                basicRemote.VolumeUp();
                basicRemote.VolumeDown();
                basicRemote.TogglePower();
        
                Console.WriteLine();
        
                IDevice radio = new Radio();
                RemoteControl advancedRemote = new AdvancedRemote(radio);
                advancedRemote.TogglePower();
                advancedRemote.VolumeUp();
                advancedRemote.VolumeDown();
                ((AdvancedRemote)advancedRemote).Mute();
                advancedRemote.TogglePower();
        
    }

}