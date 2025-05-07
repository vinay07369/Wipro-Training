using System;

class longestWord
{
    public static string longest(string a) {

        string[] str = a.Split(' ');

        string largestWord = " ";

        int maxLength = 0;

        for (int i = 0; i < str.Length; i++)
        {

            if (str[i].Length > maxLength)
            {
                maxLength = str[i].Length;

                largestWord = str[i];
            }
        }
        return largestWord;     
    }
    public static void Main(string[] args)
    {
        string s = "Learning c# is really interesting";

        string result = longest(s);

        Console.WriteLine(result);

        Console.WriteLine("The length is:"+result.Length);
    }
}