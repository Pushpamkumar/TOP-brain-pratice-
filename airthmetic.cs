using System;

public class Solution
{
    public static string EvaluateExpression(string expression)
    {
        // Step 1: Validate expression format
        // Expected format: "a op b" → exactly 3 parts
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        // Step 2: Parse operands
        if (!int.TryParse(parts[0], out int a) ||
            !int.TryParse(parts[2], out int b))
        {
            return "Error:InvalidNumber";
        }

        // Step 3: Extract operator
        string op = parts[1];

        // Step 4: Evaluate based on operator
        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";

                return (a / b).ToString(); // Integer division

            default:
                return "Error:UnknownOperator";
        }
    }

    // Example usage
    public static void Main()
    {
        Console.WriteLine(EvaluateExpression("10 + 5"));   // 15
        Console.WriteLine(EvaluateExpression("10 / 0"));   // Error:DivideByZero
        Console.WriteLine(EvaluateExpression("a + 5"));    // Error:InvalidNumber
        Console.WriteLine(EvaluateExpression("10 ^ 5"));   // Error:UnknownOperator
        Console.WriteLine(EvaluateExpression("10+5"));     // Error:InvalidExpression
    }
}
