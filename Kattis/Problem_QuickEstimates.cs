using System;

public class Program
{
    public static void Main()
    {
        //Get how many lines there will be
        int n = Int32.Parse(Console.ReadLine());

        //Get all input lines
        string[] input = new String[n];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Convert.ToString(Console.ReadLine());
        }

        //Output the solution
        for(int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(input[i].Length);
        }
    }
}
