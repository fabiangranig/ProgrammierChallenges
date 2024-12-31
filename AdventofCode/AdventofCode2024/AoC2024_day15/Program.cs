using System;
using System.Collections.Generic;
using System.IO;

namespace AoC2024_day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] smallerExample = File.ReadAllLines("smallerExample.txt");
            //int smallerExampleSolution = Part1(smallerExample);
            //Console.WriteLine("The solution of the smaller example: " + smallerExampleSolution);
            
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            string[] Example = File.ReadAllLines("Example.txt");
            //int ExampleSolution = Part1(Example);
            //Console.WriteLine("The solution of the example: " + ExampleSolution);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            string[] input = File.ReadAllLines("input.txt");
            //int part1_solution = Part1(input);
            //Console.WriteLine("The solution of the example: " + part1_solution);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            int part2_solution = Part2(input);
            Console.WriteLine("The solution of the part2: " + part2_solution);

            int ExamplePart2 = Part2(Example);
            Console.WriteLine("The solution of the example: " + ExamplePart2);
        }

        static int Part1(string[] input)
        {
            //Get the map
            char[,] map = CreateMap(input);
            string[] commands = CreateCommand(input);
            Robot robot = new Robot(map);

            for (int i = 0; i < commands.Length; i++)
            {
                for(int u = 0; u < commands[i].Length; u++)
                {
                    robot.Move(ref map, commands[i][u]);
                    //Console.WriteLine(commands[i][u]);
                    //DisplayMap(map);
                }
            }

            DisplayMap(map);

            int sum = 0;
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i,u] == 'O')
                    {
                        sum += 100 * i + u;
                    }
                }
            }

            return sum;
        }

        static int Part2(string[] input)
        {
            //Get the map
            char[,] map = CreateMap2(input);
            string[] commands = CreateCommand(input);
            List<BoxHalf> halfes = GetBoxHalfes(ref map);
            Robot robot = new Robot(ref map);

            for (int i = 0; i < commands.Length; i++)
            {
                for (int u = 0; u < commands[i].Length; u++)
                {
                    //Console.WriteLine(commands[i][u] + " Count: " + u);
                    //DisplayMap2(map, robot, halfes);
                    if (commands[i][u] == '^')
                    {
                        robot.Move2(map, ref robot, ref halfes, commands[i][u], 0, -1);
                    }
                    if (commands[i][u] == '>')
                    {
                        robot.Move2(map, ref robot, ref halfes, commands[i][u], 1, 0);
                    }
                    if (commands[i][u] == 'v')
                    {
                        robot.Move2(map, ref robot, ref halfes, commands[i][u], 0, 1);
                    }
                    if (commands[i][u] == '<')
                    {
                        robot.Move2(map, ref robot, ref halfes, commands[i][u], -1, 0);
                    }
                    //Console.ReadLine();
                }
            }

            for (int i = 0; i < halfes.Count; i++)
            {
                map[halfes[i].y, halfes[i].x] = halfes[i].type;
            }

            int sum = 0;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == '[')
                    {
                        sum += 100 * i + u;
                    }
                }
            }

            return sum;
        }

        static List<BoxHalf> GetBoxHalfes(ref char[,] map)
        {
            int counter = 1;
            List<BoxHalf> boxhalfes = new List<BoxHalf>();
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == 'O')
                    {
                        map[i, u] = '.';
                        map[i, u + 1] = '.';
                        BoxHalf Left = new BoxHalf(u, i, '[');
                        BoxHalf Right = new BoxHalf(u + 1, i, ']');
                        Left.OtherHalf = Right;
                        Right.OtherHalf = Left;
                        Right.id = counter;
                        counter++;
                        Left.id = counter;
                        counter++;
                        boxhalfes.Add(Right);
                        boxhalfes.Add(Left);
                    }
                }
            }
            return boxhalfes;
        }

        static char[,] CreateMap(string[] input)
        {
            int mapEnd = -1;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == " ")
                {
                    mapEnd = i;
                    break;
                }
            }

            //Build map
            char[,] map = new char[mapEnd, input[0].Length];
            for(int i = 0; i < mapEnd; i++)
            {
                for(int u = 0; u < map.GetLength(1); u++)
                {
                    map[i, u] = input[i][u];
                }
            }

            return map;
        }

        static char[,] CreateMap2(string[] input)
        {
            int mapEnd = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == " ")
                {
                    mapEnd = i;
                    break;
                }
            }

            int lengthX = input[0].Length;
            for (int i = 0; i < mapEnd; i++)
            {
                string result = "";
                for (int u = 0; u < lengthX; u++)
                {
                    if(input[i][u] == '#')
                    {
                        result += input[i][u] + "" + input[i][u];
                    }
                    if (input[i][u] == '.')
                    {
                        result += input[i][u] + "" + input[i][u];
                    }
                    if (input[i][u] == 'O')
                    {
                        result += "O" + ".";
                    }
                    if (input[i][u] == '@')
                    {
                        result += "@" + "" + ".";
                    }
                }
                input[i] = result;
                result = "";
            }

            //Build map
            char[,] map = new char[mapEnd, input[0].Length];
            for (int i = 0; i < mapEnd; i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    map[i, u] = input[i][u];
                }
            }

            return map;
        }

        static string[] CreateCommand(string[] input)
        {
            int mapEnd = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == " ")
                {
                    mapEnd = i;
                    break;
                }
            }

            string[] command = new string[input.Length - mapEnd - 1];
            int counter = 0;
            for(int i = mapEnd + 1; i < input.Length; i++)
            {
                command[counter] = input[i];
                counter++;
            }

            return command;
        }

        static void DisplayMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    Console.Write(map[i, u]);
                }
                Console.WriteLine();
            }
        }

        static void DisplayMap2(char[,] map, Robot robot, List<BoxHalf> halfes)
        {
            map[robot.PosY, robot.PosX] = '@';

            for(int i = 0; i < halfes.Count; i++)
            {
                map[halfes[i].y, halfes[i].x] = halfes[i].type;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    Console.Write(map[i, u]);
                }
                Console.WriteLine();
            }

            map[robot.PosY, robot.PosX] = '.';

            for (int i = 0; i < halfes.Count; i++)
            {
                map[halfes[i].y, halfes[i].x] = '.';
            }
        }
    }

    class Robot
    {
        public int PosX;
        public int PosY;

        public Robot(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == '@')
                    {
                        this.PosY = i;
                        this.PosX = u;
                        break;
                    }
                }
            }
        }

        public Robot(ref char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    if (map[i, u] == '@')
                    {
                        this.PosY = i;
                        this.PosX = u;
                        map[i, u] = '.';
                        break;
                    }
                }
            }
        }

        public void Move(ref char[,] map, char direction)
        {
            if(direction == '>')
            {
                if (map[this.PosY, this.PosX + 1] == '.')
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosX += 1;
                    map[this.PosY, this.PosX] = '@';
                }
                else if (CanTheBoxBeMoved(map, direction))
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosX += 1;
                    map[this.PosY, this.PosX] = '@';
                    MoveBoxes(ref map, direction);
                }
            }

            if (direction == 'v')
            {
                if (map[this.PosY + 1, this.PosX] == '.')
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosY += 1;
                    map[this.PosY, this.PosX] = '@';
                }
                else if (CanTheBoxBeMoved(map, direction))
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosY += 1;
                    map[this.PosY, this.PosX] = '@';
                    MoveBoxes(ref map, direction);
                }
            }

            if (direction == '<')
            {
                if (map[this.PosY, this.PosX - 1] == '.')
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosX -= 1;
                    map[this.PosY, this.PosX] = '@';
                }
                else if (CanTheBoxBeMoved(map, direction))
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosX -= 1;
                    map[this.PosY, this.PosX] = '@';
                    MoveBoxes(ref map, direction);
                }
            }

            if (direction == '^')
            {
                if (map[this.PosY - 1, this.PosX] == '.')
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosY -= 1;
                    map[this.PosY, this.PosX] = '@';
                }
                else if (CanTheBoxBeMoved(map, direction))
                {
                    map[this.PosY, this.PosX] = '.';
                    this.PosY -= 1;
                    map[this.PosY, this.PosX] = '@';
                    MoveBoxes(ref map, direction);
                }
            }
        }

        public bool CanTheBoxBeMoved(char[,] map, char direction)
        {
            if(direction == '>')
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (map[this.PosY, this.PosX + i] == '.')
                    {
                        return true;
                    }

                    if (map[this.PosY, this.PosX + i] == '#')
                    {
                        return false;
                    }
                }
            }

            if (direction == 'v')
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    if (map[this.PosY + i, this.PosX] == '.')
                    {
                        return true;
                    }

                    if (map[this.PosY + i, this.PosX] == '#')
                    {
                        return false;
                    }
                }
            }

            if (direction == '<')
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (this.PosX - i > -1 && map[this.PosY, this.PosX - i] == '.')
                    {
                        return true;
                    }

                    if (this.PosX - i > -1 && map[this.PosY, this.PosX - i] == '#')
                    {
                        return false;
                    }
                }
            }

            if (direction == '^')
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    if (this.PosY - i > -1 && map[this.PosY - i, this.PosX] == '.')
                    {
                        return true;
                    }

                    if (this.PosY - i > -1 && map[this.PosY - i, this.PosX] == '#')
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public void MoveBoxes(ref char[,] map, char direction)
        {
            if(direction == '>')
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (this.PosX + i < map.GetLength(1) && map[this.PosY, this.PosX + i] == '.')
                    {
                        map[this.PosY, this.PosX + i] = 'O';
                        break;
                    }
                }
            }

            if (direction == 'v')
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    if (this.PosY + i < map.GetLength(0) && map[this.PosY + i, this.PosX] == '.')
                    {
                        map[this.PosY + i, this.PosX] = 'O';
                        break;
                    }
                }
            }

            if (direction == '<')
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    if (this.PosX - i > -1 && map[this.PosY, this.PosX - i] == '.')
                    {
                        map[this.PosY, this.PosX - i] = 'O';
                        break;
                    }
                }
            }

            if (direction == '^')
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    if (this.PosY - i > -1 && map[this.PosY - i, this.PosX] == '.')
                    {
                        map[this.PosY - i, this.PosX] = 'O';
                        break;
                    }
                }
            }
        }

        public void Move2(char[,] map, ref Robot robot, ref List<BoxHalf> halfes, char command, int x_move, int y_move)
        {
            BoxHalf searched = GetBoxHalfAtPosition(halfes, robot.PosX + x_move, robot.PosY + y_move);
            if (searched == null && map[robot.PosY + y_move, robot.PosX + x_move] != '#')
            {
                robot.PosX += x_move;
                robot.PosY += y_move;
                return;
            }
            else if (searched != null && CheckAndMoveBoxesUp(map, ref halfes, robot.PosX + x_move, robot.PosY + y_move, x_move, y_move))
            {
                robot.PosX += x_move;
                robot.PosY += y_move;
                return;
            }
        }

        public BoxHalf GetBoxHalfAtPosition(List<BoxHalf> halfes, int x, int y)
        {
            for(int i = 0; i < halfes.Count; i++)
            {
                if (halfes[i].x == x && halfes[i].y == y)
                {
                    return halfes[i];
                }
            }
            return null;
        }

        public bool CheckAndMoveBoxesUp(char[,] map, ref List<BoxHalf> halfes, int x, int y, int x_move, int y_move)
        {
            List<int> ids = new List<int>();
            BoxHalf half = GetBoxHalfAtPosition(halfes, x, y);

            ids.Add(half.id);
            ids.Add(half.OtherHalf.id);

            bool status = CheckAndMoveBoxesUpBackend(map, ref halfes, half.x + x_move, half.y + y_move, ref ids, x_move, y_move) && CheckAndMoveBoxesUpBackend(map, ref halfes, half.OtherHalf.x + x_move, half.OtherHalf.y + y_move, ref ids, x_move, y_move);
            
            if(status == true)
            {
                for(int i = 0; i < halfes.Count; i++)
                {
                    for(int u = 0; u < ids.Count; u++)
                    {
                        if (halfes[i].id == ids[u])
                        {
                            halfes[i].x += x_move;
                            halfes[i].y += y_move;
                        }
                    }
                }
            }

            return status;
        }

        public bool CheckAndMoveBoxesUpBackend(char[,] map, ref List<BoxHalf> halfes, int x, int y, ref List<int> ids, int x_move, int y_move)
        {
            BoxHalf half = GetBoxHalfAtPosition(halfes, x, y);
            
            if(half == null)
            {
                if (map[y, x] == '#')
                {
                    return false;
                }

                if (map[y, x] == '.')
                {
                    return true;
                }
            }

            if(ids.Contains(half.id) && ids.Contains(half.OtherHalf.id))
            {
                if (map[half.y + y_move, half.x + (x_move * 2)] == '.' || map[half.OtherHalf.y + y_move, half.OtherHalf.x + (x_move * 2)] == '.')
                {
                    return true;
                }

                return CheckAndMoveBoxesUpBackend(map, ref halfes, half.x + (x_move * 2), half.y + y_move, ref ids, x_move, y_move) && CheckAndMoveBoxesUpBackend(map, ref halfes, half.OtherHalf.x + (x_move * 2), half.OtherHalf.y + y_move, ref ids, x_move, y_move);
            }

            ids.Add(half.id);
            ids.Add(half.OtherHalf.id);

            return CheckAndMoveBoxesUpBackend(map, ref halfes, half.x + x_move, half.y + y_move, ref ids, x_move, y_move) && CheckAndMoveBoxesUpBackend(map, ref halfes, half.OtherHalf.x + x_move, half.OtherHalf.y + y_move, ref ids, x_move, y_move);
        }
    }

    public class BoxHalf
    {
        public int id;
        public int x;
        public int y;
        public char type;
        public BoxHalf OtherHalf;

        public BoxHalf(int x, int y, char type)
        {
            this.y = y;
            this.x = x;
            this.type = type;
        }
    }
}
