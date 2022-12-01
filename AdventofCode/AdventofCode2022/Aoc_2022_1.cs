using System;
using System.IO;
using System.Collections.Generic;

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            //Save the sums in an list
            List<int> sums = new List<int>();
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                //If end is found return the solution to the list
                if(numbers[i] == "")
                {
                    sums.Add(sum);
                    sum = 0;
                }
                else
                {
                    //Add the numbers togheter
                    sum += Int32.Parse(numbers[i]);
                }
            }

            //Get the max
            int max = 0;
            for(int i = 0; i < sums.Count; i++)
            {
                if(sums[i] > max)
                {
                    max = sums[i];
                }
            }

            //Output the Maximum
            Console.WriteLine("The solution of Part1 is: " + max);

            //Convert the list into an array
            int[] arr = new Int32[sums.Count];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = sums[i];
            }

            //Sort the array
            Array.Sort(arr);
            
            //Output the sum of first three values
            int top_three_values = 0;
            for(int i = 0; i < 3; i++)
            {
                top_three_values += arr[arr.Length - 1 - i];
            } 
            Console.WriteLine("The solution of Part 2 is: " + top_three_values);
        }
    }
}
