
namespace csharp_design_patterns.behavioural.TemplateMethod;

/*
   The Template Method design pattern defines the skeleton of an algorithm in a base class and allows subclasses to override specific steps of the algorithm without changing its structure.
   This pattern is typically used to enforce a sequence of steps while allowing customization of individual steps.
 
   Abstract Class (DataProcessor): Defines the template method ProcessData, which outlines the algorithm's structure. It includes calls to abstract methods (ProcessDataImplementation) that must be implemented by subclasses and calls to concrete methods (ReadData and SaveData) with a default implementation.
   
   Concrete Subclasses (XmlDataProcessor, JsonDataProcessor): Implement the abstract method ProcessDataImplementation to provide the specific behavior for processing XML and JSON data.
   
   Client Code (Program): Demonstrates the use of the Template Method pattern by creating instances of XmlDataProcessor and JsonDataProcessor and calling their ProcessData method, which follows the algorithm defined in the abstract class but with steps customized by the subclasses.
 
  
 */
abstract class DataProcessor
{
    // Template method
    public void ProcessData()
    {
        ReadData();
        ProcessDataCore();
        SaveData();
    }

    // Step 1: Read data (implemented by subclass)
    protected abstract void ReadData();

    // Step 2: Process data (implemented by subclass)
    protected abstract void ProcessDataCore();

    // Step 3: Save data (implemented by subclass)
    protected abstract void SaveData();
}