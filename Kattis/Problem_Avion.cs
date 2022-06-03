using System;

public class Program
{
    static string[] GetInput()
    {
        //Go through for-loop and add to the array
        string[] input = new String[5];
        for(int i = 0; i < 5; i++)
        {
            input[i] = Convert.ToString(Console.ReadLine());
        }

        //Return the solution
        return input;
    }

    static string Calculate(string[] input)
    {
        //Add lines in which there is the word "FBI"
        string sol = "";
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i].Contains("FBI"))
            {
                int number = i + 1;
                sol += number + " ";
            }
        }

        //If there is no number found get the second input
        if(sol == "")
        {
            sol = "HE GOT AWAY!";
        }

        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the five lines of input into an array
        string[] input = GetInput();

        //Get the solution to the problem
        string sol = Calculate(input);

        //Output the solution
        Console.WriteLine(sol);
    }
}
