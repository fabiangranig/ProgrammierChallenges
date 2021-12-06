using System;
using System.IO;

namespace Advent_of_Code_Tag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Den Input einlesen
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "Advent_of_Code_Tag_2_Input.txt";
            string[] directions = System.IO.File.ReadAllLines(path);

            //Mithilfe der for-Schleife durch alle Werte gehen
            int x = 0;
            int aim = 0;
            int z = 0;
            for(int zaehler = 0; zaehler < directions.Length; zaehler++)
            {
                
                string[] split = directions[zaehler].Split(' ');

                if(split[0] == "forward")
                {
                    x += Int32.Parse(split[1]);
                    z += aim * Int32.Parse(split[1]);
                }

                if (split[0] == "up")
                {
                    aim -= Int32.Parse(split[1]);
                }
                
                if (split[0] == "down")
                {
                    aim += Int32.Parse(split[1]);
                }
            }

            int puzzle = x * z;

            Console.WriteLine("Wir sind bei der Höhe " + z + " und sind " + x + " Einheiten gefahren.");
            Console.WriteLine("Wenn man beide werde multipliziert erhält man: " + puzzle);


        }
    }
}
