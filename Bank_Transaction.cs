using System;

public class BankAccount
{
    public static int GetFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        for (int i = 0; i < transactions.Length; i++)
        {
            int amount = transactions[i];

            if (amount >= 0)
            {
                balance += amount;
            }
            else
            {
                int withdrawal = -amount;
                if (balance >= withdrawal)
                {
                    balance -= withdrawal;
                }
            }
        }

        return balance;
    }

    public static void Main()
    {
        int initialBalance = 1000;
        int[] transactions = { 200, -300, -800, 500, -200 };

        int finalBalance = GetFinalBalance(initialBalance, transactions);
        Console.WriteLine(finalBalance);
    }
}
