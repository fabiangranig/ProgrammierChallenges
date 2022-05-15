using System;

public class Program
{
    static string Calculate(string s1, string s2)
    {
        //Create the solution string
        string sol = "";

        //Go through and check which characters are the same
        for(int i = 0; i < s1.Length; i++)
        {
            //When it is the same add an dot
            if(s1[i] == s2[i])
            {
                sol += ".";
            }

            //When it is not the same at *
            if(s1[i] != s2[i])
            {
                sol += "*";
            }
        }

        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the lines of input
        int lines = Int32.Parse(Convert.ToString(Console.ReadLine()));
        lines *= 2;

        //Get the rest of the lines
        string[] input = new String[lines];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Convert.ToString(Console.ReadLine());
        }

        //Get the solutions
        for(int i = 0; i < lines; i = i + 2)
        {
            //Compute the solution
            string s = Calculate(input[i], input[i + 1]);

            //Output the working values
            Console.WriteLine(input[i]);
            Console.WriteLine(input[i+1]);

            //Output the solution
            Console.WriteLine(s);

            //Output an empty Line
            Console.WriteLine("");
        }
    }
}
