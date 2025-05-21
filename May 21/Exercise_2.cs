using System;

class CoinChangeGreedy
{
    static void Main()
    {
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int amount = 880;
        int totalCoins = 0;

        Console.Write("Coins used: ");

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                Console.Write(coin + " ");
                totalCoins++;
            }
        }

        Console.WriteLine($"\nTotal coins: {totalCoins}");
    }
}