using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        // Input and output file paths
        string inputFile = "log.txt";
        string outputFile = "error.txt";
        // Read all lines from the log file
        string[] logLines = File.ReadAllLines(inputFile);
        // Create a StreamWriter to write error logs
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in logLines)
            {
                // Check if the log line contains ERROR
                if (line.Contains("ERROR"))
                {
                    writer.WriteLine(line);
                }
            }
        }
        // Confirmation message
        Console.WriteLine("ERROR logs extracted to error.txt");
    }
}
