namespace csharp_design_patterns.behavioural.TemplateMethod.client;

public static class Example
{
    public static void ExecuteExample()
    {
        // Create a list of elements
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.ProcessData();

        Console.WriteLine();

        DataProcessor xmlProcessor = new XmlDataProcessor();
        xmlProcessor.ProcessData();
    }

}