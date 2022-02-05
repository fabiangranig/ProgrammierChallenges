using System;

public class Program
{
    public static void Main()
    {
	    //X = how many megabytes he has each months
	    //N = how many months there are
	    //Pi = used in each month
	    
	    //Get the first two lines
	    int X = Int32.Parse(Console.ReadLine());
	    int N = Int32.Parse(Console.ReadLine());
	    int[] array = new Int32[N];	    

	    //Get the Rest of the lines
	    int o = 0;
	    while(o <  N)
	    {
		array[o] = Int32.Parse(Console.ReadLine());
		o++;
	    }

	    //Calculation
	    //Calculate the max of the bandwith
	    int max_bandwith = X * (N +1);

	    //Calculate the needed bandwith
	    int needed_bandwith = 0;
	    for(int i = 0; i < array.Length; i++)
	    {
		    needed_bandwith += array[i];
	    }

	    //Calculate the rest
	    int solution = max_bandwith - needed_bandwith;

	    //Output the solution
	    Console.WriteLine(solution);
    }
}
