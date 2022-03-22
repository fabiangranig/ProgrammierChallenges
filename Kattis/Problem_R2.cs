using System;

public class Program
{
    public static void Main()
    {
        //Read in the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the numbers
        string[] u = o.Split(" ");

        //Calculate the solution
        int sol = 2 * Int32.Parse(u[1]) - Int32.Parse(u[0]);

        //Output the solution
        Console.WriteLine(sol);
    }
}
