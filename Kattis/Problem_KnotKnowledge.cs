using System;

public class Program
{
    public static void Main()
    {
        //Get the amount of numbers to follow
        int numbers_count = Convert.ToInt32(Console.ReadLine());

        //Get both lines of input
        string input_all = Convert.ToString(Console.ReadLine());
        string input_not_all = Convert.ToString(Console.ReadLine());
        string[] split = input_all.Split(" ");
        input_not_all = " " + input_not_all + " ";
    
        //Use C# build-in function
        for(int i = 0; i < split.Length; i++)
        {
            if(!input_not_all.Contains(" " + split[i] + " "))
            {
                Console.WriteLine(split[i]);
                break;
            }
        }
    }
}
