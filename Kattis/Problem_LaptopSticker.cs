using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] split = input.Split(" ");

        //Get the single integer values
        int laptop_width = Int32.Parse(split[0]);
        int laptop_height = Int32.Parse(split[1]);
        int sticker_width = Int32.Parse(split[2]);
        int sticker_height = Int32.Parse(split[3]);

        //Put away the border
        laptop_width -= 2;
        laptop_height -= 2;

        //Check if there is enough space
        if(laptop_width >= sticker_width && laptop_height >= sticker_height)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
