using System;

public class Program
{
    public static void Main()
    {
	//Get the lines
	int input = Convert.ToInt32(Console.ReadLine());

	//Get the numbers and get the solution
	string in_text;
	int sum = 0;
	for(int i = 0; i < input; i++)
	{
		//Get the numbers
		in_text = Convert.ToString(Console.ReadLine());

		//Calculate the sum
		int a = number_withoutlast(in_text);
		int b = Int32.Parse(Convert.ToString(in_text[in_text.Length - 1]));
		sum += Convert.ToInt32(Math.Pow(a, b));
	}

	//Output the solution
	Console.WriteLine(sum);
    }

    //Gets the number of without the last chracter of the number
    public static int number_withoutlast(string a)
    {
    	//Get the numbers
	string output = "";
	for(int i = 0; i < a.Length - 1; i++)
	{
		output += Convert.ToString(a[i]);
	}

	//Return the solution
	return Int32.Parse(output);
    }
}
