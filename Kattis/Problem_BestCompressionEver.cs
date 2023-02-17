using System;

public class Program
{
    public static void Main()
    {
        string input = Convert.ToString(Console.ReadLine());
        string[] split = input.Split(" ");

        double sum = 0;
        long u = Int64.Parse(split[1]);
        long o = Int64.Parse(split[0]);
        for(int i = 0; i < u+1; i++)
        {
            sum += Math.Pow(2, i);
        }
        
       if(sum >= o)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
