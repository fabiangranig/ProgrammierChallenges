using System;
using System.IO;

namespace _2015_2.Tag_AdventofCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Solution:
                Part1:
                    1440710 - too low
                    1448828 - too low
                    1735646 - too high
                    1588178 - right result

                Part2:
                    93532   - too low
                    3783758 - right answer
             */

            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "2015_challenge_2_input.txt";
            //Measures are defined by L*W*H
            string[] dimensions = System.IO.File.ReadAllLines(path);

            //Ergebnis
            int solution = 0;
            int solution2 = 0;

            //Go through all answers with an for
            for(int i = 0; i < dimensions.Length; i++)
            {
                //Split all values by "x"
                string[] measures = dimensions[i].Split("x");

                //Convert alls measures in an Intenger
                //Create new int array for Converting
                int[] quicksave = new Int32[measures.Length];
                for (int i2 = 0; i2 < measures.Length; i2++)
                {
                    //Convert into Intenger
                    quicksave[i2] = Int32.Parse(measures[i2]);
                }

                //Perform needed calculations for the first formular ( 2*l*w + 2*w*h + 2*h*l )
                int formular_solution1 = 2 * quicksave[0] * quicksave[1];
                int formular_solution2 = 2 * quicksave[1] * quicksave[2];
                int formular_solution3 = 2 * quicksave[2] * quicksave[0];
                int formular_solution =  formular_solution1 +  formular_solution2 + formular_solution3;

                //Add the lowest measure for extra paper
                int lowest_measure = 999999;
                if(quicksave[0] * quicksave[1] < lowest_measure)
                {
                    lowest_measure = quicksave[0] * quicksave[1];
                }
                if (quicksave[1] * quicksave[2] < lowest_measure)
                {
                    lowest_measure = quicksave[1] * quicksave[2];
                }
                if (quicksave[2] * quicksave[0] < lowest_measure)
                {
                    lowest_measure = quicksave[2] * quicksave[0];
                }

                //Adding the paper
                formular_solution += lowest_measure;

                //Put the new feet amount to the currently existing ones
                solution += formular_solution;
                
                //Part2: Ribbon
                //Get the two lowest values by using Array.Sort()
                Array.Sort(quicksave);

                //Calculate the ribbon
                solution2 += quicksave[0] + quicksave[0] + quicksave[1] + quicksave[1];
                solution2 += (quicksave[0] * quicksave[1] * quicksave[2]);
            }

            //Part1: Solution
            Console.WriteLine("The elves need {0}.Feet more of wrapping paper.", solution);
            //Part2: Solution
            Console.WriteLine("The elves need {0}.Ribon for the gifts.", solution2);
        }
    }
}
