using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_1
{
    internal class Program
    {
        //Part 1
        //right solution - 53080

        //Part 2
        //wrong solution - 52846
        //wrong solution - 52769
        //wrong solution - 52818 & +1
        //right solution - 53268


        static void Main(string[] args)
        {
            //Get puzzle input
            string[] input = System.IO.File.ReadAllLines("input.txt");

            //Get first puzzle output
            int puzzle1_solution = Puzzle1_Solver(input);
            Console.WriteLine("Puzzle 1 Solution: " + puzzle1_solution);
            int puzzle2_solution = Puzzle2_Solver(input);
            Console.WriteLine("Puzzle 2 Solution: " + puzzle2_solution);

            //To keep the program opened
            Console.ReadLine();
        }

        static int Puzzle1_Solver(string[] input)
        {
            int sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                int first_digit = FirstDigitOfString(input[i]);
                int last_digit = LastDigitOfString(input[i]);
                string full_number = Convert.ToString(first_digit) + Convert.ToString(last_digit);
                sum += Int32.Parse(full_number);
            }

            return sum;
        }

        static int Puzzle2_Solver(string[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string input_value = input[i];
                string rebuild_input = ReplaceStringNumbers(input[i]);
                int first_digit = FirstDigitOfString(rebuild_input);
                int last_digit = LastDigitOfString(rebuild_input);
                string full_number = Convert.ToString(first_digit) + Convert.ToString(last_digit);
                sum += Int32.Parse(full_number);
            }

            return sum;
        }

        static int FirstDigitOfString(string line)
        {
            for(int i = 0; i < line.Length; i++)
            {
                int output;
                bool switcher = Int32.TryParse(Convert.ToString(line[i]), out output);
                if(switcher == true)
                {
                    return output;
                }
            }

            //On error
            return -1;
        }

        static int LastDigitOfString(string line) 
        {
            for (int i = line.Length - 1; i > -1; i--)
            {
                int output;
                bool switcher = Int32.TryParse(Convert.ToString(line[i]), out output);
                if (switcher == true)
                {
                    return output;
                }
            }

            //On error
            return -1;
        }

        static string ReplaceStringNumbers(string input) 
        {
            string[] numbersAsString = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] numbersAsStringNumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for(int i = 0; i < numbersAsString.Length; i++)
            {
                input = ReplaceString(input, numbersAsString[i], numbersAsStringNumber[i]);
            }
            return input;
        }

        static string ReplaceString(string input, string searched, string replacement)
        {
            string solution = "";
            for(int i = 0; i < input.Length; i++)
            {
                int rest_values = input.Length - i;
                if (input[i] == searched[0] && rest_values > searched.Length - 1)
                {
                    bool switcher = true;
                    for(int u = 1; u < searched.Length; u++)
                    {
                        if (input[i + u] != searched[u])
                        {
                            switcher = false;
                        }
                    }

                    if(switcher == true)
                    {
                        solution += input[i];
                        solution += replacement;
                    }
                    else
                    {
                        solution += input[i];
                    }
                }
                else
                {
                    solution += input[i];
                }
            }

            return solution;
        }
    }
}
