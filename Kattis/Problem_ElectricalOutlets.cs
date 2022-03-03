using System;

public class Program
{
    public static void Main()
    {
	//Get the n input lines
	int n_lines = Convert.ToInt32(Console.ReadLine());

	//Get the rest of the lines
	for(int i = 0; i < n_lines; i++)
	{
		//Put the lines into the array
		string input = Convert.ToString(Console.ReadLine());

		//Get the splittet String
		string[] split = input.Split(" ");

		//Go through the outlets
		int sum = 0;
		for(int u = 1; u < split.Length; u++)
		{
			//Add the numbers togheter
			sum += Int32.Parse(split[u]);
		}

		//Remove the outlets which are to much
		sum -= split.Length - 2;

		//Display the solution
		Console.WriteLine(sum);
	}
    }
}
