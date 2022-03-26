using System;

public class Program
{
    public static void Main()
    {
        //Get the lines
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));
        
        //Read in the numbers
        int[] o = new Int32[n];
        for(int i = 0; i < n; i++)
        {
            o[i] = Int32.Parse(Convert.ToString(Console.ReadLine()));
        }        

        //Go through and give every number an odd or even
        //With the information output it
        for(int i = 0; i < n; i++)
        {
            if(o[i] % 2 == 0)
            {
                Console.WriteLine(o[i] + " is even");
            }
            else
            {
                Console.WriteLine(o[i] + " is odd");
            }
        }
    }
}
