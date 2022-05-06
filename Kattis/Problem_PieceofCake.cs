using System;

public class Program
{
    static int Calculate(int[] array)
    {
        //Get the biggest
        int u = -1;
        int u_size = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if(u_size < array[i])
            {
                u_size = array[i];
                u = i;
            }
        }

        //Return the solution
        return u;
    }

    public static void Main()
    {
        //Get the input line
        string input = Convert.ToString(Console.ReadLine());
        string[] split = input.Split(" ");

        //Get the site of the cake
        int site = Int32.Parse(split[0]);

        //Get the cuts
        int h = Int32.Parse(split[1]);
        int v = Int32.Parse(split[2]);

        //Calculate all 4 squares
        int[] arr = new Int32[4];
        arr[0] = h * v;
        arr[1] = h * (site - v);
        arr[2] = (site - h) * v;
        arr[3] = (site - h) * (site -v);

        //Get the biggest of the array
        int u = Calculate(arr);

        //Calculate the solution
        int sol = arr[u] * 4;

        //Output the solution
        Console.WriteLine(sol);
    }
}
