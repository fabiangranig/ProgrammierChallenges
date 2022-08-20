using System;

public class Program
{
    static double MakeValuePlus(double number)
    {
        if(number < 0)
        {
            //If it is an negative number return it with * -1
            return number * -1;
        }

        //If it already was an positive number return it
        return number;
    }

    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());
        string[] split1 = input.Split(" ");

        //Put the input into double values
        double x1 = Convert.ToDouble(split1[0]);
        double y1 = Convert.ToDouble(split1[1]);
        double x2 = Convert.ToDouble(split1[2]);
        double y2 = Convert.ToDouble(split1[3]);

        //Calculate the width and height
        double width = 0;
        double height = 0;
        
        //Width
        if(x1 >= 0 && x2 >= 0 || x1 < 0 && x2 < 0)
        {
            width = MakeValuePlus(x1) - MakeValuePlus(x2);
        }
        if(x1 >= 0 && x2 < 0 || x1 < 0 && x2 >= 0)
        {
            width = MakeValuePlus(x1) + MakeValuePlus(x2);
        }
    
        //Height
        if(y1 >= 0 && y2 >= 0 || y1 < 0 && y2 < 0)
        {
            height = MakeValuePlus(y1) - MakeValuePlus(y2);
        }
        if(y1 >= 0 && y2 < 0 || y1 < 0 && y2 >= 0)
        {
            height = MakeValuePlus(y1) + MakeValuePlus(y2);
        }


        //Test: Output
        Console.WriteLine(MakeValuePlus(width * height));
    }
}
