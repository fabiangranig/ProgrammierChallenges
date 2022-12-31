using System;

public class Program
{
    public static void Main()
    {
        //Get the five contestants
        string[] input = new String[5];
        for(int i = 0; i < input.Length; i++) 
        { 
            input[i] = Convert.ToString(Console.ReadLine()); 
        }

        //Get the sums
        int[] sums = new Int32[5];
        for(int i = 0; i < sums.Length; i++)
        {
            string[] temp = input[i].Split(" ");
            for(int u = 0; u < temp.Length; u++)
            {
                sums[i] += Int32.Parse(temp[u]);
            }
        }

        //Get the max
        int indexer = -1;
        int sum = -1;
        for(int i = 0; i < sums.Length; i++)
        {
            if(sum < sums[i])
            {
                indexer = i;
                sum = sums[i];
            }
        }

        //Output the solution
        Console.WriteLine((indexer+1) + " " + sum);
    }
}
