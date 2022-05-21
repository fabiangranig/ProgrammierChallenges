using System;

public class Program
{
    static bool Possible(int n1, int n2, int sol)
    {
        //Check if one of the desired methods works
        if(n1 + n2 == sol)
        {
            return true;
        }
        if(n1 - n2 == sol)
        {
            return true;
        }
        if(n1 * n2 == sol)
        {
            return true;
        }
        if(Convert.ToDouble(n1) / Convert.ToDouble(n2) == sol)
        {
            return true;
        }

        //If nothing works return false
        return false;
    }

    static bool Calculate(int n1, int n2, int sol)
    {
        //Get both possible ways
        bool m1 = Possible(n1, n2, sol);
        bool m2 = Possible(n2, n1, sol);

        //Return the solution
        if(m1 == true || m2 == true)
        {
            return true;
        }
        
        //If it is false
        return false;   
    }

    public static void Main()
    {
        //Get the number of lines
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get every line of input
        string[] input = new String[n];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Convert.ToString(Console.ReadLine());
        }

        //Split the contents and get the solution
        bool[] sol_arr = new bool[input.Length];
        for(int i = 0; i < input.Length; i++)
        {
            //Split
            string[] split = input[i].Split(" ");

            //Save into new variables
            int n1 = Int32.Parse(split[0]);
            int n2 = Int32.Parse(split[1]);
            int sol = Int32.Parse(split[2]);

            //Calculate the solution
            sol_arr[i] = Calculate(n1, n2, sol);
        }

        //Output the solution
        for(int i = 0; i < sol_arr.Length; i++)
        {
            if(sol_arr[i] == true)
            {
                Console.WriteLine("Possible");
            }
            else
            {
                Console.WriteLine("Impossible");
            }
        }
    }
}
