using System;

public class Program
{
    public static void Main()
    {
        //Get the n lines
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the rest of the input
        string[] k = new String[n];
        for(int i = 0; i < n; i++)
        {
            k[i] = Convert.ToString(Console.ReadLine());
            string[] l = k[i].Split(" ");
            
            //Convert to double variables
            double zahl1 = Convert.ToDouble(l[0]);
            double zahl2 = Convert.ToDouble(l[1]);
            
            //Get the mid heart rate
            double mid = 60 * zahl1 / zahl2;
            double temp = 60 / zahl2;
            double low = mid - temp;
            double high = mid + temp;

            //Output in array
            k[i] = Math.Round(low, 4) + " " + Math.Round(mid, 4) + " " + Math.Round(high, 4);
        }

        //Output the solution into console
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(k[i]);
        }
    }
}
