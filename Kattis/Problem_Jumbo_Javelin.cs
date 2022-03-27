using System;

public class Program
{
    public static void Main()
    {
        //Get the number of n lines
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Read in the rest of the numbers and calculate the length
        int sum = 0;
        for(int i = 0; i < n; i++)
        {
            sum += Int32.Parse(Convert.ToString(Console.ReadLine()));
        }

        //Remove the engineer fails because of bad fusing
        sum -= (n - 1);

        //Output the solution
        Console.WriteLine(sum);
    }
}
