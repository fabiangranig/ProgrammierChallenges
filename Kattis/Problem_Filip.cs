using System;

public class Program
{
    static string Reversing(string h)
    {
        //Go through with for loop backwards
        string sol = "";
        for(int i = 0; i < h.Length; i++)
        {
            sol += Convert.ToString(h[h.Length - 1 - i]);
        }
        
        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Split the input
        string[] u = o.Split(" ");

        //Reverse the two numbers
        int n1 = Int32.Parse(Reversing(u[0]));
        int n2 = Int32.Parse(Reversing(u[1]));

        //Output the larger number
        if(n1 > n2)
        {
            Console.WriteLine(n1);
        }
        else
        {
            Console.WriteLine(n2);
        }
    }
}
