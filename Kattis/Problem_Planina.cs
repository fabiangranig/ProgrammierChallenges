using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        int o = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Calculate the solution
        double u = Math.Pow(2, o) + 1;
        
        //Output the solution
        Console.WriteLine(u * u);
    }
}
