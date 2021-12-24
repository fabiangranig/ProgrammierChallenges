using System;
using System.IO;

namespace _2015_1.Tag_AdventofCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Solutions - Test:
                Part1:
                    -7000 - wrong answer
                    280 - right answer
                
                Part2:
                    1797 - right answer
            */

            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "2015_challenge_1_input.txt";
            string[] klammern = System.IO.File.ReadAllLines(path);

            //Declare variables floor, lock1 and save_position
            int floor = 0;
            bool lock1 = false;
            long position_save = -999999999999;

            //With for determined on which floor he has to go
            for (int i = 0; i < klammern[0].Length; i++)
            {
                //Only two options so just compare it with "(" bacause the other one always has to be ")"
                if (klammern[0][i] == '(')
                {
                    floor++;
                }
                else
                {
                    floor--;
                }

                //When the floor first hits -1 save the position and then lock it with the bool so that you get only one answer
                if(floor == -1 && lock1 == false)
                {
                    position_save = i + 1;
                    lock1 = true;
                }
            }

            //Output
            Console.WriteLine("Santa has to go to floor: {0}", floor);

            //Output Part2
            Console.WriteLine("Santa first hits the basement at position: {0}", position_save);
        }
    }
}
