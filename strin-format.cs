using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

// Immutable Student record
public record Student(string Name, int Score);

public class Solution
{
    public static string ProcessStudents(string[] items, int minScore)
    {
        // Handle empty input early
        if (items == null || items.Length == 0)
            return "[]";

        // Pre-allocate list for performance (important for large inputs)
        var students = new List<Student>(items.Length);

        foreach (var item in items)
        {
            // Each string is in format "Name:Score"
            var parts = item.Split(':');

            // Defensive check (optional but safe)
            if (parts.Length != 2)
                continue;

            string name = parts[0];

            // Parse score safely
            if (!int.TryParse(parts[1], out int score))
                continue;

            students.Add(new Student(name, score));
        }

        // Filter, sort, and project
        var result = students
            .Where(s => s.Score >= minScore)
            .OrderByDescending(s => s.Score)   // Score descending
            .ThenBy(s => s.Name)               // Name ascending
            .ToList();

        // Serialize to JSON array
        return JsonSerializer.Serialize(result);
    }

    // Example usage
    public static void Main()
    {
        string[] items =
        {
            "Alice:90",
            "Bob:75",
            "Charlie:90",
            "David:60"
        };

        int minScore = 80;

        string json = ProcessStudents(items, minScore);
        Console.WriteLine(json);
    }
}
