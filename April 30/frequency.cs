using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = {1,2,1,3,2,1};
        
        bool[] visit = new bool[a.Length];
        
        for(int i=0;i<a.Length;i++)
        {
            if(visit[i])
                continue;
            int count=1;
            
            for(int j=i+1;j<a.Length;j++)
            {
                if(a[i]==a[j])
                {
                    count++;
                    visit[j]=true;
                    
                }
            }
            Console.WriteLine("Element "+a[i]+" occures "+count+" times");
        }
    }
}