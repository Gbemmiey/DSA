bool HasDuplicateValue(int[] array)
{
    if (array == null || array.Length <= 1)
        return false;

    var seen = new HashSet<int>();

    foreach (int num in array)
    {
        if (!seen.Add(num))     // Add returns false if value already exists
        {
            return true;
        }
    }
    return false;
}

HasDuplicateValue([10, 2, 3, 4, 5, 6, 7, 2, 7]);