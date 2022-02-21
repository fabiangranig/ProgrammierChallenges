using System;

public class Program
{
    public static void Main()
    {
	//Get the input
	int input = Convert.ToInt32(Console.ReadLine());

	//Output the "Abracadabra"
	for(int i = 1; i < input + 1; i++)
	{
		//Output
		Console.WriteLine(i + " Abracadabra");
	}
    }
}
