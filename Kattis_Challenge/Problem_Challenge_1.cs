using System;
using static FG.Lib1;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());
        
        //Make space for the different counters
        int whitespace = 0;
        int lowercase = 0;
        int uppercase = 0;
        int symbol_count = 0;

        //Loop through and every none defined value is an symbol
        bool symbol = true;
        for(int i = 0; i < input.Length; i++)
        {
            if(Convert.ToInt32(input[i]) > 64 && Convert.ToInt32(input[i]) < 91)
            {
                uppercase++;
                symbol = false;
            }
            if(Convert.ToInt32(input[i]) > 96 && Convert.ToInt32(input[i]) < 123)
            {
                lowercase++;
                symbol = false;
            }
            if(input[i] == '_')
            {
                whitespace++;
                symbol = false;
            }
            if(symbol == true)
            {
                symbol_count++;
            }
            symbol = true;
        }

        //Output the ratio of the values
        double full_length = input.Length;
        Console.WriteLine(SwitchDotandComa(Convert.ToString(whitespace / full_length), '.'));
        Console.WriteLine(SwitchDotandComa(Convert.ToString(lowercase / full_length), '.'));
        Console.WriteLine(SwitchDotandComa(Convert.ToString(uppercase / full_length), '.'));
        Console.WriteLine(SwitchDotandComa(Convert.ToString(symbol_count / full_length), '.'));
    }
}
