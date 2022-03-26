using System;

public class Program
{
    public static void Main()
    {
        //Get the lines of input
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));
        
        //Go through and tell if it should be advertised or not
        string[] output = new String[n];
        for(int i = 0; i < n; i++)
        {
            //Get the line and split it
            string o = Convert.ToString(Console.ReadLine());
            string[] u = o.Split(" ");

            //Calculate advertisment profit and create a variable for profit without advertisment
            int no_ad = Int32.Parse(u[0]);
            int ad = Int32.Parse(u[1]) - Int32.Parse(u[2]);

            //Do the output
            if(ad > no_ad)
            {
                output[i] = "advertise";
            }
            if(no_ad > ad)
            {
                output[i] = "do not advertise";
            }
            if(ad == no_ad)
            {
                output[i] = "does not matter";
            }
        }

        //Output the solution
        for(int i = 0; i < output.Length; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}
