using System;

public class HelloWorld
{
    static int Add(int a, int b) => a+b;
    static int Sub(int a, int b)=> a-b;
    static int Mul(int a, int b)=> a*b;
    static double Div(int a, int b)=> (b==0)? 0 : (double)a/b;
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Addition:"+Add(5,4));
        Console.WriteLine("Subtraction:"+Sub(6,2));
        Console.WriteLine("Multiplication:"+Mul(5,4));
        Console.WriteLine("Division:"+Div(6,3));
       
    }
}
