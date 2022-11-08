using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());
        
        //Get the word to check of
        string check = "PER";

        //Check which letters are not the same
        int sol = 0;
        int count = 0;
        for(int i = 0; i < input.Length; i++)
        {
            if(Convert.ToString(input[i]) != Convert.ToString(check[count]))
            {
                sol++;
            }

            count++;

            if(count == 3)
            {
                count = 0;
            }
        }

        //Output the solution
        Console.WriteLine(sol);
    }
}
