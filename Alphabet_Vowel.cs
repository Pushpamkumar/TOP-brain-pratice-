using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    // Method to check if a character is a vowel
    static bool IsVowel(char ch)
    {
        ch = char.ToLower(ch);
        return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
    }

    public static void Main()
    {
        // Read input words
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        // Store characters of second word in lowercase for case-insensitive comparison
        HashSet<char> secondWordChars = new HashSet<char>();
        foreach (char c in word2)
        {
            secondWordChars.Add(char.ToLower(c));
        }

        StringBuilder afterTask1 = new StringBuilder();

        // Task 1: Remove common consonants
        foreach (char c in word1)
        {
            char lowerChar = char.ToLower(c);

            // Keep character if:
            // - it is a vowel OR
            // - it is a consonant but not present in second word
            if (IsVowel(lowerChar) || !secondWordChars.Contains(lowerChar))
            {
                afterTask1.Append(c);
            }
        }

        StringBuilder finalResult = new StringBuilder();

        // Task 2: Remove consecutive duplicate characters
        for (int i = 0; i < afterTask1.Length; i++)
        {
            if (i == 0 || afterTask1[i] != afterTask1[i - 1])
            {
                finalResult.Append(afterTask1[i]);
            }
        }

        // Print final output
        Console.WriteLine(finalResult.ToString());
    }
}
