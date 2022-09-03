using System;

public class Program
{
    public static void Main()
    {
        //Get the number
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Calculate
        int k = n % 4;

        //Output the solution
        if(k == 0)
        {
            Console.WriteLine("Even");
        }
        else if(k == 2)
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Either");
        }
    }
}
