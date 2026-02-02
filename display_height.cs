public static string GetHeightCategory(int heightCm)
{
    // Check for Short category
    if (heightCm < 150)
    {
        return "Short";
    }
    // Check for Average category
    else if (heightCm < 180)
    {
        return "Average";
    }
    // Remaining values are Tall
    else
    {
        return "Tall";
    }
}
