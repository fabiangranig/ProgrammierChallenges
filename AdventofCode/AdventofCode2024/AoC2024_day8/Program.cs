using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day8
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
            char[,] antenna_map = CreateCharMap(input);
            char[,] empty_map = CreateEmptyMap(antenna_map.GetLength(0), antenna_map.GetLength(1));

            for(int i = 0; i < antenna_map.GetLength(0); i++)
            {
                for(int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    empty_map = SearchForPossibleAntinodes(antenna_map, empty_map, i, u);
                }
            }

            //Count X on map
            int counter = 0;
            for (int i = 0; i < antenna_map.GetLength(0); i++)
            {
                for (int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    if(empty_map[i, u] == 'X')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static int Part2(string[] input)
        {
            char[,] antenna_map = CreateCharMap(input);
            char[,] empty_map = CreateEmptyMap(antenna_map.GetLength(0), antenna_map.GetLength(1));

            for (int i = 0; i < antenna_map.GetLength(0); i++)
            {
                for (int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    empty_map = SearchForPossibleAntinodes2(antenna_map, empty_map, i, u);
                }
            }

            //Count X on map
            int counter = 0;
            for (int i = 0; i < antenna_map.GetLength(0); i++)
            {
                for (int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    if (empty_map[i, u] == 'X')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        static void OutputMap(char[,] map)
        {
            //Output empty map
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int u = 0; u < map.GetLength(1); u++)
                {
                    Console.Write(map[i, u]);
                }
                Console.WriteLine();
            }
        }

        static char[,] SearchForPossibleAntinodes(char[,] antenna_map, char[,] empty_map, int start_y, int start_x)
        {
            //Get searched for char
            char searched = antenna_map[start_y, start_x];

            //Skip if not antenna
            if(searched == '.')
            {
                return empty_map;
            }

            //Search for the same value from that starting point
            for(int i = start_y; i < antenna_map.GetLength(0); i++)
            {
                for(int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    if(i == start_y && u == 0 && start_x + 1 < antenna_map.GetLength(1))
                    {
                        u = start_x + 1;
                    }

                    if(searched == antenna_map[i, u])
                    {
                        int difference_y = start_y - i;
                        int difference_x = start_x - u;

                        int turned_value_y = difference_y * -1;
                        int turned_value_x = difference_x * -1;

                        int AntinodesFromStart_y = start_y + difference_y;
                        int AntinodesFromStart_x = start_x + difference_x;
                        int AntinodesFromSecond_y = i + turned_value_y;
                        int AntinodesFromSecond_x = u + turned_value_x;

                        if(!(AntinodesFromStart_y < 0 || AntinodesFromStart_y >= empty_map.GetLength(0) || difference_y == 0))
                        {
                            if(!(AntinodesFromStart_x < 0 || AntinodesFromStart_x >= empty_map.GetLength(1) || difference_x == 0))
                            {
                                empty_map[AntinodesFromStart_y, AntinodesFromStart_x] = 'X';
                            }
                        }

                        if (!(AntinodesFromSecond_y < 0 || AntinodesFromSecond_y >= empty_map.GetLength(0) || difference_y == 0))
                        {
                            if (!(AntinodesFromSecond_x < 0 || AntinodesFromSecond_x >= empty_map.GetLength(1) || difference_x == 0))
                            {
                                empty_map[AntinodesFromSecond_y, AntinodesFromSecond_x] = 'X';
                            }
                        }
                    }
                }
            }

            //Return the edited map
            return empty_map;
        }

        static char[,] SearchForPossibleAntinodes2(char[,] antenna_map, char[,] empty_map, int start_y, int start_x)
        {
            //Get searched for char
            char searched = antenna_map[start_y, start_x];

            //Skip if not antenna
            if (searched == '.')
            {
                return empty_map;
            }

            //Search for the same value from that starting point
            for (int i = start_y; i < antenna_map.GetLength(0); i++)
            {
                for (int u = 0; u < antenna_map.GetLength(1); u++)
                {
                    if (i == start_y && u == 0 && start_x + 1 < antenna_map.GetLength(1))
                    {
                        u = start_x + 1;
                    }

                    if (searched == antenna_map[i, u])
                    {
                        empty_map[i, u] = 'X';
                        empty_map[start_y, start_x] = 'X';

                        int difference_y = start_y - i;
                        int difference_x = start_x - u;

                        int turned_value_y = difference_y * -1;
                        int turned_value_x = difference_x * -1;

                        int AntinodesFromStart_y = start_y + difference_y;
                        int AntinodesFromStart_x = start_x + difference_x;
                        int AntinodesFromSecond_y = i + turned_value_y;
                        int AntinodesFromSecond_x = u + turned_value_x;
                        while (1 == 1)
                        {
                            if (!(AntinodesFromStart_y < 0 || AntinodesFromStart_y >= empty_map.GetLength(0) || difference_y == 0))
                            {
                                if (!(AntinodesFromStart_x < 0 || AntinodesFromStart_x >= empty_map.GetLength(1) || difference_x == 0))
                                {
                                    empty_map[AntinodesFromStart_y, AntinodesFromStart_x] = 'X';
                                }
                            }

                            if(AntinodesFromStart_y >= empty_map.GetLength(0) || AntinodesFromStart_y < 0 || difference_y == 0)
                            {
                                break;
                            }
                            if (AntinodesFromStart_x >= empty_map.GetLength(1) || AntinodesFromStart_x < 0 || difference_x == 0)
                            {
                                break;
                            }

                            AntinodesFromStart_y += difference_y;
                            AntinodesFromStart_x += difference_x;
                        }

                        while(1 == 1)
                        {
                            if (!(AntinodesFromSecond_y < 0 || AntinodesFromSecond_y >= empty_map.GetLength(0) || difference_y == 0))
                            {
                                if (!(AntinodesFromSecond_x < 0 || AntinodesFromSecond_x >= empty_map.GetLength(1) || difference_x == 0))
                                {
                                    empty_map[AntinodesFromSecond_y, AntinodesFromSecond_x] = 'X';
                                }
                            }

                            if(AntinodesFromSecond_y < 0 || AntinodesFromSecond_y >= empty_map.GetLength(0) || difference_y == 0)
                            {
                                break;
                            }
                            if(AntinodesFromSecond_x < 0 || AntinodesFromSecond_x >= empty_map.GetLength(1) || difference_x == 0)
                            {
                                break;
                            }

                            AntinodesFromSecond_y += turned_value_y;
                            AntinodesFromSecond_x += turned_value_x;
                        }
                    }
                }
            }

            //Return the edited map
            return empty_map;
        }

        static char[,] CreateCharMap(string[] input)
        {
            char[,] chars = new char[input.Length, input[0].Length];
            for(int i = 0; i < chars.GetLength(0); i++)
            {
                for(int u = 0; u < chars.GetLength(1); u++)
                {
                    chars[i, u] = input[i][u];
                }
            }
            return chars;
        }

        static char[,] CreateEmptyMap(int length_1, int length_2)
        {
            char[,] chars = new char[length_1, length_2];
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int u = 0; u < chars.GetLength(1); u++)
                {
                    chars[i, u] = '0';
                }
            }
            return chars;
        }
    }
}
