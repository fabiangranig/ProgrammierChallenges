using System;

public class Program
{
    public static void Main()
    {
       //Read in the length of the data
       int n = Convert.ToInt32(Console.ReadLine());

       //Get the information, split, * and sum it up
       double sum = 0;
       for(int i = 0; i < n; i++)
       {
       		//Read the line
		string input = Convert.ToString(Console.ReadLine());

		//Split it by " "
		string[] input2 = input.Split(" ");

		//Multiply
		sum += (Convert.ToDouble(input2[0]) * Convert.ToDouble(input2[1]));
       }

       //Output the solution
       Console.WriteLine(Math.Round(sum, 3));
    }
}
