using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int part1_solution = Part1(input);
            Console.WriteLine("The solution of part one is: " + part1_solution);

            int part2_solution = Part2(input);
            Console.WriteLine("The solution of part one is: " + part2_solution);
        }

        static int Part1(string[] input)
        {
            int counter = 0;
            for(int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split(' ');
                int[] numbers = ConvertStringArrayToInt32Arr(split);

                if(CheckIfListIsValid(numbers))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int Part2(string[] input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] split = input[i].Split(' ');
                int[] numbers = ConvertStringArrayToInt32Arr(split);

                if (CheckIfListIsValid(numbers) || CheckIfListIsValidByRemovingOneNumber(numbers))
                {
                    counter++;
                }
            }
            return counter;
        }

        static int[] ConvertStringArrayToInt32Arr(string[] strings)
        {
            int[] ints = new int[strings.Length];
            for(int i = 0; i < strings.Length; i++)
            {
                ints[i] = Int32.Parse(strings[i]);
            }
            return ints;
        }

        static bool CheckIfListIsValid(int[] numbers)
        {
            bool PlusOrMinus = (numbers[0] - numbers[1]) > 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (!(((numbers[i] - numbers[i + 1]) > 0) == PlusOrMinus))
                {
                    return false;
                }
                if (!(Math.Abs(numbers[i] - numbers[i + 1]) > 0 && Math.Abs(numbers[i] - numbers[i + 1]) < 4))
                {
                    return false;
                }
            }
            return true;
        }

        static int[] RemoveIndexFromIntArray(int[] numbers, int index)
        {
            int[] NewNumbers = new int[numbers.Length - 1];
            bool switcher = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(i != index && switcher == false)
                {
                    NewNumbers[i] = numbers[i];
                }
                else if (i + 1 < numbers.Length)
                {
                    NewNumbers[i] = numbers[i + 1];
                    switcher = true;
                }
            }
            return NewNumbers;
        }

        static bool CheckIfListIsValidByRemovingOneNumber(int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                int[] NewList = RemoveIndexFromIntArray(list, i);
                if(CheckIfListIsValid(NewList))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
