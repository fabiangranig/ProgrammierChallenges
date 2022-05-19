using System;

public class Program
{
    public static void Main()
    {
        //Get and split the numbers
        string input = Convert.ToString(Console.ReadLine());
        string[] split = input.Split(" ");

        //Calculate a full clock
        int full_clock = 24 * 60;

        //Get the minutes of the given time
        int current_clock = Int32.Parse(split[0]) * 60 + Int32.Parse(split[1]);

        //Remove 45 minutes
        current_clock -= 45;

        //When clock is below zero
        if(current_clock < 0)
        {
            current_clock = full_clock + current_clock;
        }

        //When the time is to high
        if(current_clock > full_clock)
        {
            current_clock -= full_clock;
        }

        //Transform it into hh:mm
        int current_clock_hour = current_clock / 60;
        int current_clock_minutes = current_clock % 60;

        //Output the solution
        Console.WriteLine(current_clock_hour + " " + current_clock_minutes);
    }
}
