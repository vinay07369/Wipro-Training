using System;

public class grade
{
    public static void Main(string[] args)
    {
        int marks =97;
        
        if(marks >=90)
            Console.WriteLine("Grade A");
        else if(marks>=75)
            Console.WriteLine ("Grade B");
        else if(marks>=60)
            Console.WriteLine ("Grade C");
        else
            Console.WriteLine ("Grade D");
    }
}