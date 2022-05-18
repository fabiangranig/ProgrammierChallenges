using System;

public class Program
{
    public static void Main()
    {
        //Guide:
        //Start value: 7
        //Up - Skru op!
        //Down - Skru ned!
        
        //Get how many lines areto follow
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Go through with for-loop and get the specific lines
        int start_value = 7;
        for(int i = 0; i < n; i++)
        {
            //Get the line
            string line = Convert.ToString(Console.ReadLine());

            //If the value gets turned up
            if(line == "Skru op!" && start_value + 1 < 11)
            {
                //Turn the value up
                start_value++;
            }

            //If the value get turned one down
            if(line == "Skru ned!" && start_value - 1 > -1)
            {
                //Set the value one down
                start_value--;
            }
        }

        //Output the solution
        Console.WriteLine(start_value);
    }
}
