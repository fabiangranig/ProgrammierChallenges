using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	string input = Convert.ToString(Console.ReadLine());

	//Convert it to an integer
	int a = Int32.Parse(input);

	//if odd Alice wins, else Bob wins
	if(a % 2 == 0)
	{
		Console.WriteLine("Bob");
	}
	else
	{
		Console.WriteLine("Alice");
	}
    }
}
