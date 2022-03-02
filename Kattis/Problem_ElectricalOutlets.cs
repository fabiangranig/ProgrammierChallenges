using System;

public class Program
{
    public static void Main()
    {
	//Get the n input lines
	int n_lines = Convert.ToInt32(Console.ReadLine());

	//Get the rest of the lines
	string[] input = new String[n_lines];
	for(int i = 0; i < n_lines; i++)
	{
		//Put the lines into the array
		input[i] = Convert.ToString(Console.ReadLine());
	}

	//Split the lines into single values
	string[] array = input.Split(" ");

	//Convert the whole array into integers
	int[] numbers = new Int32[array.Length];
	for(int i = 0; i < array.Length; i++)
	{
		//Convert to Int
		numbers[i] = Parse.Int32(array[i]);
	}

	for(int i = 0; i < numbers.Length; i++)
	{
		
	}
    }
}
