using System;

public class Program
{
    static int[] ConArr(string[] k)
    {
        //Go through with for-Loop and convert
        int[] h = new Int32[k.Length];
        for(int i = 0; i < h.Length; i++)
        {
            h[i] = Int32.Parse(k[i]);
        }

        //Return int array
        return h;
    }

    static int[] Sol(int[] n)
    {
        //Make the array which contains the correct ammount
        int[] v = new Int32[] {1, 1, 2, 2, 2, 8};

        //Get the difference with the help of a for-loop
        for(int i = 0; i < v.Length; i++)
        {
            n[i] = v[i] - n[i];
        }

        //Return the solution
        return n;
    }

    public static void Main()
    {
        //Get the input line
        string o = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] u = o.Split(" ");

        //Convert all strings into characters
        int[] m = ConArr(u);

        //Get the solution
        int[] g = Sol(m);

        //Build the solution string
        string f = "";
        for(int i = 0; i < g.Length; i++)
        {
            f += g[i] + " ";
        }

        //Output the solution
        Console.WriteLine(f);
    }
}
