using System;

public class multiplicationTable
{
    public static void Main(string[] args)
    {
        int a=5,n=10;
        for(int i=1;i<=n;i++){
            Console.WriteLine($"{a}*{i}"+"="+a*i);
        }
    }
}