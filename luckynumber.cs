using System;

class LuckyNumber
{
    static void Main()
    {
        // Read input
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x)) // must be non-prime
            {
                int sumX = DigitSum(x);
                int sumSquare = DigitSum(x * x);

                if (sumSquare == sumX * sumX)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    static int DigitSum(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num <= 3) return true;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
