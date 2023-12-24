using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_3
{
    internal class Program
    {
        //Part 1
        //right solution - 521515

        //Part 2
        //right solution - 

        static void Main(string[] args)
        {
            //Get puzzle input
            string[] input = System.IO.File.ReadAllLines("input.txt");

            //Compute the solution for part 1
            int part1_solution = Part1_Solution(input);
            Console.WriteLine(part1_solution);

            //Compute the solution for part 2
            int part2_solution = Part2_Solution(input);
            Console.WriteLine(part2_solution);

            //Wait for user to close the program
            Console.ReadLine();
        }

        //Part 1
        //Part 1
        //Part 1
        static int Part1_Solution(string[] input)
        {
            List<Position> positions = new List<Position>();
            for(int y = 0; y < input.Length; y++)
            {
                for(int x = 0; x < input[0].Length; x++)
                {
                    //Get all positions where a number is
                    int number;
                    bool switcher = Int32.TryParse(Convert.ToString(input[y][x]), out number);
                    if(switcher == true)
                    {
                        //Check if a symbol is near that position
                        bool SymbolNearby = CheckForNearbySymbol(input, x, y);

                        //Add position to list
                        positions.Add(new Position(number, x, y, SymbolNearby));
                    }
                }
            }

            //Build numbers out of the positions and return them
            List<int> togheterNumbers = PutNumbersTogheter(positions);
            int sum = 0;
            for(int i = 0; i < togheterNumbers.Count; i++)
            {
                sum += togheterNumbers[i];
            }

            return sum;
        }

        static bool CheckForNearbySymbol(string[] map, int position_x, int position_y)
        {
            bool symbol_nearby = false;
            for (int y = -1; y < 2; y++)
            {
                for (int x = -1; x < 2; x++)
                {
                    if(position_y + y > 0 &&  position_y + y < map.Length && position_x + x > 0 && position_x + x < map[0].Length)
                    {
                        if((!IntTryParseWithoutNumber(Convert.ToString(map[position_y + y][position_x + x]))) && !(map[position_y + y][position_x + x] == '.'))
                        {
                            symbol_nearby = true;
                        }
                    }
                }
            }
            return symbol_nearby;
        }

        static bool IntTryParseWithoutNumber(string text)
        {
            int number;
            bool switcher = Int32.TryParse(text, out number);
            return switcher;
        }

        static List<int> PutNumbersTogheter(List<Position> positions)
        {
            List<int> numbers = new List<int>();
            string current_number = "";
            bool symbol_nearby = false;
            for(int i = 0; i < positions.Count; i++)
            {
                current_number += Convert.ToString(positions[i].Number);

                if(positions[i].HasSymbol)
                {
                    symbol_nearby = true;
                }
                
                if((i + 1 < positions.Count) && (positions[i + 1].X - positions[i].X != 1))
                {
                    if(symbol_nearby == true)
                    {
                        numbers.Add(Int32.Parse(current_number));
                    }

                    current_number = "";
                    symbol_nearby = false;
                }

                if(i + 1 == positions.Count)
                {
                    if (symbol_nearby == true)
                    {
                        numbers.Add(Int32.Parse(current_number));
                    }

                    current_number = "";
                }
            }

            return numbers;
        }

        //Part 2
        //Part 2
        //Part 2
        static int Part2_Solution(string[] input)
        {
            List<PositionWithStar> positions = new List<PositionWithStar>();
            for (int y = 0; y < input.Length; y++)
            {
                for (int x = 0; x < input[0].Length; x++)
                {
                    //Get all positions where a number is
                    int number;
                    bool switcher = Int32.TryParse(Convert.ToString(input[y][x]), out number);
                    if (switcher == true)
                    {
                        //Check if a symbol is near that position
                        PositionStar starposition = CheckForNearbySymbolStar(input, x, y);

                        //Add position to list
                        positions.Add(new PositionWithStar(number, x, y, starposition));
                    }
                }
            }

            //Build numbers out of the positions and return them
            List<int> togheterNumbers = PutNumbersTogheterWithStar(positions);
            
            return -1;
        }

        static PositionWithStar CheckForNearbySymbolStar(string[] map, int position_x, int position_y)
        {
            bool symbol_nearby = false;
            for (int y = -1; y < 2; y++)
            {
                for (int x = -1; x < 2; x++)
                {
                    if (position_y + y > 0 && position_y + y < map.Length && position_x + x > 0 && position_x + x < map[0].Length)
                    {
                        if ((!IntTryParseWithoutNumber(Convert.ToString(map[position_y + y][position_x + x]))) && !(map[position_y + y][position_x + x] == '.'))
                        {
                            symbol_nearby = true;
                        }
                    }
                }
            }
            return symbol_nearby;
        }

        static List<int> PutNumbersTogheterWithStar(List<Position> positions)
        {
            List<int> numbers = new List<int>();
            string current_number = "";
            bool symbol_nearby = false;
            for (int i = 0; i < positions.Count; i++)
            {
                current_number += Convert.ToString(positions[i].Number);

                if (positions[i].HasSymbol)
                {
                    symbol_nearby = true;
                }

                if ((i + 1 < positions.Count) && (positions[i + 1].X - positions[i].X != 1))
                {
                    if (symbol_nearby == true)
                    {
                        numbers.Add(Int32.Parse(current_number));
                    }

                    current_number = "";
                    symbol_nearby = false;
                }

                if (i + 1 == positions.Count)
                {
                    if (symbol_nearby == true)
                    {
                        numbers.Add(Int32.Parse(current_number));
                    }

                    current_number = "";
                }
            }

            return numbers;
        }
    }
}
