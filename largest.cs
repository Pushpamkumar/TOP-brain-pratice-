public static int LargestOfThree(int a, int b, int c)
{
    // Assume 'a' is the largest initially
    int largest = a;

    // Compare with b
    if (b > largest)
    {
        largest = b;
    }

    // Compare with c
    if (c > largest)
    {
        largest = c;
    }

    return largest;
}
