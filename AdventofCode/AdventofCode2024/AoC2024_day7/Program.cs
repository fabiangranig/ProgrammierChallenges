using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace AoC2024_day7
{
    internal class Program
    {
        static string[] ComputetPatterns;

        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            long part1_solution = Part1(input);
            Console.WriteLine("The solution for part one is: " + part1_solution);

            long part2_solution = Part2(input);
            Console.WriteLine("The solution for part two is: " + part2_solution);
        }

        static long Part1(string[] input)
        {
            long sum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                sum += CheckPossibleOutcome(input[i]);
            }

            return sum;
        }

        static long Part2(string[] input)
        {
            ComputetPatterns = CreatePatterns2BetterPerformence();

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += CheckPossibleOutcome2(input[i]);
            }

            return sum;
        }

        static long CheckPossibleOutcome(string line)
        {
            string[] split = line.Split(':');
            string[] numbers = RemoveLeadingString(split[1].Split(' '));
            string[] patterns = CreatePatterns();

            for(int i = 0; i < patterns.Length; i++)
            {
                if (patterns[i].Length <= (numbers.Length - 1))
                {
                    long betweenSum = CalculateWithPattern(numbers, patterns[i]);
                    if(Convert.ToString(betweenSum) == split[0])
                    {
                        return betweenSum;
                    }
                }
            }
            return 0;
        }

        static long CheckPossibleOutcome2(string line)
        {
            string[] split = line.Split(':');
            string[] numbers = RemoveLeadingString(split[1].Split(' '));
            string[] patterns = ComputetPatterns;

            for (int i = 0; i < patterns.Length; i++)
            {
                if (patterns[i].Length <= (numbers.Length - 1))
                {
                    long betweenSum = CalculateWithPattern(numbers, patterns[i]);
                    if (Convert.ToString(betweenSum) == split[0])
                    {
                        return betweenSum;
                    }
                }
            }
            return 0;
        }

        static long CalculateWithPattern(string[] numbers, string pattern)
        {
            while(numbers.Length - 1 != pattern.Length)
            {
                pattern = "0" + pattern;
            }

            long sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i == 0)
                {
                    sum += Int64.Parse(numbers[i]);
                }
                else if(pattern[i - 1] == '0')
                {
                    sum += Int64.Parse(numbers[i]);
                }
                else if (pattern[i - 1] == '1')
                {
                    sum *= Int64.Parse(numbers[i]);
                }
                else if (pattern[i - 1] == '2')
                {
                    sum = Int64.Parse(Convert.ToString(sum) + numbers[i]);
                }
            }
            return sum;
        }

        static string[] CreatePatterns()
        {
            string[] patterns = new string[100000];
            for(int i = 0; i < patterns.Length; i++)
            {
                patterns[i] = Convert.ToString(i, 2);
            }
            return patterns;
        }

        static string[] CreatePatterns2()
        {
            string[] patterns = new string[50000];
            int index = 0;
            long i = 0;
            while(index < patterns.Length)
            {
                string number = Convert.ToString(i);
                if(StringConsistsOnlyOfSpecificNumbers(number))
                {
                    patterns[index] = number;
                    index++;

                    if(index % 1000 == 0)
                    {
                        Console.WriteLine(index);
                    }
                }
                i++;
            }

            return patterns;
        }

        static string[] CreatePatterns2BetterPerformence()
        {
            string[] patterns = new string[1000000];
            patterns[0] = "0";
            patterns[1] = "1";
            patterns[2] = "2";
            int index = 3;
            int pointer = 0;
            while (pointer < patterns.Length)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (index >= patterns.Length)
                    {
                        break;
                    }

                    patterns[index] = Convert.ToString(i) + patterns[pointer];
                    index++;
                }
                pointer++;
            }

            return patterns;
        }

        static bool StringConsistsOnlyOfSpecificNumbers(string numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(!(numbers[i] == '0' || numbers[i] == '1' || numbers[i] == '2'))
                {
                    return false;
                }
            }
            return true;
        }

        static string[] RemoveLeadingString(string[] strings)
        {
            string[] newStrings = new string[strings.Length - 1];
            for(int i = 0; i < newStrings.Length; i++)
            {
                newStrings[i] = strings[i + 1];
            }
            return newStrings;
        }
    }
}
