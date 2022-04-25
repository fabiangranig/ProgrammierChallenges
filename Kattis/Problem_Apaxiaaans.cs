using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Remove the double letters
        string output = "";
        char last_char = '1';
        for(int i = 0; i < input.Length; i++)
        {
            char a = input[i];
            if(last_char != a)
            {
                output += Convert.ToString(a);
                last_char = a;
            }
        }

        //Output the solution
        Console.WriteLine(output);
    }
}
