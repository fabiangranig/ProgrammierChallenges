using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        int W = Int32.Parse(Convert.ToString(Console.ReadLine()));
        
        //Get the rest of the input and calculate the surface
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));
        int sum = 0;
        for(int i = 0; i < n; i++)
        {
            string o = Convert.ToString(Console.ReadLine());
            string[] u = o.Split(" ");
            sum += (Int32.Parse(u[0]) * Int32.Parse(u[1]));
        }

        //Divide to get the solution
        int L = sum / W;
        
        //Output the solution
        Console.WriteLine(L);
    }
}
