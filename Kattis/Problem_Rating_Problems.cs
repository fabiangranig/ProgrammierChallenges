using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the string
        string[] h = o.Split(" ");
        
        //Get the rest of the input
        string[] l = new String[Int32.Parse(h[0])];
        for(int i = 0; i < Int32.Parse(h[1]); i++)
        {
            //Fill that lines in
            l[i] = Convert.ToString(Console.ReadLine());
        }

        //Fill in the rest of the line and calculate the minimum
        double sum = 0;
        for(int i = 0; i < Int32.Parse(h[0]); i++)
        {
            if(l[i] == null)
            {
                l[i] = "-3";
            }

            sum += Convert.ToDouble(l[i]);
        }

        //Calculate the minimum
        double avg = sum / Int32.Parse(h[0]);

        //Output the minimum
        Console.Write(avg + " ");

        //Refill the rest with max numbers
        sum = 0;
        for(int i = Int32.Parse(h[1]); i < Int32.Parse(h[0]); i++)
        {
            l[i] = "3";
        }
        
        for(int i = 0; i < Int32.Parse(h[0]); i++)
        {
            sum += Int32.Parse(l[i]);
        }

        avg = sum / Int32.Parse(h[0]);

        //Output the maximum
        Console.Write(avg);
    }
}
