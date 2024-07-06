using System;
using csharp_design_patterns.behavioural.TemplateMethod;

class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading data from XML file.");
    }

    protected override void ProcessDataCore()
    {
        Console.WriteLine("Processing data from XML file.");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Saving data to XML file.");
    }
}