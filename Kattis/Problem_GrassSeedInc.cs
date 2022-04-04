using System;

public class Program
{
    public static void Main()
    {
        //Get the seed price
        double c = Convert.ToDouble(Console.ReadLine());

        //Get the amount of times squares are added
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the input and calculate the sum of the price
        double c_sum = 0;
        for(int i = 0; i < n; i++)
        {
            //Get the square
            string o = Convert.ToString(Console.ReadLine());

            //Split the up
            string[] u = o.Split(" ");

            //Put the numbers into an integer array
            double[] numbers = new Double[u.Length];
            numbers[0] = Convert.ToDouble(u[0]);
            numbers[1] = Convert.ToDouble(u[1]);

            //Get the calculatet square
            double square = numbers[0] * numbers[1];

            //Add the cost to the sum
            c_sum += (square * c);
        }

        //Output the solution
        Console.WriteLine(c_sum);
    }
}
