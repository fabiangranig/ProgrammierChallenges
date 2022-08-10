using System;
using static FG.Lib1;

public class Program
{
    public static void Main()
    {
        //Get the line of input as an string
        string input = Convert.ToString(Console.ReadLine());

        //Build each number in binary with four numbers
        string[] arr = new String[4];
        for(int i = 0; i < input.Length; i++)
        {
            //Get the current number
            int current_number = Int32.Parse(Convert.ToString(input[i]));

            //Build the string out of it
            string output = "";
            for(int u = 0; u < input.Length; u++)
            {
                output += Convert.ToString(BitAtPosition(current_number, u));
            }

            //Save the string to the array
            arr[i] = output;
        }

        //Build the output format
        string[] formated = new String[4];
        for(int i = 0; i < input.Length; i++)
        {
            string output2 = "";
            for(int i2 = 0; i2 < input.Length; i2++)
            {
                //If the index is 2 add the space
                if(i2 == 2)
                {
                    output2 += "   ";
                }
                
                //Add the spaces on the specific places
                if(i2 == 1 || i2 == 3)
                {
                    output2 += " ";
                }
                
                //Get the number
                int a = Int32.Parse(Convert.ToString(arr[i2][3 - i]));

                //Check what to add
                if(a == 1)
                {
                    output2 += "*";
                }
                else if (a == 0)
                {
                    output2 += ".";
                }
            }

            //Put the output2 into the array
            formated[i] = output2;
        }

        //Output the solution
        for(int i = 0; i < formated.Length; i++)
        {
            Console.WriteLine(formated[i]);
        }
    }
}
