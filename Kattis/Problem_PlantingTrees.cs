using System;

public class Program
{
    static int Calculate(int[] arr)
    {
        //Check the first number then proceed checking with this number till it isn't that number anymore
        int sol = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            int temp = (i + 1) + arr[i];

            if(sol < temp)
            {
                sol = temp;
            }
        }

        //Return the solution wiht one day party preparations
        return sol + 1;
    }

    static int[] ArrayReverse(int[] temp)
    {
        //Create an array and sort in in the opposite direction
        int[] arr = new Int32[temp.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[arr.Length - 1 - i] = temp[i];
        }

        //Return the solution
        return arr;
    }    

    public static void Main()
    {
        //Get how many trees there are and how long it takes to grow them
        int many = Int32.Parse(Convert.ToString(Console.ReadLine()));
        string trees = Convert.ToString(Console.ReadLine());

        //Split the string into parts
        string[] split = trees.Split(" ");

        //Sort these trees into an int array
        int[] arr = new Int32[many];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Int32.Parse(split[i]);
        }

        //Sort the Array and Reverse it
        Array.Sort(arr);
        int[] arr2 = ArrayReverse(arr);

        //Get the solution
        int sol = Calculate(arr2);

        //Output the solution
        Console.WriteLine(sol);
    }
}
