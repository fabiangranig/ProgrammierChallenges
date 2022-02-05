using System;

public class Program
{
    public static void Main()
    {
	    //X = how many megabytes he has each months
	    //N = how many months there are
	    //Pi = used in each month
	    
	    //Read in all the values
	    int i = 0;
	    int X = 0;
	    int N = 0;
	    int[] array;
	    while(Console.ReadLine() != null)
	    {
		//Read in the first and the second line
		if(i == 0)
		{
			X = Convert.ToInt32(Console.ReadLine());
		}

		if(i == 1)
		{
			N = Convert.ToInt32(Console.ReadLine());
			array = new Int32[N];
		}

		//Read in the last of the line
		if(i > 1)
		{
			array[i] = Convert.ToInt32(Console.ReadLine());
		}

		//Set the counter + 1
		i++;
	    }
    }
}
