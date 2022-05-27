using System;

public class Program
{
    public static void Main()
    {
        //Put the string between the two strings
        string s1 = "Thank you, ";
        string s2 = ", and farewell!";

        //Get the string
        string input = Convert.ToString(Console.ReadLine());

        //Output the solution
        Console.WriteLine(s1 + input + s2);
    }
}
