using System;

public class Program
{
    static int CountChar(string input, string chars)
    {
        //Go through with for loop
        int count = 0;
        for(int i = 0; i < input.Length; i++)
        {
            //Check if the character has an test characters
            if(chars.Contains(Convert.ToString(input[i])))
            {
                count++;
            }
        }

        //Return the solution
        return count;
    }

    public static void Main()
    {
        //Get the input string
        string input = Convert.ToString(Console.ReadLine());

        //Get the charcters to check of
        string char_check = "AEIOUaeiou";

        //Get the solution
        int sol = CountChar(input, char_check);

        //Output the solution
        Console.WriteLine(sol);
    }
}
