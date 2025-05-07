using System;

class duplicateWords
{
    static void PrintduplicateWords(string s)
    {
        string[] str = s.ToLower().Split(new char[] { ' ' });

        bool[] visited = new bool[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }

            int count = 1;

            for (int j = i+1; j < str.Length; j++) 
            {
                if (str[i] == str[j]) {
                    count++;
                    visited[j] = true;
                }
            }
            if (count > 1) 
                Console.WriteLine($"{str[i]}");
        }


    }

    public static void Main(string[] args)
    {
        string s = "This is a test and this test is fun";

        PrintduplicateWords(s);

    }

}