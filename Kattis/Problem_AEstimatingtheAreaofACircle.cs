using System;

public class Program
{
    static double[] getVal(double j, double h, double n)
    {
        //Create an array for the solution
        double[] sol = new Double[2];

        //Get the real solution
        sol[0] = Math.Pow(j, 2) * Math.PI;

        //Get the second solution
        sol[1] = (n / h) * ((j+j) * (j+j));

        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the input
        string[] output = new String[1000];

        //Read in the input
        for(int i = 0; i < 1000; i++)
        {
            //Get the line
            string n = Convert.ToString(Console.ReadLine());

            //Check if the line should break the for-loop
            if(n == "0 0 0")
            {
                output[i] = n;
                break;
            }

            //Calculate the solution
            string[] u = n.Split(" ");
            double[] sol = getVal(Convert.ToDouble(u[0]), Convert.ToDouble(u[1]), Convert.ToDouble(u[2]));
            
            //Save the solution
            output[i] = sol[0] + " " + sol[1];
        }

        //Output the solution
        for(int i = 0; i < 1000; i++)
        {
            //Check for break
            if(output[i] == "0 0 0")
            {
                break;
            }

            //Output the solution
            Console.WriteLine(output[i]);
        }
    }
}
