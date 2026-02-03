using System;

public class Program
{
    public static int SumPositiveUntilZero(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                break;
            }
            if (nums[i] < 0)
            {
                continue;
            }
            sum += nums[i];
        }
        return sum;
    }

    public static void Main()
    {
        int[] nums = { 5, -2, 3, -1, 0, 10 };
        Console.WriteLine(SumPositiveUntilZero(nums));
    }
}
