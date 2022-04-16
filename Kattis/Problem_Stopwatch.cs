using System;

public class Program
{
    static string Calc(int[] arr)
    {
        //Quick exit if the timer hasn't stopped
        if(arr.Length % 2 != 0)
        {
            return "still running";
        }

        //Calculate the solution
        int sum = 0;
        for(int i = 0; i < arr.Length; i = i + 2)
        {
            sum += (arr[i + 1] - arr[i]);
        }

        //Return the solution
        return Convert.ToString(sum);
    }

    public static void Main()
    {
        //Get the number of times the stopwatch is pressed
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Create an array and save the times
        int[] array = new Int32[n];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Int32.Parse(Convert.ToString(Console.ReadLine()));
        }

        //Get the Output in an string
        string output = Calc(array);

        //Output the solution
        Console.WriteLine(output);
    }
}
