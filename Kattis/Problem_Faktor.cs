using System;

public class Program
{
    static int Faktor(double a, double b)
    {
    	//Get the solution by bruteforce
	a -= 1;
	a += 0.01;
	for(int i = 0; i < 101; i++)
	{
		//Calculate and return if it is right
		if((b * Math.Round(a, 2)) % 1 == 0)
		{
			//Return the solution
			return Convert.ToInt32(b * a);
		}

		//Add 0.01 to the number
		a += 0.01;
	}
	
	//If everything is false return the normal Multiplication
	return -1;
    }

    public static void Main()
    {
	//Get the input
	string o = Convert.ToString(Console.ReadLine());

	//Split the string
	string[] array_string = o.Split(" ");

	//Convert it to integers
	int[] array = new int[2];
	for(int i = 0; i < array.Length; i++)
	{
		//Convert it
		array[i] = Int32.Parse(array_string[i]);
	}

	if(array[1] > array[0])
	{
		//Swap input
		int c = array[0];
		array[0] = array[1];
		array[1] = c;
	}
	
	//Output the solution
	Console.WriteLine(Faktor(array[0], array[1]));
    }
}
