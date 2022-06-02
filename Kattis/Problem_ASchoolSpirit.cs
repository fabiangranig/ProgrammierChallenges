using System;

public class Program
{
    public static void Main()
    {
        //Get the lines to follow
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the values into an array
        int[] arr = new Int32[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Int32.Parse(Convert.ToString(Console.ReadLine()));
        }

        //Calculate the solution
        double sol = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sol += arr[i] * Math.Pow((4.0/5), i);
        }
        sol *= 1.0/5;

        //Output the solution
        Console.WriteLine(sol);

        //Check with each time one missing
        double sol2 = 0;
        int count = 0;
        for(int i = 0; i < n; i++)
        {
            //Create a new array with one less space
            double[] arr2 = new Double[n - 1];
            int count2 = 0;
            for(int i2 = 0; i2 < n; i2++)
            {
                if(i2 != count)
                {
                    arr2[count2] = arr[i2];  
                    count2++;
                }
            }

            //Higher for the next step
            count++;

            //Get the solution
            double sol3 = 0;
            for(int i2 = 0; i2 < arr2.Length; i2++)
            {
                sol3 += arr2[i2] * Math.Pow((4.0/5),i2);
            }
            sol3 *= 1.0/5;
            sol2 += sol3;
        }

        //Divide through all students
        sol2 /= n;

        //Output the solution
        Console.WriteLine(sol2);
    }
}
