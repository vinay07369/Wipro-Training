using System;

public class calculator
{
    //method to add two numbers
    static int Add(int a, int b)
    {
        return a+b;
    }

    //method to subtract numbers
    static int Subtract(int a, int b)
    {
        return a-b;
    }

    //method to multiply numbers
    static int Multiply(int a, int b)
    {
        return a*b;
    }

    //method to divide numbers
    static int Divide(int a, int b)
    {
        return a/b;
    }

    public static void Main(string[] args)
    {
        
        int num1=10;
        int num2=20;
        
        //Calling the method
        Console.WriteLine("Addition:"+Add(num1, num2)); 
        Console.WriteLine("Addition:"+Subtract(num1, num2)); 
        Console.WriteLine("Addition:"+Multiply(num1, num2)); 
        Console.WriteLine("Addition:"+Divide(num1, num2)); 
    }
}