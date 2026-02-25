bool IsValidSequence(string input)
{
    Console.WriteLine($"Input String :: {input}");
    var permittedCharacters = new Dictionary<char, char>(){
        {'(', ')' },
        {'{', '}' },
        {'[', ']' },
    };

    bool IsValid = true;

    // Check each key in dictionary. Get its count as well as the count of its value
    foreach (var sequence in permittedCharacters)
    {
        // Check the order
        var itemList = new char[input.Length];
        bool keyExists = input.Any(b => b == sequence.Key || b == sequence.Value);
        if (keyExists)
        {
            foreach (var letter in input)
            {
                if ((letter != sequence.Key) || (letter != sequence.Value))
                {
                    continue;
                }
                itemList.Append(letter);
            }


            if (!itemList.Any())
            {
                Console.WriteLine($"{sequence.Key} nor {sequence.Value} doesn't exist in {input}");
                continue;
            }


            Console.WriteLine($"Array for sequence {sequence.Key} and {sequence.Value} :: {new string(itemList)}");

            // -- Insert key and Value into the array			
            var keyCount = itemList.Count(a => a == sequence.Key);
            var valueCount = itemList.Count(b => b == sequence.Value);

            // -- Compare count of Key against value
            if (keyCount != valueCount)
            {
                return false;
            }

            // check the arrangement/order 
            // if   

            for (int i = 0; i < itemList.Length; i++)
            {
                // If the item is key & the next value is not the closing bracket - then break it
                if ((itemList[i] == sequence.Key) && (itemList[i + 1] == sequence.Value))
                {
                    Console.WriteLine($"{itemList[i]} and {itemList[i + 1]} are out of position");
                    IsValid = false;
                    return IsValid;
                }
            }
        }
    }
    return IsValid;
}

string sequence = "{(}";
var isValidSequence = IsValidSequence(sequence);

Console.WriteLine($"{sequence} - Is Valid {isValidSequence}");