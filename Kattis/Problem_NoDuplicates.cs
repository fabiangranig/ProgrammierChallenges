using System;

public class Program
{
    static bool Calculate(string[] arr)
    {
        //Go through with an for-loop an check if there are double words
        for(int i = 0; i < arr.Length; i++)
        {
            //Get the current value
            string c_val = arr[i];
            int count = 0;
            for(int u = 0; u < arr.Length; u++)
            {
                //Check if the values are the same
                if(c_val == arr[u])
                {
                    count++;
                }

                //When an value is found return true
                if(count > 1)
                {
                    return false;;
                }
            }
        }

        //If no value is found return false
        return true;
    }

    public static void Main()
    {
        //Get the input line
        string input = Convert.ToString(Console.ReadLine());

        //Split the lines
        string[] arr = input.Split(" ");

        //Calculate the solution
        bool double_words = Calculate(arr);

        //Output the solution
        if(double_words)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
