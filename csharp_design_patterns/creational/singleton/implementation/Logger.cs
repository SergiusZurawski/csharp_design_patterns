namespace csharp_design_patterns.creational.singleton.implementation;

using System;
using System.IO;

public sealed class Logger
{
    private static Logger _instance = null;
    private static readonly object _lock = new object();

    private string _filePath;

    // Private constructor to prevent instantiation
    private Logger()
    {
        _filePath = "log.txt";
    }

    // Public static property to get the instance
    public static Logger Instance
    {
        get
        {
            // Double-checked locking
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }
    }

    // Method to log messages
    public void Log(string message)
    {
        // Append message to the log file
        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
        Console.WriteLine($"Logged: {message}");
    }
}

