using System;

public class Program
{
    public static void Main()
    {
        //Get the useless input
	string u_input = Convert.ToString(Console.ReadLine());

	//Get the usefull input
	string input = Convert.ToString(Console.ReadLine());

	//Split the input into an array
	string[] array = input.Split(" ");

	//Sum all the items up
	int sum = 0;
	for(int i = 0; i < array.Length; i++)
	{
		sum += Int32.Parse(array[i]);
	}

	//Output the solution
	Console.WriteLine(sum);
    }
}
