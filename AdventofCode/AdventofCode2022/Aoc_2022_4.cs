using System;
using System.IO;

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
           
            //Go through every output
            int solution = 0;
            int solution2 = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                //Get the input string for this itteration
                string input = numbers[i];

                //Split the string and check if the string contains the other
                string[] split = input.Split(",");
                string[] split1 = split[0].Split("-");
                string[] split2 = split[1].Split("-");

                int number1 = Int32.Parse(split1[0]);
                int number2 = Int32.Parse(split1[1]);
                int number3 = Int32.Parse(split2[0]);
                int number4 = Int32.Parse(split2[1]);

                //Two if conditions to check if they are between them
                if(number1 >= number3 && number2 <= number4)
                {
                    solution++;
                }
                else if(number3 >= number1 && number4 <= number2)
                {
                    solution++;
                }

                //Get the string of the first input
                string build = BuildString(split[0]);
                for(int u = number3; u < number4 + 1; u++)
                {
                    string tester = "+" + u + "+";
                    if(build.Contains(tester))
                    {
                        solution2++;
                        break;
                    }
                }
            }

            Console.WriteLine("The solution of the first part is: " + solution);
            Console.WriteLine("The solution of the second part is: " + solution2);
        }

        static string BuildString(string input)
        {
            //Split the string
            string[] split = input.Split("-");

            //Convert both numbers into an integer and build it
            string solution = "";
            int number1 = Int32.Parse(split[0]);
            int number2 = Int32.Parse(split[1]);
            for(int i = number1; i < number2 + 1; i++)
            {
                solution += "+" + i + "+";
            }

            //Return the solution
            return solution;
        }
    }
}
