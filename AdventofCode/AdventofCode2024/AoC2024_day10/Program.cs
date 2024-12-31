using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AoC2024_day10
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
            int[,] map = StringArrToIntegerArr(input);

            int sum = 0;
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int u = 0; u < map.GetLength(1); u++)
                {
                    if(map[i, u] == 0)
                    {
                        sum += CheckScore(map, i, u);
                        SolutionsString = "";
                    }
                }
            }
            return sum;
        }

        static int Part2(string[] input)
        {
            int[,] map = StringArrToIntegerArr(input);

            int sum = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == 0)
                    {
                        sum += CheckScore2(map, i, u);
                    }
                }
            }
            return sum;
        }

        static string SolutionsString = "";

        static int CheckScore(int[,] map, int current_y, int current_x)
        {
            //Check where are the next positions
            int number = map[current_y, current_x];
            int next_number = number + 1;

            if(map[current_y, current_x] == 9)
            {
                if(!(SolutionsString.Contains(Convert.ToString(current_y)+Convert.ToString(current_x)+" ")))
                {
                    SolutionsString += Convert.ToString(current_y) + Convert.ToString(current_x) + " ";
                    return 1;
                }
            }

            int right = 0;
            int down = 0;
            int left = 0;
            int up = 0;
            if (current_x + 1 < map.GetLength(1) && map[current_y, current_x + 1] == next_number)
            {
                right += CheckScore(map, current_y, current_x + 1);
            }
            if (current_y + 1 < map.GetLength(0) && map[current_y + 1, current_x] == next_number)
            {
                down += CheckScore(map, current_y + 1, current_x);
            }
            if (current_x - 1 > -1 && map[current_y, current_x - 1] == next_number)
            {
                left += CheckScore(map, current_y, current_x - 1);
            }
            if (current_y - 1 > -1 && map[current_y - 1, current_x] == next_number)
            {
                up += CheckScore(map, current_y - 1, current_x);
            }

            return right + down + left + up;
        }

        static int CheckScore2(int[,] map, int current_y, int current_x)
        {
            //Check where are the next positions
            int number = map[current_y, current_x];
            int next_number = number + 1;

            if (map[current_y, current_x] == 9)
            {
                return 1;
            }

            int right = 0;
            int down = 0;
            int left = 0;
            int up = 0;
            if (current_x + 1 < map.GetLength(1) && map[current_y, current_x + 1] == next_number)
            {
                right += CheckScore2(map, current_y, current_x + 1);
            }
            if (current_y + 1 < map.GetLength(0) && map[current_y + 1, current_x] == next_number)
            {
                down += CheckScore2(map, current_y + 1, current_x);
            }
            if (current_x - 1 > -1 && map[current_y, current_x - 1] == next_number)
            {
                left += CheckScore2(map, current_y, current_x - 1);
            }
            if (current_y - 1 > -1 && map[current_y - 1, current_x] == next_number)
            {
                up += CheckScore2(map, current_y - 1, current_x);
            }

            return right + down + left + up;
        }

        static int[,] StringArrToIntegerArr(string[] input)
        {
            int[,] integers = new int[input.Length, input[0].Length];
            for(int i = 0; i < integers.GetLength(0); i++)
            {
                for(int u = 0; u < integers.GetLength(1); u++)
                {
                    integers[i, u] = Int32.Parse(Convert.ToString(input[i][u]));
                }
            }
            return integers;
        }
    }
}
