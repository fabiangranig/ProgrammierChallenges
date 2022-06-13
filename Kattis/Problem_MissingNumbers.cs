using System;

public class Program
{
    public static void Main()
    {
        //Get how many inputs are to follow
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get all items into an array and into an string
        int[] arr = new Int32[n];
        string input = " ";
        for(int i = 0; i < n; i++)
        {
            arr[i] = Int32.Parse(Convert.ToString(Console.ReadLine()));
            input += arr[i] + " ";
        }

        //Go through with for-loop and check which numbers are missing
        string sol = "";        
        for(int i = 1; i <= n; i++)
        {
            if(!input.Contains(" " + Convert.ToString(i) + " "))
            {
                sol += i + " ";
                n++;
            }
        }
        
        //When there are no answers
        if(sol == "")
        {
            Console.WriteLine("good job");
        }
        else
        {
            //Output the found solution
            string[] split = sol.Split(" ");
            for(int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
            }
        }
    }
}
