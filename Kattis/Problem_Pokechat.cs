using System;

public class Program
{
    public static void Main()
    {
        //Get the ASCII Palette and required output format
        string palette = Convert.ToString(Console.ReadLine());
        string output = Convert.ToString(Console.ReadLine());

        //Get an output array
        string[] arr = new String[output.Length / 3];
        string sol = "";
        int stack_count = 0;
        int add_count = 0;
        for(int i = 0; i < output.Length; i++)
        {
            if(add_count < 2)
            {
                sol += Convert.ToString(output[i]);
                add_count++;
            }
            else
            {
                sol += Convert.ToString(output[i]);
                arr[stack_count] = sol;
                stack_count++;
                sol = "";
                add_count = 0;
            }   
        }

        //Output the solution
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(Convert.ToString(palette[Int32.Parse(arr[i]) - 1]));
        }
    }
}
