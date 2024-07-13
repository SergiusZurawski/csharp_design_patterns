namespace csharp_design_patterns.structural.composite.client;
using csharp_design_patterns.structural.composite.implementation;

/*
 
 The Composite Design Pattern is a structural pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions of objects uniformly.
   
   Components of Composite Design Pattern
   Component: An abstract class or interface that declares operations for both simple and complex objects of the composition.
   Leaf: Represents the end objects of a composition. A leaf can't have any children.
   Composite: Defines behavior for components having children and stores child components.
 
 
 */
public static class Example
{
    public static void ExecuteExample()
    {
        // Create the root directory
        Directory root = new Directory("Root");

        // Create files
        File file1 = new File("File1.txt");
        File file2 = new File("File2.txt");

        // Create subdirectory
        Directory subDir = new Directory("SubDirectory");

        // Create files in subdirectory
        File file3 = new File("File3.txt");

        // Add files and subdirectory to the root directory
        root.Add(file1);
        root.Add(file2);
        root.Add(subDir);

        // Add file to subdirectory
        subDir.Add(file3);

        // Display the file system
        root.Display(1);
    }

}