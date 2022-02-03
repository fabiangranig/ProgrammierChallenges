using System;

public class Program
{
    public static void Main()
    {
        //Read in the values
        string input = Convert.ToString(Console.ReadLine());

        //Split the number in two seperate ´string
        string[] numbers = input.Split(" ");

        //Add the two numbers togheter
        int sum = Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]);

        //Output the answer
        Console.WriteLine(sum);
    }
}
