using System;

public class Program
{
    public static void Main()
    {
        //Input the line
        string o = Convert.ToString(Console.ReadLine());

        //Split the lines
        string[] u = o.Split(" ");
        
        //Get the solution
        int sol = 1;
        for(int i = 0; i < u.Length; i++)
        {
            //Multiply togehter
            sol *= Int32.Parse(u[i]);
        }

        //Return the solution
        Console.WriteLine(sol);
    }
}
