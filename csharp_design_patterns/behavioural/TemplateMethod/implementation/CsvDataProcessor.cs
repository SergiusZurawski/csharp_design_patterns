using System;
using csharp_design_patterns.behavioural.TemplateMethod;

class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Reading data from CSV file.");
    }

    protected override void ProcessDataCore()
    {
        Console.WriteLine("Processing data from CSV file.");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Saving data to CSV file.");
    }
}