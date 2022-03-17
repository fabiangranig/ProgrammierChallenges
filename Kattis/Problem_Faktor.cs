using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	string o = Convert.ToString(Console.ReadLine());

	//Split the string
	string[] array_string = o.Split(" ");

	//Convert the string
	int a = Int32.Parse(array_string[0]);
	int b = Int32.Parse(array_string[1]);

	//Output the solution
	Console.WriteLine(a * (b - 1) + 1);	
    }
}
