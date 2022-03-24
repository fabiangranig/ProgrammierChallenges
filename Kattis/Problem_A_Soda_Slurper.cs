using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the string
        string[] u = o.Split(" ");

        //Calculate the number of bottles
        int e = Int32.Parse(u[0]) + Int32.Parse(u[1]);
        int c = Int32.Parse(u[2]);
        int b = 0;        

        //Durchgehen mit While
        while(e - c >= 0)
        {
            b++;
            e -= c;
            e++;
        }

        Console.WriteLine(b);
    }
}
