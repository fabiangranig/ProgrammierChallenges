using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	string input = Convert.ToString(Console.ReadLine());

	//Split all numbers
	string[] split = input.Split(";");

	//Go through all elements and sum them up
	int sum = 0;
	for(int i = 0; i < split.Length; i++)
	{
		//Check which of the two possible parts it could be
		if(split[i].Contains("-"))
		{
			sum += number1(split[i]);
		}
		else
		{
			sum += 1;
		}
	}

	//Output the solution
	Console.WriteLine(sum);
    }

    public static int number1(string text)
    {
    	//Split the by the -
	string[] split = text.Split("-");

	//Get the number
	int sum = Int32.Parse(split[1]) - Int32.Parse(split[0]);

	//Get +1 for the task
	sum += 1;

	//Return the solution
	return sum;
    }
}
