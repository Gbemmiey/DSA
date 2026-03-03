public string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0)
    {
        return "";
    }

    string referenceWord = strs[0];
    // Determine the length of the shortest word
    int shortestWordLength = referenceWord.Length;
    foreach (var word in strs)
    {
        if (word.Length < shortestWordLength)
        {
            shortestWordLength = word.Length;
        }
    }

    char[] prefixArray = new char[shortestWordLength];
    int prefixLength = 0;

    for (int i = 0; i < shortestWordLength; i++)
    {
        char characterToBeCompared = referenceWord[i];
        bool characterExists = true;

        foreach (var word in strs)
        {
            if (word[i] != characterToBeCompared)
            {
                characterExists = false;
                break;
            }
        }

        if (!characterExists)
        {
            break;
        }

        prefixArray[i] = characterToBeCompared;
        prefixLength++;
    }

    if (prefixArray.Length == 0)
    {
        return "";
    }

    return new string(prefixArray, 0, prefixLength);

}