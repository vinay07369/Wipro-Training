using System;

class SearchingAlgorithms
{
    static void Main()
    { 
        Random random = new Random();

        int[] sortArray = new int[50];

        for (int i = 0; i < sortArray.Length; i++)
        { 
            sortArray[i] = random.Next(1, 201);
        }

        Array.Sort(sortArray);
        Console.WriteLine("\nSorted Array:");
        PrintArray(sortArray);

        int key = sortArray[random.Next(0, sortArray.Length)];
        Console.WriteLine($"The Random Search Element: {key}");

        //Linear search
        int linearCom = 0;
        int linearPositions = LinearSearch(sortArray, key, out linearCom);
        Console.WriteLine($"\nLinear Search:\nLinear Comparisons:{linearCom}, Linear Positions:{linearPositions}");

        int binaryCom = 0;
        int binaryPositions = BinarySearch(sortArray, key, out binaryCom);
        Console.WriteLine($"\nBinary Search:\nBinary Comparisons:{binaryCom}, Binary Positions:{binaryPositions}");
    }

    static int LinearSearch(int[] arr, int key, out int comparison)
    {
        comparison = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparison++;

            if (arr[i] == key)
            {
                return i;
            }
        }

        return -1;
    }

    static int BinarySearch(int[] arr, int key, out int comparison)
    {
        comparison = 0;

        int left = 0;
        int right = arr.Length;

        while (left <= right)
        {
            comparison++;
            int mid = (left + right) / 2; // Middle element

            if (arr[mid] == key) 
                return mid;

            if (arr[mid] < key)
                left = mid + 1;

            else if (arr[mid] > key)    
                right = mid - 1;
        }

        return -1;  
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(",", arr));
    }
}