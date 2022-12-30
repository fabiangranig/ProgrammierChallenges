using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        int input = Int32.Parse(Console.ReadLine());

        //Output the solution
        int output = input & 1;
        if(output == 1)
        {
            Console.WriteLine("first");
        }
        else
        {
            Console.WriteLine("second");
        }
    }
}
