using System;

public class Program
{
    //Check the first three characters, if they are "555"
    static bool first3(string o)
    {
        //Go through with an for-loop
        bool switch1 = true;
        for(int i = 0; i < 3; i++)
        {
            if(o[i] != '5')
            {
                switch1 = false;
            }
        }

        //Return the solution
        return switch1;
    }

    public static void Main()
    {
        //Get the input
        string u = Convert.ToString(Console.ReadLine());

        //Check what Output should be given out
        bool sol = first3(u);

        //Output the solution
        if(sol == true)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
