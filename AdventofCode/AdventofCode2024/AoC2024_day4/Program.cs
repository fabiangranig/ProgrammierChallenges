using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            int part1_solution = Part1(input);
            Console.WriteLine("The solution to part one is: " + part1_solution);

            int part2_solution = Part2(input);
            Console.WriteLine("The solution to part two is: " + part2_solution);
        }

        static int Part1(string[] input)
        {
            char[,] chars = BuildCharArray(input);
            return GetAllWords(chars);
        }
        static int Part2(string[] input)
        {
            char[,] chars = BuildCharArray(input);
            return GetAllWords2(chars);
        }

        static int GetAllWords(char[,] chars)
        {
            int sum = 0;
            for(int i = 0; i < chars.GetLength(0); i++)
            {
                for(int u = 0; u < chars.GetLength(1); u++)
                {
                    if (chars[i, u] == 'X')
                    {
                        sum += CheckFromThatPositionIfWordsExist(chars, i, u);
                    }
                }
            }
            return sum;
        }
        static int GetAllWords2(char[,] chars)
        {
            int sum = 0;
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int u = 0; u < chars.GetLength(1); u++)
                {
                    if (chars[i, u] == 'A')
                    {
                        sum += CheckFromThatPositionIfWordsExist2(chars, i, u);
                    }
                }
            }
            return sum;
        }

        static int CheckFromThatPositionIfWordsExist(char[,] chars, int i, int u)
        {
            int counter = 0;

            //Horizontal
            if(u + 3 < chars.GetLength(1) && chars[i, u + 1] == 'M' && chars[i, u + 2] == 'A' && chars[i, u + 3] == 'S')
            {
                counter++;
            }

            //Horizontal backwards
            if(u - 3 > -1 && chars[i, u - 1] == 'M' && chars[i, u - 2] == 'A' && chars[i, u - 3] == 'S')
            {
                counter++;
            }

            //Vertical
            if(i + 3 < chars.GetLength(0) && chars[i + 1, u] == 'M' && chars[i + 2, u] == 'A' && chars[i + 3, u] == 'S')
            {
                counter++;
            }

            //Vertical backwards
            if (i - 3 > -1 && chars[i - 1, u] == 'M' && chars[i - 2, u] == 'A' && chars[i - 3, u] == 'S')
            {
                counter++;
            }

            //Vertical Right Downwards
            if (u + 3 < chars.GetLength(1) && i + 3 < chars.GetLength(0) && chars[i + 1, u + 1] == 'M' && chars[i + 2, u + 2] == 'A' && chars[i + 3, u + 3] == 'S')
            {
                counter++;
            }

            //Vertical Right Upwards
            if (u + 3 < chars.GetLength(1) && i - 3 > -1 && chars[i - 1, u + 1] == 'M' && chars[i - 2, u + 2] == 'A' && chars[i - 3, u + 3] == 'S')
            {
                counter++;
            }

            //Vertical Left Downwards
            if (u - 3 > -1 && i - 3 > -1 && chars[i - 1, u - 1] == 'M' && chars[i - 2, u - 2] == 'A' && chars[i - 3, u - 3] == 'S')
            {
                counter++;
            }

            //Vertical Left Upwards
            if (u - 3 > -1 && i + 3 < chars.GetLength(0) && chars[i + 1, u - 1] == 'M' && chars[i + 2, u - 2] == 'A' && chars[i + 3, u - 3] == 'S')
            {
                counter++;
            }

            return counter;
        }

        static int CheckFromThatPositionIfWordsExist2(char[,] chars, int i, int u)
        {
            int counter = 0;

            if(u - 1 > -1 && i + 1 < chars.GetLength(0) && u + 1 < chars.GetLength(1) && i - 1 > -1)
            {
                if ((chars[i - 1, u - 1] == 'M' && chars[i + 1, u + 1] == 'S') || (chars[i - 1, u - 1] == 'S' && chars[i + 1, u + 1] == 'M'))
                {
                    if((chars[i + 1, u - 1] == 'M' && chars[i - 1, u + 1] == 'S') || (chars[i + 1, u - 1] == 'S' && chars[i - 1, u + 1] == 'M'))
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        static char[,] BuildCharArray(string[] input)
        {
            char[,] chars = new char[input.Length, input[0].Length];
            for(int i = 0; i < chars.GetLength(0); i++)
            {
                for(int u = 0; u < chars.GetLength(1); u++)
                {
                    chars[i,u] = input[i][u];
                }
            }
            return chars;
        }
    }
}