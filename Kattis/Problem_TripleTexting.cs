using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Calculate the Length of one word
        int one_length = input.Length / 3;

        //Get all three of the words
        string w1 = "";
        string w2 = "";
        string w3 = "";
        for(int i = 0; i < input.Length; i++)
        {
            if(i < one_length)
            {
                w1 += Convert.ToString(input[i]);
            }
            if(i > one_length - 1 && i < one_length * 2)
            {
                w2 += Convert.ToString(input[i]);
            }
            if(i > one_length * 2 - 1 && i < one_length * 3)
            {
                w3 += Convert.ToString(input[i]);
            }
        }
        
        //Check which Wort is correct
        string sol = "Error!";
        if(w1 == w2)
        {
            sol = w1;
        }
        if(w2 == w3)
        {
            sol = w2;
        }
        if(w1 == w3)
        {
            sol = w1;
        }

        //Output the solution
        Console.WriteLine(sol);
    }
}
