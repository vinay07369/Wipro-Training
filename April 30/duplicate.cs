using System;

public class duplicate
{
    public static void Main(string[] args)
    {
        int[] a = {1,2,3,2,4,1};
        int[] uniqueArr = new int[a.Length];
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < count; j++)
            {
                if (a[i] == uniqueArr[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                uniqueArr[count] = a[i];
                count++;
            }
        }
        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(uniqueArr[i] + " ");
        }
    }
}