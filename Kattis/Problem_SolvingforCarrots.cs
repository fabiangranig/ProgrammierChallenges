using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	string input = Convert.ToString(Console.ReadLine());

	//Seperate the two integers
	string[] split = input.Split(" ");

	//Get the rest of the input
	for(int i = 0; i < Int32.Parse(split[0]); i++)
	{
		//get the useless input
		string useless_input = Convert.ToString(Console.ReadLine());
	}

	//Output the second number as solution
	Console.WriteLine(Int32.Parse(split[1]));
    }
}
