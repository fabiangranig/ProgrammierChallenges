using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day6
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
            Point start_point = new Point();
            start_point.Y = CheckWhichLineContainsRoof(input);
            start_point.X = CheckOnWhichPositionTheRoofIs(input[start_point.Y]);

            char[,] chars = ConvertStringArrInCharMatrix(input);
            char[,] movedMap = MoveThroughField(start_point, chars);
            int counter = CountMap(movedMap);
            
            return counter;
        }

        static int Part2(string[] input)
        {
            Point start_point = new Point();
            start_point.Y = CheckWhichLineContainsRoof(input);
            start_point.X = CheckOnWhichPositionTheRoofIs(input[start_point.Y]);

            //Create a new obtruction
            int loops = 0;
            char[,] movedMap = ConvertStringArrInCharMatrix(input);
            for(int i = 0; i < movedMap.GetLength(0); i++)
            {
                for(int u = 0; u < movedMap.GetLength(1); u++)
                {
                    if(movedMap[i, u] != '^')
                    {
                        movedMap[i, u] = '#';
                    }

                    //Check for loop
                    movedMap = MoveThroughField2(start_point, movedMap);
                    if(movedMap == null)
                    {
                        loops++;
                    }
                    movedMap = ConvertStringArrInCharMatrix(input);
                }
            }

            return loops;
        }

        static char[,] MoveThroughField(Point start_point, char[,] map)
        {
            Direction direction = new Direction();
            
            while(1 == 1)
            {
                if (direction.PathDirection == "Up")
                {
                    if (start_point.Y - 1 < 0)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y - 1, start_point.X] != '#')
                    {
                        start_point.Y--;
                        map[start_point.Y + 1, start_point.X] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Right")
                {
                    if (start_point.X + 1 > map.GetLength(1) - 1)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y, start_point.X + 1] != '#')
                    {
                        start_point.X++;
                        map[start_point.Y, start_point.X - 1] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Down")
                {
                    if (start_point.Y + 1 > map.GetLength(0) - 1)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y + 1, start_point.X] != '#')
                    {
                        start_point.Y++;
                        map[start_point.Y - 1, start_point.X] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Left")
                {
                    if (start_point.X - 1 < 0)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y, start_point.X - 1] != '#')
                    {
                        start_point.X--;
                        map[start_point.Y, start_point.X + 1] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }
            }
        }

        static char[,] MoveThroughField2(Point start_point, char[,] map)
        {
            Direction direction = new Direction();

            int counter = 0;
            while (1 == 1)
            {
                if (direction.PathDirection == "Up")
                {
                    if (start_point.Y - 1 < 0)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y - 1, start_point.X] != '#')
                    {
                        start_point.Y--;
                        map[start_point.Y + 1, start_point.X] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Right")
                {
                    if (start_point.X + 1 > map.GetLength(1) - 1)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y, start_point.X + 1] != '#')
                    {
                        start_point.X++;
                        map[start_point.Y, start_point.X - 1] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Down")
                {
                    if (start_point.Y + 1 > map.GetLength(0) - 1)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y + 1, start_point.X] != '#')
                    {
                        start_point.Y++;
                        map[start_point.Y - 1, start_point.X] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                if (direction.PathDirection == "Left")
                {
                    if (start_point.X - 1 < 0)
                    {
                        map[start_point.Y, start_point.X] = 'X';
                        return map;
                    }

                    if (map[start_point.Y, start_point.X - 1] != '#')
                    {
                        start_point.X--;
                        map[start_point.Y, start_point.X + 1] = 'X';
                    }
                    else
                    {
                        direction.ChangeDirection();
                    }
                }

                counter++;
                if(counter == 10000)
                {
                    return null;
                }
            }
        }

        static int CheckWhichLineContainsRoof(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains("^"))
                {
                    return i;
                }
            }
            return -1;
        }

        static int CheckOnWhichPositionTheRoofIs(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '^')
                {
                    return i;
                }
            }
            return -1;
        }

        static char[,] ConvertStringArrInCharMatrix(string[] strings)
        {
            char[,] result = new char[strings.Length, strings[0].Length];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int u = 0; u < result.GetLength(1); u++)
                {
                    result[i, u] = strings[i][u];
                }
            }
            return result;
        }

        static int CountMap(char[,] map)
        {
            int counter = 0;
            for (int o = 0; o < map.GetLength(0); o++)
            {
                for (int z = 0; z < map.GetLength(1); z++)
                {
                    if (map[o,z] == 'X')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }

    struct Point
    {
        public int X;
        public int Y;
    }

    public class Direction
    {
        private string _direction;

        public string PathDirection
        {
            get { return _direction; }
        }

        public Direction()
        {
            this._direction = "Up";
        }

        public void ChangeDirection()
        {
            if(this._direction == "Up")
            {
                this._direction = "Right";
            }
            else if(this._direction == "Right")
            {
                this._direction = "Down";
            }
            else if(this._direction == "Down")
            {
                this._direction = "Left";
            }
            else if(this._direction == "Left")
            {
                this._direction = "Up";
            }        
        }
    }
}