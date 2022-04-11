using System;

public class Program
{
    public static void Main()
    {
        //Get the one number from the input
        double number = Convert.ToDouble(Console.ReadLine());

        //Output the solution
        Console.WriteLine((1/number*100));
        Console.WriteLine((1/(100-number)*100));
    }
}
