using System;

public class Program
{
    static int Match_Char(string a1, string a2)
    {
        //Go through with for-Loop
        int count = 0;
        for(int i = 0; i < a1.Length; i++)
        {
            if(a1[i] != a2[i])
            {
                count++;
            }
        }

        //Return the solution
        return count;
    }

    public static void Main()
    {
        //Get the two inputs
        string r_pass = Convert.ToString(Console.ReadLine());
        string f_pass = Convert.ToString(Console.ReadLine());

        //Get the number of characters that match
        int count = Match_Char(r_pass, f_pass);

        //Output the solution
        Console.WriteLine(Math.Pow(2, count));
    }
}
