using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string a = Convert.ToString(Console.ReadLine());
        string b = Convert.ToString(Console.ReadLine());

        //Split the second input
        string[] c = b.Split(" ");

        //Go through and add the right values up
        int count = 0; 
        double sum = 0;
        for(int i = 0; i < c.Length; i++)
        {
            //Get the working number
            int v = Int32.Parse(c[i]);
            if(v > -1)
            {
                count++;
                sum += v;
            }
        }

        //Output the solution
        Console.WriteLine(sum / count);
    }
}
