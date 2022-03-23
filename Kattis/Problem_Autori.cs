using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the lines
        string[] u = o.Split("-");

        //Get the new string
        string sol = "";
        for(int i = 0; i < u.Length; i++)
        {
            //Get the first character
            sol += Convert.ToString(u[i][0]);
        }

        //Output the solution
        Console.WriteLine(sol);
    }
}
