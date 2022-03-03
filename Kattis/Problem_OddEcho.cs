using System;

public class Program
{
    public static void Main()
    {
	//Get the first input for the lines
	string input_lines = Convert.ToString(Console.ReadLine());

	//Get the rest of the lines into an array
	string[] input = new String[Int32.Parse(input_lines)];
	for(int i = 0; i < Int32.Parse(input_lines); i++)
	{
		//Put them into an array
		input[i] = Convert.ToString(Console.ReadLine());
	}

	//Output every second word to get the correct solution
	for(int i = 0; i < input.Length; i += 2)
	{
		//Output
		Console.WriteLine(input[i]);
	}
    }
}
