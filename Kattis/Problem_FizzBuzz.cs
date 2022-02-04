using System;

public class Program
{
    public static void Main()
    {
	//Get the input
        string input = Convert.ToString(Console.ReadLine());

	//Split the input into an array
	string[] array = input.Split(" ");

	//Go through with a for-loop and Output the solution
	for(int i = 1; i < Int32.Parse(array[2]) + 1; i++)
	{
		//When the first number can be divided
		if(i % Int32.Parse(array[0]) == 0)
		{
			Console.WriteLine("Fizz");
		}

		//When the second number can divided
		if(i % Int32.Parse(array[1]) == 0)
		{
			Console.WriteLine("Buzz");
		}

		//When both numbers get divided
		if(i % Int32.Parse(array[0]) == 0 && i % Int32.Parse(array[1]) == 0)
		{
			Console.WriteLine("FizzBuzz");
		}
		
		//If nothing matches just return the number
		if(i % Int32.Parse(array[0]) != 0 && i % Int32.Parse(array[1]) != 0)
		{
			Console.WriteLine(i);
		}
	}
    }
}
