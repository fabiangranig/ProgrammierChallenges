using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        int set_length = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the sets
        string[] sets = new String[set_length];
        for(int i = 0; i < sets.Length; i++)
        {
            sets[i] = Convert.ToString(Console.ReadLine());
        }

        //Create a solution array and get the solution
        for(int i = 0; i < sets.Length; i++)
        {
            //Get all the numbers out of the set
            string set = sets[i];
            string[] set_split = set.Split(" ");
            int[] arr = new Int32[set_split.Length];
            for(int u = 0; u < set_split.Length; u++)
            {
                arr[u] = Int32.Parse(set_split[u]);
            }

            //Get the Average
            double sum = 0;
            for(int u = 1; u < arr.Length; u++)
            {
                sum += arr[u];
            }
            double average = sum / Convert.ToDouble(arr[0]);
            
            //Go through an check how many are above average
            int count = 0;
            for(int u = 0; u < arr.Length; u++)
            {
                if(average < arr[u])
                {
                    count++;
                }
            }

            //Get the percent of how many
            double sol = Convert.ToDouble(count) / arr[i] * 100;

            //Output the solution
            Console.WriteLine(Math.Round(sol, 3) + "%");
        }
    }
}
