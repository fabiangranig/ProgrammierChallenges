using System;

public class Program
{
    static int Calculate(int h)
    {
        //Go through and check the max height
        int number = 1;
        int height = 0;
        double sum = 0;
        while(1 == 1)
        {
            sum += Math.Pow(number, 2);

            if(sum > h)
            {
                break;
            }

            height += 1;
            number += 2;
        }

        //Return the solution
        return height;
    }

    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Convert the input
        int b = Int32.Parse(input);

        //Get the solution
        int hei = Calculate(b);

        //Output the solution
        Console.WriteLine(hei);
    }
}
