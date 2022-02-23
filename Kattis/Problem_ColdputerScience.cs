using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	string input = Convert.ToString(Console.ReadLine());
	string input2 = Convert.ToString(Console.ReadLine());

	//Split the numbers up
	string[] split = input2.Split(" ");

	//for-Loop
	int count = 0;
	for(int i = 0; i < split.Length; i++)
	{
		//Count up when it is below 0
		if(Int32.Parse(split[i]) < 0)
		{
			count++;
		}
	}

	//Display the solution
	Console.WriteLine(count);
    }
}
