using System;

public class Program
{
    public static void Main()
    {
	//Get the input string
	string input = Convert.ToString(Console.ReadLine());

	//Split the string
	string[] input_split = input.Split(" ");

	//Convert these two numbers into an integer
	int a = Int32.Parse(input_split[0]);
	int b = Int32.Parse(input_split[1]);

	//Compare which number is bigger and set the position
	if(a > b)
	{
		int c = a;
		a = b;
		b = c;
	}

	//Output the solution
	Console.WriteLine(a + " " + b);
    }
}
