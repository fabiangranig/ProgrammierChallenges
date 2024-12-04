using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            int part1_solution = Part1(input);
            Console.WriteLine("This solution to part 1 is: " + part1_solution);

            int part2_solution = Part2(input);
            Console.WriteLine("This solution to part 2 is: " + part2_solution);
        }

        static int Part1(string[] input)
        {
            int sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                string line = input[i];
                sum += SearchForProduct(line);
            }
            return sum;
        }

        static int Part2(string[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string line = input[i];
                sum += SearchForProduct2(line);
            }
            return sum;
        }

        static int SearchForProduct(string line)
        {
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (i + 4 < line.Length && line[i] == 'm' && line[i + 1] == 'u' && line[i + 2] == 'l' && line[i + 3] == '(')
                {
                    string StartOfSearchedValue = line.Substring(i + 4);
                    string[] split1 = StartOfSearchedValue.Split(',');
                    string[] split2 = split1[1].Split(')');
                    int number1;
                    bool case1 = Int32.TryParse(split1[0], out number1);
                    int number2;
                    bool case2 = Int32.TryParse(split2[0], out number2);

                    if(case1 && case2)
                    {
                        sum += number1 * number2;
                    }
                }
            }
            return sum;
        }

        static bool enabled = true;

        static int SearchForProduct2(string line)
        {
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if(i + 4 < line.Length && line.Substring(i, 4) == "do()")
                {
                    enabled = true;
                }

                if(i + 7 < line.Length && line.Substring(i, 7) == "don't()")
                {
                    enabled = false;
                }

                if (i + 4 < line.Length && line[i] == 'm' && line[i + 1] == 'u' && line[i + 2] == 'l' && line[i + 3] == '(')
                {
                    string StartOfSearchedValue = line.Substring(i + 4);
                    string[] split1 = StartOfSearchedValue.Split(',');
                    string[] split2 = split1[1].Split(')');
                    int number1;
                    bool case1 = Int32.TryParse(split1[0], out number1);
                    int number2;
                    bool case2 = Int32.TryParse(split2[0], out number2);

                    if (case1 && case2 && enabled)
                    {
                        sum += number1 * number2;
                    }
                }
            }
            return sum;
        }
    }
}
