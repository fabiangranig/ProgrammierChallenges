using System;
using System.Collections.Generic;

public class Program
{
    static int[] timetable(int[] arr)
    {
        //Compute  the time table
        int[] arr2 = new Int32[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            if(i == 0)
            {
                arr2[i] = arr[i];
            }
            if(i > 0)
            {
                arr2[i] = arr[i] - arr[i - 1];
            }
        }

        //Return the array
        return arr2;
    }

    static string Calculate(string[] arr)
    {
        //Get the start of each set
        List<int> indexes = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(!arr[i].Contains(" "))
            {
                indexes.Add(i);
            }
        }

        //Go through the start indexes and get the sum of the miles
        string sol = "";
        for(int i = 0; i < indexes.Count; i++)
        {
            //Start value
            int start = indexes[i] + 1;
            int length = Int32.Parse(arr[indexes[i]]);

            //Go through this set
            List<string> set = new List<string>();
            for(int u = start; u < start + length; u++)
            {
                if(u == arr.Length)
                {
                    break;
                }

                //Get the set
                set.Add(arr[u]);
            }

            //Get the Speed in one array and the time in the other one
            int[] arr_speed = new Int32[set.Count];
            int[] arr_time = new Int32[set.Count];
            for(int u = 0; u < set.Count; u++)
            {
                //Split each number
                string[] split = set[u].Split(" ");

                //Put them into the arrays
                arr_speed[u] = Int32.Parse(split[0]);
                arr_time[u] = Int32.Parse(split[1]);
            }

            //Put the time array to the task
            int[] arr_time_right = timetable(arr_time);

            //Make the solution
            int sol_sum = 0;
            for(int u = 0; u < set.Count; u++)
            {
                sol_sum += arr_speed[u] * arr_time_right[u];
            }

            //Save the miles
            if(i == 0)
            {
                sol += sol_sum + " miles";
            }
            else
            {
                sol += "\n" + sol_sum + " miles";
            }
        }

        //Return
        return sol;
    }

    public static void Main()
    {
        //Create a list for the input
        List<string> numbers = new List<string>();

        //Add all numbers to the list
        while(1 == 1)
        {
            //Get the string
            string lm = Convert.ToString(Console.ReadLine());

            if(lm == "-1")
            {
                break;
            }

            //Add the input to the list
            numbers.Add(lm);
        }

        //Put it in an string array
        string[] arr = new String[numbers.Count];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = numbers[i];
        }
        
        //Calculate the solution
        string sol = Calculate(arr);
        
        //Output the solution
        Console.WriteLine(sol);
    }
}
