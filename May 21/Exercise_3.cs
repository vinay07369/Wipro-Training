using System;

class FirstNonRepeatingCharacter
{
    static void Main()
    {
        string str = "swiss";

        Dictionary<char, int> freq = new Dictionary<char, int>();

        // It will count the no of frequencies...
        foreach (char c in str)
        { 
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        // It will display the first non-repeating character...
        foreach (char c in str)
        {
            if (freq[c] == 1)
            {
                Console.WriteLine($"First Non-Repeating Character: {c}");
                return;
            }
        }

        Console.WriteLine("No Non-Repeating Character Found");
    }
}