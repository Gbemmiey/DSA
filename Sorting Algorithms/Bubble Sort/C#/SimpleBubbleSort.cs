int[] SimpleBubbleSortArray(int[] unsortedArray)
{
    Console.WriteLine($"Unsorted Array: {string.Join(", ", unsortedArray)}");

    if (unsortedArray.Length == 0)
    {
        return unsortedArray;
    }

    bool hasSwappedItems = true;

    // 2 - nested loops
    while (hasSwappedItems)
    {
        hasSwappedItems = false;

        for (int i = 0; i < unsortedArray.Length - 1; i++)
        {
            var leftValue = unsortedArray[i];
            var rightValue = unsortedArray[i + 1];

            if (rightValue < leftValue)
            {
                unsortedArray[i] = rightValue;
                unsortedArray[i + 1] = leftValue;
                hasSwappedItems = true;
            }
        }

        Console.WriteLine($"At the end of iteration: {string.Join(", ", unsortedArray)}");
        if (hasSwappedItems == false)
        {
            break;
        }
    }

    Console.WriteLine($"Sorted Array: {string.Join(", ", unsortedArray)}");

    return unsortedArray;
}


int[] unsortedArray = new int[] { 3, 2, 1, 4 };

var sortedArray = SimpleBubbleSortArray(unsortedArray);

