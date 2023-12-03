using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023_day_2
{
    internal class InputParser
    {
        public static List<Game> GetGames(string[] input)
        {
            List<Game> games = new List<Game>();
            for(int i = 0; i < input.Length; i++)
            {
                Game game = GetGameOfString(input[i]);
                games.Add(game);
            }
            return games;
        }

        public static Game GetGameOfString(string line)
        {
            //Get the game name
            Game game = new Game();

            string[] split = line.Split(new string[]{ ": "}, StringSplitOptions.None);
            string[] split_gamenumber = split[0].Split(' ');
            game.GameNumber = Int32.Parse(split_gamenumber[1]);
            string[] split2 = split[1].Split(new string[] { "; " }, StringSplitOptions.None);

            for(int i = 0; i < split2.Length; i++)
            {
                Set set = GetSetOfString(split2[i]);
                game.sets.Add(set);
            }

            return game;
        }

        public static Set GetSetOfString(string line)
        {
            string[] split = line.Split(new string[] { ", " }, StringSplitOptions.None);
            
            //Put the numbers to the set
            Set set = new Set();
            for(int i = 0; i < split.Length; i++)
            {
                string[] split2 = split[i].Split(' ');

                if (split2[1] == "blue")
                {
                    set.Blue_Cubes = Int32.Parse(split2[0]);
                }
                if (split2[1] == "red")
                {
                    set.Red_Cubes = Int32.Parse(split2[0]);
                }
                if (split2[1] == "green")
                {
                    set.Green_Cubes = Int32.Parse(split2[0]);
                }
            }

            return set;
        }
    }
}
