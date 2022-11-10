using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Split the input
        string[] split = input.Split(" ");

        //Sort the array
        Array.Sort(split);
        
        //Output the solution
        Console.WriteLine(Int32.Parse(split[0]) * Int32.Parse(split[2]));
    }
}
