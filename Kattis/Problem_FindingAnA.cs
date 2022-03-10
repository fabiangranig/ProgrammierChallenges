using System;

public class Program
{
    public static void Main()
    {
	    //Get the string
	    string o = Convert.ToString(Console.ReadLine());

	    //Check where the first a is and then build the rest of the string
	    bool s = false;
	    string e = "";
	    for(int i = 0; i < o.Length; i++)
	    {
	    	if(o[i] == 'a' || o[i] == 'A')
		{
			s = true;
		}

		if(s == true)
		{
			e += Convert.ToString(o[i]);
		}
	    }

	    //Output the solution
	    Console.WriteLine(e);
    }
}
