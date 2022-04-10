using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the line at "()"
        string[] h = o.Split("()");

        //Output the solution
        if(h[0].Length == h[1].Length)
        {
            Console.WriteLine("correct");
        }
        else
        {
            Console.WriteLine("fix");
        }
    }
}
