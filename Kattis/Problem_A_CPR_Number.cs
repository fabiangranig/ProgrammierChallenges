using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the string
        string[] k = o.Split("-");

        //Create an array with all the numbers
        int[] arr = new Int32[10];
        for(int i = 0; i < 6; i++)
        {
            arr[i] = Int32.Parse(Convert.ToString(k[0][i]));
        }
        for(int i = 6; i < 10; i++)
        {
            arr[i] = Int32.Parse(Convert.ToString(k[1][i - 6]));
        }

        //Get the sum
        int sum = 4 * arr[0] + 3 * arr[1] + 2 * arr[2] + 7 * arr[3] + 6 * arr[4] + 5 * arr[5] + 4 * arr[6] + 3 * arr[7] + 2 * arr[8] + arr[9];

        //Check if you can divide it by 11 and output the answer
        if(sum % 11 == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
