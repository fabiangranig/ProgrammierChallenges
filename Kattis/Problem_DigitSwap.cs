using System;

public class Program
{
    public static void Main()
    {
	//Get the line
	string input = Convert.ToString(Console.ReadLine());

	//Get both numbers
	string a = Convert.ToString(input[0]);
	string b = Convert.ToString(input[1]);

	//Output the solution
	Console.WriteLine(b + a);
    }
}
