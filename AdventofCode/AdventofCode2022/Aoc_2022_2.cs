using System;
using System.IO;

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            //A - Rock
            //B - Paper
            //C - Scissors
            
            //X - Rock
            //Y - Paper
            //Z - Scissors

            //Caculate the solution
            int sum = 0;
            int sum2 = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                string[] split = numbers[i].Split(' ');
                sum += Win_Lose(split[0][0], split[1][0]);
                sum2 += Win_Lose2(split[0][0], split[1][0]);
            }

            //Output the solution
            Console.WriteLine("The solution for the first part is: " + sum);
            Console.WriteLine("The solution for the second part is: " + sum2);
        }

        static int Win_Lose(char mine, char enemies)
        {
            //Lose
            if(mine == 'A' && enemies == 'Z')
            {
                return 3 + 0;
            }
            if(mine == 'B' && enemies == 'X')
            {
                return 1 + 0;
            }
            if(mine == 'C' && enemies == 'Y')
            {
                return 2 + 0;
            }

            //Draw
            if(mine == 'A' && enemies == 'X')
            {
                return 1 + 3;
            }
            if(mine == 'B' && enemies == 'Y')
            {
                return 2 + 3;
            }
            if(mine == 'C' && enemies == 'Z')
            {
                return 3 + 3;
            }

            //Win
            if(mine == 'A' && enemies == 'Y')
            {
                return 2 + 6;
            }
            if(mine == 'B' && enemies == 'Z')
            {
                return 3 + 6;
            }
            if(mine == 'C' && enemies == 'X')
            {
                return 1 + 6;
            }

            //When there is nothing found
            return -1;
        }

        static int Win_Lose2(char mine, char enemies)
        {
            //Lose
            if(mine == 'A' && enemies == 'Z')
            {
                return 2 + 6;
            }
            if(mine == 'B' && enemies == 'X')
            {
                return 1 + 0;
            }
            if(mine == 'C' && enemies == 'Y')
            {
                return 3 + 3;
            }

            //Draw
            if(mine == 'A' && enemies == 'X')
            {
                return 3 + 0;
            }
            if(mine == 'B' && enemies == 'Y')
            {
                return 2 + 3;
            }
            if(mine == 'C' && enemies == 'Z')
            {
                return 1 + 6;
            }

            //Win
            if(mine == 'A' && enemies == 'Y')
            {
                return 1 + 3;
            }
            if(mine == 'B' && enemies == 'Z')
            {
                return 3 + 6;
            }
            if(mine == 'C' && enemies == 'X')
            {
                return 2 + 0;
            }

            //When there is nothing found
            return -1;
        }
    }
}
