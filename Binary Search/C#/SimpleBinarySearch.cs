/// <summary>
/// Executes a simple binary search
/// </summary>
/// <param name="orderedArray">An ordered array of integers.</param>
/// <param name="searchTerm">The integer being searched.</param>
/// <returns>An integer for the index of the search Term.</returns>
int? ExecuteBinarySearch(int[] orderedArray, int searchTerm)
{
    if (orderedArray == null || orderedArray.Length == 0)
        return null;

    int left = 0;
    int right = orderedArray.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        int value = orderedArray[mid];

        if (value == searchTerm)
            return mid;

        if (value < searchTerm)
            left = mid + 1;     // ← crucial
        else
            right = mid - 1;    // ← crucial
    }

    return null;
}

Console.WriteLine(ExecuteBinarySearch([2, 3, 4, 5, 6, 7, 8, 9, 10], 10));