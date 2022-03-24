using System;

public class Program
{
    public static void Main()
    {
	    //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] u = o.Split(" ");

        //Get the solution
        double sol = (Convert.ToDouble(Int32.Parse(u[0])) * Convert.ToDouble(Int32.Parse(u[1]))) / 2.0;

        //Output the solution
        Console.WriteLine(sol);
    }
}
