using System;
public class Program
{
    public static double? AverageNonNull(double?[] values)
    {
        double sum=0;
        int count=0;
        for(int i=0;i<values.Length;i++)
        {
            if(values[i].HasValue)
            {
                sum+=values[i].Value;
                count++;
            }
        }
        if(count==0)
        {
            return null;
        }
        double avg=sum/count;
        return Math.Round(avg,2,MidpointRounding.AwayFromZero);
    }
    public static void Main()
    {
        double?[] values={1.235,null,2.345,3.1,null};
        Console.WriteLine(AverageNonNull(values));
    }
}
