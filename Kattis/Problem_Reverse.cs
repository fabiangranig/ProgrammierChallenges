using System;

public class Program
{
    public static void Main()
    {
        //Get how many input are to follow
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the inputs into an array
        string[] arr = new String[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
        }

        //Get the output in the Reverse Order
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[n - 1 - i]);
        }
    }
}
