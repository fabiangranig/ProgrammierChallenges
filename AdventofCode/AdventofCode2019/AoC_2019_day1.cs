using System;
using System.Collections.Generic;

//Part1
//Answer 1 - 3152409 - wrong
//Answer 2 - 3152375 - right

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get all lines and also convert to int
            List<int> input = new List<int>();
            int current_run = Int32.Parse(Convert.ToString(Console.ReadLine()));
            while(current_run != -1)
            {
                input.Add(current_run);
                current_run = Int32.Parse(Convert.ToString(Console.ReadLine()));
            }

            //Get the first Part
            Console.WriteLine("Solution of the first part is: " + Part1(input));

            //Get the second Part
            Console.WriteLine("Solution of the second part is: " + Part2(input));
        }

        static int Part1(List<int> input)
        {
            //Get the sum which is needed
            double sum = 0;
            
            //Calculate the solution
            for(int i = 0; i < input.Count; i++)
            {
                sum += Math.Floor(input[i] / 3.0 - 2);
            }

            //Return the solution
            return Convert.ToInt32(sum);
        }

        static int Part2(List<int> input)
        {
            //Get the sum
            double sum = 0;

            //Go through with for-loop
            for(int i = 0; i < input.Count; i++)
            {
                //Get the current value
                double c_value = input[i];

                //Process the next value
                while(c_value / 3 - 2 > 0)
                {
                    c_value = Math.Floor(c_value / 3.0) - 2;
                    sum += c_value;
                }
            }

            //Return the solution
            return Convert.ToInt32(sum);
        }
    }
}
