using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Convert it to two integers
        int[] u = new Int32[2];
        string[] g = o.Split(" ");
        u[0] = Int32.Parse(g[0]);
        u[1] = Int32.Parse(g[1]);

        //Calculate the solution
        double solution = u[0] / (Math.Sin(Math.PI / 180 * u[1]));

        //Get if it needs to be rounded up
        bool switch1 = false;
        if(solution > Math.Round(solution))
        {
            switch1 = true;
        }
    
        //Round the solution
        solution = Math.Round(solution);

        //Add +1 when it has decimal places
        if(switch1 == true)
        {
            solution += 1;
        }

        //Output the solution
        Console.WriteLine(solution);
    }
}
