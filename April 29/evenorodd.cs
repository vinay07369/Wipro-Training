using System;

public class evenorodd
{
    public static void Main(string[] args)
    {
        int a = 10;
        if(a % 2==0){
            Console.WriteLine($"{a} is Even");
        }else{
            Console.WriteLine($"{a} is Odd");
        }
    }
}