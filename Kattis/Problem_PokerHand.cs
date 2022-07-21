using System;

public class Program
{
    public static void Main()
    {
        //Get the line of input
        string input = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] split = input.Split(" ");
    
        //Count each character
        int highest_count = -1;
        for(int i = 0; i < split.Length; i++)
        {
            //Current character
            char current_char = split[i][0];

            //Count how often this card appears
            int count = 0;
            for(int u = 0; u < split.Length; u++)
            {
                if(current_char == split[u][0])
                {
                    count++;
                }
            }

            //If the count is higher set it as new highest
            if(highest_count < count)
            {
                highest_count = count;
            }
        }

        //Output the solution
        Console.WriteLine(highest_count);
    }
}
