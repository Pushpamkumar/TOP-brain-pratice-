using System;
public class Program
{
    public static int SumValidIntegers(string[] tokens)
    {
        int sum=0;
        for(int i=0;i<tokens.Length;i++)
        {
            int value;
            if(int.TryParse(tokens[i],out value))
            {
                sum+=value;
            }
        }
        return sum;
    }
    public static void Main()
    {
        string[] tokens={"10","abc","200","9999999999","-5","12.3"};
        Console.WriteLine(SumValidIntegers(tokens));
    }
}
