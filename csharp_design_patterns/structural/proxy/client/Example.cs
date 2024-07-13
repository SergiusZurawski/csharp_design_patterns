using csharp_design_patterns.structural.proxy.implementation;

namespace csharp_design_patterns.structural.proxy.client;


/*
    TThe Proxy Design Pattern is a structural pattern that provides a surrogate or placeholder for another object to control access to it.
   
   This pattern is useful in various scenarios, such as lazy initialization, access control, logging, and remote proxy.
   
   Types of Proxies
   
   Virtual Proxy: Controls access to a resource that is expensive to create.
   
   Protection Proxy: Controls access to a resource based on permissions.
   
   Remote Proxy: Controls access to a resource that is located remotely.
   
   Logging Proxy: Logs access to a resource.
 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        IDocument document = new DocumentProxy("largeFile.txt");

        // The file will be loaded only when the content is displayed for the first time
        Console.WriteLine("First call to DisplayContent:");
        document.DisplayContent();

        // Subsequent calls will not reload the file
        Console.WriteLine("Second call to DisplayContent:");
        document.DisplayContent();
        
    }

}