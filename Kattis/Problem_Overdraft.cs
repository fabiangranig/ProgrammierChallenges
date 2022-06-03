using System;

public class Program
{
    static int GetLowest(int[] nums)
    {
        //Go through all numbers and get the lowest value
        int lowest = 0;
        int current_bank = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            //Add the next value to the account
            current_bank += nums[i];

            //Check if is the lowest
            if(current_bank < 0 && current_bank < lowest)
            {
                lowest = current_bank;
            }
        }

        //Return the solution
        return lowest;
    }

    static int[] GetInput(int n)
    {
        //Go through with for-loop and add the elements to the array
        int[] input = new Int32[n];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Int32.Parse(Convert.ToString(Console.ReadLine())); 
        }

        //Return the solution
        return input;
    }

    public static void Main()
    {
        //Get how many input lines there are
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the rest of the lines
        int[] input = GetInput(n);

        //Get the lowest number
        int low_num = GetLowest(input);

        //Make it positive
        low_num *= -1;

        //Output the solution
        Console.WriteLine(low_num);
    }
}
