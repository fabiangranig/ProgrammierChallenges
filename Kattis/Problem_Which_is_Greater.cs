using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] k = o.Split(" ");

        //Output the solution
        if(Int32.Parse(k[0]) > Int32.Parse(k[1]))
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
