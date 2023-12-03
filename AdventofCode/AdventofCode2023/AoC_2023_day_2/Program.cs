using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_2
{
    internal class Program
    {
        //Part 1
        //right solution - 2156

        //Part 2
        //right solution - 66909

        static void Main(string[] args)
        {
            //Get puzzle input
            string[] input = System.IO.File.ReadAllLines("input.txt");

            //Parse the input
            List<Game> games = InputParser.GetGames(input);

            //Compute the solution for part 1
            int part1_solution = Part1_Solution(games);
            Console.WriteLine(part1_solution);

            //Compute the solution for part 2
            int part2_solution = Part2_Solution(games);
            Console.WriteLine(part2_solution);

            //Wait for user to close the program
            Console.ReadLine();
        }

        //Part 1
        //Part 1
        //Part 1
        static int Part1_Solution(List<Game> games)
        {
            int sum_ids = 0;
            foreach (Game game in games)
            {
                if(CheckIfListOfSetsIsOkey(game.sets))
                {
                    sum_ids += game.GameNumber;
                }
            }
            return sum_ids;
        }

        static bool CheckIfListOfSetsIsOkey(List<Set> set)
        {
            bool okey = true;
            for(int i = 0; i < set.Count; i++)
            {
                if (!(set[i].Red_Cubes <= 12 && set[i].Green_Cubes <= 13 && set[i].Blue_Cubes <= 14))
                {
                    okey = false;
                }
            }
            return okey;
        }

        //Part 2
        //Part 2
        //Part 2
        static int Part2_Solution(List<Game> games)
        {
            int solution = 0;
            foreach (Game game in games)
            {
                Set lowestSet = GetLowestInventoryforGame(game);
                int multiplikation = lowestSet.Green_Cubes * lowestSet.Blue_Cubes * lowestSet.Red_Cubes;
                solution += multiplikation;
            }
            return solution;
        }

        static Set GetLowestInventoryforGame(Game game)
        {
            Set lowest_set = new Set();
            for(int i = 0; i < game.sets.Count; i++)
            {
                Set current_Set = game.sets[i];
                if(current_Set.Green_Cubes > lowest_set.Green_Cubes)
                {
                    lowest_set.Green_Cubes = current_Set.Green_Cubes;
                }
                if (current_Set.Red_Cubes > lowest_set.Red_Cubes)
                {
                    lowest_set.Red_Cubes = current_Set.Red_Cubes;
                }
                if (current_Set.Blue_Cubes > lowest_set.Blue_Cubes)
                {
                    lowest_set.Blue_Cubes = current_Set.Blue_Cubes;
                }
            }
            return lowest_set;
        }
    }
}
