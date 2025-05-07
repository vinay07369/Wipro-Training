using System;

class frequency
{
    public static void Printfrequency(int[] a) {

        bool[] visited = new bool[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            if (visited[i])
                continue;

            int count = 1;

            for (int j = i+1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                { 
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine($"The element {a[i]} occurs {count} times");
        }
            
    }
    public static void Main(string[] args)
    {
        int[] a = {1, 2, 2, 3, 4, 4, 4};
        
        Printfrequency(a);
    }
}