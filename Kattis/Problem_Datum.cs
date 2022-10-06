using System;

public class Program
{
    static int PassThrough(int sum)
    {
        
    }

    public static void Main()
    {
        //Get the the days each month
        int[] days_each_month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        //Get all days
        string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        int starting_index = 3;

        //Get the input and split the input
        string input = Convert.ToString(Console.ReadLine());
        string[] split = input.Split(" ");
        int day = Int32.Parse(split[0]);
        int month = Int32.Parse(split[1]);

        //Get the sum of the days before that date
        int sum = 0;
        for(int i = 0; i < month - 1; i++)
        {
            sum += days_each_month[i];
        }

        //Add the days of this month
        sum += day;
        
        
    }
}
