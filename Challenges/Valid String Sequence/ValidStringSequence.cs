bool IsValidSequence(string input)
{
    Console.WriteLine($"[DEBUG] Input String :: {input}");
    var permittedCharacters = new Dictionary<char, char>(){
        {')', '(' },
        {'}', '{' },
        {']', '[' },
    };

    Console.WriteLine("[DEBUG] Permitted character pairs:");
    foreach (var kvp in permittedCharacters)
    {
        Console.WriteLine($"   Key: {kvp.Key}, Value: {kvp.Value}");
    }

    // Check each key in dictionary. Get its count as well as the count of its value
    foreach (var sequence in permittedCharacters)
    {
        Console.WriteLine($"\n[DEBUG] Checking sequence pair: {sequence.Key} -> {sequence.Value}");

        // Check the order
        bool keyExists = input.Any(b => b == sequence.Key || b == sequence.Value);
        Console.WriteLine($"[DEBUG] Key {sequence.Key} or {sequence.Value} exists in input? {keyExists}");

        if (keyExists)
        {
            var itemList = new char[input.Length];
            int j = 0;

            foreach (var letter in input)
            {
                Console.WriteLine($"[DEBUG] Inspecting letter: {letter}");
                if ((letter != sequence.Key) && (letter != sequence.Value))
                {
                    Console.WriteLine($"[DEBUG] Skipping letter: {letter}. It is neither {sequence.Key} nor {sequence.Value}");
                    continue;
                }
                itemList[j] = letter;
                Console.WriteLine($"[DEBUG] Added {letter} to itemList at position {j}");
                j++;
            }

            if (!itemList.Any())
            {
                Console.WriteLine($"[DEBUG] Neither {sequence.Key} nor {sequence.Value} exists in {input}");
                continue;
            }

            Console.WriteLine($"[DEBUG] Array for sequence {sequence.Key} and {sequence.Value} : {new string(itemList)}");

            // -- Insert key and Value into the array           
            var keyCount = itemList.Count(a => a == sequence.Key);
            var valueCount = itemList.Count(b => b == sequence.Value);

            Console.WriteLine($"[DEBUG] Key Count {sequence.Key} = {keyCount}, Value Count {sequence.Value} = {valueCount}");
            if (keyCount != valueCount)
            {
                Console.WriteLine($"[DEBUG] Mismatch in counts. Returning false.");
                return false;
            }

            // check the arrangement/order 
            for (int i = 0; i < itemList.Length - 1; i++)
            {
                Console.WriteLine($"[DEBUG] Comparing itemList[{i}]={itemList[i]} with itemList[{i + 1}]={itemList[i + 1]}");
                if ((itemList[i] == sequence.Key) && (itemList[i + 1] == sequence.Value))
                {
                    Console.WriteLine($"[DEBUG] {itemList[i]} and {itemList[i + 1]} are out of position. Returning false.");
                    return false;
                }
            }
        }
    }
    Console.WriteLine("[DEBUG] Sequence passed all checks. Returning true.");
    return true;
}

string sequence = "{([])}";
var isValidSequence = IsValidSequence(sequence);

Console.WriteLine($"{sequence} - Is Valid {isValidSequence}");
