using System;

public class Program
{
    public static void Main()
    {
        //Get the input of how many numbers are there
        int numbers_many = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the line with the integers and split it into an array
        string line = Convert.ToString(Console.ReadLine());
        string[] k = line.Split(" ");

        //Go through all the numbers and add them up if they are negative
        int sum = 0;
        for(int i = 0; i < numbers_many; i++)
        {
            int c = Int32.Parse(Convert.ToString(k[i]));
            if(c < 0)
            {
                sum += c;
            }
        }

        //Set the number positiv
        sum *= (-1);

        //Output the solution
        Console.WriteLine(sum);
    }
}
