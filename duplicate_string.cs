using System;
using System.Text;
public class Program
{
    public static void Main()
    {
        // Input string
        string input = " llapppptop bag ";
        // Remove leading and trailing spaces
        input = input.Trim();
        // Builder to remove consecutive duplicate characters
        StringBuilder noDuplicates = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            // Keep character only if it is not same as previous
            if (i == 0 || input[i] != input[i - 1])
            {
                noDuplicates.Append(input[i]);
            }
        }
        // Builder for final TitleCase result
        StringBuilder result = new StringBuilder();
        bool makeUpper = true;
        foreach (char ch in noDuplicates.ToString())
        {
            // Preserve existing spaces without adding new ones
            if (ch == ' ')
            {
                result.Append(ch);
                makeUpper = true;
            }
            else
            {
                // Convert first character of each word to uppercase
                result.Append(makeUpper ? char.ToUpper(ch) : char.ToLower(ch));
                makeUpper = false;
            }
        }
        // Print final output
        Console.WriteLine(result.ToString());
    }
}
