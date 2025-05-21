using System;

class Program

{
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }

        // Move n-1 disks from source to auxiliary
        TowerOfHanoi(n - 1, from, aux, to);

        // Move the remaining disk from source to destination
        Console.WriteLine($"Move disk {n} from {from} to {to}");

        // Move the n-1 disks from auxiliary to destination
        TowerOfHanoi(n - 1, aux, to, from);
    }

    static void Main()
    {
        int n = 3; // You can change this value to test with more disks
        Console.WriteLine($"Steps to solve Tower of Hanoi for {n} disks:");
        TowerOfHanoi(n, 'A', 'C', 'B');
    }
}