using System;

public class Program
{
    public static void Main()
    {
        //Get how many lines there are
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get all strings
        string[] input = new String[n];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Convert.ToString(Console.ReadLine());
        }

        //Check which answers are the same
        int count = 0;
        for(int i = 0; i < input.Length - 1; i++)
        {
            if(input[i] == input[i + 1])
            {
                count++;
            }
        }

        //Output the solution
        Console.WriteLine(count);
    }
}
