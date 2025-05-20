using System;
using System.Diagnostics;

class SortingAlgorithms
{
    static void Main()
    { 
        Random random = new Random();

        int[] originalArray = new int[20];
        int n = originalArray.Length;

        for (int i = 0; i < n; i++)
        { 
            originalArray[i] = random.Next(1,101); // From 1 to 100
        }

        Console.WriteLine("\nThe Original Array:");
        PrintArray(originalArray);

        //Bubble sort
        int[] bubblesort = (int[])originalArray.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubblesort);
        sw1.Stop();
        Console.WriteLine("\nBubble Sort Array:");
        PrintArray(bubblesort);
        Console.WriteLine($"Time Taken : {sw1.Elapsed.TotalMilliseconds}ms");

        int[] selectionsort = (int[])originalArray.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionsort);
        sw2.Stop();
        Console.WriteLine("\nSelection Sort Array:");
        PrintArray(selectionsort);
        Console.WriteLine($"Time Taken : {sw2.Elapsed.TotalMilliseconds}ms");

        int[] insertionsort = (int[])originalArray.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionsort);
        sw3.Stop();
        Console.WriteLine("\nInsertion Sort Array:");
        PrintArray(insertionsort);
        Console.WriteLine($"Time Taken : {sw3.Elapsed.TotalMilliseconds}ms");

        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("All the three algorithms have a worst-case time complexity of O(n^2)");
        Console.WriteLine("For small arrays the time difference is negligible");
        Console.WriteLine("Insertion sort usually performs better on nearly sorted arrays");

    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    //Swap
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length-1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }

            //Swap
            int temp = arr[i];
            arr[i] = arr[smallest];
            arr[smallest] = temp;   
        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; ++i)
        { 
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j +1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(",",arr));
    }
}
