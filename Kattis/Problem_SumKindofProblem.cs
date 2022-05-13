using System;

public class Program
{
    static string Calculate(string input)
    {
        //Split all the lines
        string[] split = input.Split(" ");

        //Get the values out of that string
        int number = Int32.Parse(split[0]);
        int calc = Int32.Parse(split[1]);

        //Sum of the positive integers, odd integers and even integers
        int pos = 0;
        int odd = 0;
        int even = 0;
        for(int i = 0; i < calc * 2 + 1; i++)
        {
            //Make the sum of the positive integer
            if(i < calc + 1)
            {
                pos += i;
            }

            //Make the sum of the odd integers
            if(i % 2 == 1)
            {
                odd += i;
            }

            //Make the sum of the even interger
            if(i % 2 == 0)
            {
                even += i;
            }
        }

        //Build the solution string
        string sol = number + " " + pos + " " + odd + " " + even;

        //Return teh solution
        return sol;
    }

    public static void Main()
    {
        //Get how many lines there are
        int arr_length = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get all the lines
        string[] arr = new String[arr_length];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
        }

        //Go through and get the solution
        for(int i = 0; i < arr.Length; i++)
        {
            //Compute each array slot
            string sol = Calculate(arr[i]);

            //Output the solution
            Console.WriteLine(sol);
        }
    }
}
