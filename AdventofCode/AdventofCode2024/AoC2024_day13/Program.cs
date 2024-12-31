using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace AoC2024_day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] example = File.ReadAllLines("example.txt");
            long example_solution = Part1(example);
            Console.WriteLine("Example: " + example_solution + " | 480");

            string[] input = File.ReadAllLines("input.txt");
            long part1_solution = Part1(input);
            Console.WriteLine("Part1: " + part1_solution);

            string[] example2 = File.ReadAllLines("example.txt");
            long example_solution2 = Part2(example2);
            Console.WriteLine("Example: " + example_solution2 + " | 480");

            long part2_solution = Part2(input);
            Console.WriteLine("Part2: " + part2_solution);
        }

        static long Part1(string[] input)
        {
            long sum = 0;
            for(int i = 0; i < input.Length; i=i+4)
            {
                Button Button1 = BuildButton(input[i], '1');
                Button Button2 = BuildButton(input[i+1], '2');
                Prize prize = BuildPrize(input[i + 2]);
                long moves = GetRequiredMoves(Button1, Button2, prize);
                if(moves != -1)
                {
                    sum += moves;
                }

            }
            return sum;
        }

        static long Part2(string[] input)
        {
            long sum = 0;
            for (int i = 0; i < input.Length; i = i + 4)
            {
                Button Button1 = BuildButton(input[i], '1');
                Button Button2 = BuildButton(input[i + 1], '2');
                Prize prize = BuildPrize2(input[i + 2]);
                long moves = GetRequiredMoves2(Button1, Button2, prize);
                if (moves != -1)
                {
                    sum += moves;
                }

            }
            return sum;
        }

        static long GetRequiredMoves(Button b1, Button b2, Prize p)
        {
            for(long i = 0; i < 101; i++)
            {
                for(long u = 0; u < 101; u++)
                {
                    long calculateX = i * b1.IncrementX + u * b2.IncrementX;
                    long calculateY = i * b1.IncrementY + u * b2.IncrementY;
                    if (calculateX == p.X && calculateY == p.Y)
                    {
                        return i * 3 + u * 1;
                    }
                }
            }
            return -1;
        }

        static long GetRequiredMoves2(Button b1, Button b2, Prize p)
        {
            long part1 = b1.IncrementX * p.Y - b1.IncrementY * p.X;
            long part2 = b1.IncrementX * b2.IncrementY - b1.IncrementY * b2.IncrementX;
            long u = part1 / part2;
            long margin = part1 % part2;

            long part3 = p.X - u * b2.IncrementX;
            long part4 = b1.IncrementX;
            long i = part3 / part4;
            long margin2 = part3 % part4;
            
            if(margin == 0 && margin2 == 0)
            {
                return i * 3 + u * 1;
            }
            
            return 0;
        }

        static Button BuildButton(string ButtonString, char Character)
        {
            Button button = new Button();
            string[] split = ButtonString.Split(' ');
            string[] splitXWithComa = split[2].Split('+');
            string[] splitX = splitXWithComa[1].Split(',');
            string[] splitY = split[3].Split('+');

            button.Character = Character;
            button.IncrementX = Int32.Parse(splitX[0]);
            button.IncrementY = Int32.Parse(splitY[1]);

            return button;
        }

        static Prize BuildPrize(string PrizeString)
        {
            Prize prize = new Prize();
            string[] split = PrizeString.Split('=');
            string[] split2 = split[1].Split(',');
            prize.X = Int64.Parse(split2[0]);
            prize.Y = Int64.Parse(split[2]);
            return prize;
        }

        static Prize BuildPrize2(string PrizeString)
        {
            Prize prize = new Prize();
            string[] split = PrizeString.Split('=');
            string[] split2 = split[1].Split(',');
            prize.X = Int64.Parse(split2[0]) + 10000000000000;
            prize.Y = Int64.Parse(split[2]) + 10000000000000;
            return prize;
        }
    }

    public class Button
    {
        public char Character;
        public long IncrementX;
        public long IncrementY;
    }

    public class Prize
    {
        public long X;
        public long Y;
    }
}
