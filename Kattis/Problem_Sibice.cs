using System;

public class Program
{
    public static void Main()
    {
        //Get the first input line
        string guide = Convert.ToString(Console.ReadLine());

        //Split the string and sort it
        string[] split1 = guide.Split(" ");
        int length1 = Int32.Parse(split1[0]);
        int box_width = Int32.Parse(split1[1]);
        int box_height = Int32.Parse(split1[2]);
        
        //Get the rest of the input
        string[] arr = new String[length1];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
        }

        //Output the solution
        double calc = Math.Sqrt(Math.Pow(box_width, 2) + Math.Pow(box_height, 2));
        for(int i = 0; i < arr.Length; i++)
        {
            if(calc >= Int32.Parse(arr[i]))
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
