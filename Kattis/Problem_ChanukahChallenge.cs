using System;

public class Program
{
    static string Calc(string text)
    {
        //Split the input
        string[] split = text.Split(" ");

        //Get the number which is needed for calculation
        int a = Int32.Parse(split[1]);

        //Go through an for-loop and get the sum
        int sum = 0;
        for(int i = 2; i < a + 2; i++)
        {
            sum += i;
        }

        //Return the solution
        string output = split[0] + " " + sum;
        return output;
    }

    public static void Main()
    {
        //Get how many inputs are to follow
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the real input into an string array
        //Also in the same loop output the solution for that set
        string[] arr = new String[n];
        string[] arr2 = new String[n];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
            
            //Calculate the set
            arr2[i] = Calc(arr[i]);
        }

        //Output the solution
        for(int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i]);
        }
    }
}
