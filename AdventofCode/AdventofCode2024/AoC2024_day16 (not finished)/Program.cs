using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace AoC2024_day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] example = File.ReadAllLines("example.txt");
            int example_solution = Part1(example);
            Console.WriteLine("The solution to the example is: " + example_solution);

            string[] example2 = File.ReadAllLines("example2.txt");
            int example2_solution = Part1(example2);
            Console.WriteLine("The solution to the example2 is: " + example2_solution);

            string[] input = File.ReadAllLines("input.txt");
            int input_solution = Part1(input);
            Console.WriteLine("The solution to the input is: " + input_solution);
        }

        static int Part1(string[] input)
        {
            char[,] map = CreateMap(input);
            List<int> PathPoints = new List<int>();

            Direction dir = new Direction("right");
            for(int i = 0; i < 100; i++)
            {
                dir.ChangeChanges();
            }

            //Search player
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == 'S')
                    {
                        ComputeSolutions(ref PathPoints, map, u, i, "right", 0, 1, new List<string>());
                    }
                }
            }

            PathPoints.Sort();
            return PathPoints[0];
        }

        static void ShowMap(char[,] map, int x, int y)
        {
            map[y, x] = 'S';
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    Console.Write(map[i, u]);
                }
                Console.WriteLine();
            }
            map[y, x] = '.';
        }

        static char[,] CreateMap(string[] input)
        {
            char[,] map = new char[input.Length, input[0].Length];
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int u = 0; u < map.GetLength(1); u++)
                {
                    map[i, u] = input[i][u];
                }
            }
            return map;
        }

        static void ComputeSolutions(ref List<int> PathPoints, char[,] map, int start_x, int start_y, string direction_string, int currentPoints, int depth, List<string> allPos)
        {
            Direction direction = new Direction(direction_string);
            allPos.Add(" " + (start_x) + ":" + (start_y) + " ");

            if (map[start_y, start_x] == 'E')
            {
                PathPoints.Add(currentPoints);
                return;
            }

            direction.ChangeChanges();

            //ShowMap(map, start_x, start_y);
            //Console.ReadLine();

            bool part1 = CanBeMoved(map, start_x + direction.x_Change, start_y + direction.y_Change);
            bool part2 = ContainsString(allPos, " " + (start_x + direction.x_Change) + ":" + (start_y + direction.y_Change) + " ") == false;
            if (part1 && part2)
            {
                int count = allPos.Count;
                ComputeSolutions(ref PathPoints, map, start_x + direction.x_Change, start_y + direction.y_Change, direction.dir, currentPoints + 1, depth + 1, allPos);
                for(int i = 0; count < allPos.Count; i++)
                {
                    allPos.RemoveAt(i);
                }
            }

            direction.DirectionChangerClockWise();
            if (CanBeMoved(map, start_x + direction.x_Change, start_y + direction.y_Change) && ContainsString(allPos, " " + (start_x + direction.x_Change) + ":" + (start_y + direction.y_Change) + " ") == false)
            {
                int count = allPos.Count;
                ComputeSolutions(ref PathPoints, map, start_x + direction.x_Change, start_y + direction.y_Change, direction.dir, currentPoints + 1001, depth + 1, allPos);
                for (int i = 0; count < allPos.Count; i++)
                {
                    allPos.RemoveAt(i);
                }
            }

            direction.DirectionChangerCounterClockWise();
            direction.DirectionChangerCounterClockWise();
            if (CanBeMoved(map, start_x + direction.x_Change, start_y + direction.y_Change) && ContainsString(allPos, " " + (start_x + direction.x_Change) + ":" + (start_y + direction.y_Change) + " ") == false)
            {
                int count = allPos.Count;
                ComputeSolutions(ref PathPoints, map, start_x + direction.x_Change, start_y + direction.y_Change, direction.dir, currentPoints + 1001, depth + 1, allPos);
                for (int i = 0; count < allPos.Count; i++)
                {
                    allPos.RemoveAt(i);
                }
            }
            
        }

        static bool ContainsString(List<string> list, string s1)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == s1)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CanBeMoved(char[,] map, int x, int y)
        {
            if(map.GetLength(0) > y && -1 < y && map.GetLength(1) > x && -1 < x)
            {
                if (map[y, x] == '.' || map[y, x] == 'E')
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Direction
    {
        public string dir;
        public int x_Change;
        public int y_Change;

        public Direction(string direction)
        {
            this.dir = direction;
            ChangeChanges();
        }

        public void ChangeChanges()
        {
            if (dir == "right")
            {
                x_Change = 1;
                y_Change = 0;
            }
            else if (dir == "down")
            {
                x_Change = 0;
                y_Change = 1;
            }
            else if (dir == "left")
            {
                x_Change = -1;
                y_Change = 0;
            }
            else if (dir == "up")
            {
                x_Change = 0;
                y_Change = -1;
            }
        }

        public void DirectionChangerClockWise()
        {
            if (dir == "right")
            {
                dir = "down";
                ChangeChanges();
            }
            else if (dir == "down")
            {
                dir = "left";
                ChangeChanges();
            }
            else if (dir == "left")
            {
                dir = "up";
                ChangeChanges();
            }
            else if (dir == "up")
            {
                dir = "right";
                ChangeChanges();
            }
        }

        public void DirectionChangerCounterClockWise()
        {
            if (dir == "right")
            {
                dir = "up";
                ChangeChanges();
            }
            else if (dir == "up")
            {
                dir = "left";
                ChangeChanges();
            }
            else if (dir == "left")
            {
                dir = "down";
                ChangeChanges();
            }
            else if (dir == "down")
            {
                dir = "right";
                ChangeChanges();
            }
        }
    }
}
