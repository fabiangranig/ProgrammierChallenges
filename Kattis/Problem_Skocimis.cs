using System;

public class Program
{
    public static void Main()
    {
        //Split the three integers
        string input = Convert.ToString(Console.ReadLine());
        string[] split = input.Split(" ");
        int k1 = Int32.Parse(split[0]);
        int k2 = Int32.Parse(split[1]);
        int k3 = Int32.Parse(split[2]);

        //Calculate the two solutions
        int sol1 = k2 - 1 - k1;
        int sol2 = k3 - 1 - k2;

        //Output the solution
        if(sol1 > sol2)
        {
            Console.WriteLine(sol1);
        }
        else
        {
            Console.WriteLine(sol2);
        }
    }
}
