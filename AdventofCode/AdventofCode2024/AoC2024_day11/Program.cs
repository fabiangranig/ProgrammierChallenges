using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AoC2024_day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            int part1_solution = Part1(input);
            Console.WriteLine("The solution to part one is: " + part1_solution);

            long part2_solution = Part2(input);
            Console.WriteLine("The solution to part two is: " + part2_solution);
        }

        static int Part1(string[] input)
        {
            Numbero number = StringToObject(input[0]);
            Numbero start = number;
            while(number != null)
            {
                for(int i = number.evolution; i < 25; i++)
                {
                    number.evolution++;
                    if(number.number == 0)
                    {
                        number.number = 1;
                    }
                    else if(Convert.ToString(number.number).Length % 2 == 0)
                    {
                        long part1 = SplitNumber(number.number, 0);
                        long part2 = SplitNumber(number.number, 1);

                        number.number = part1;
                        Numbero middle = new Numbero();
                        middle.number = part2;
                        middle.Next = number.Next;
                        middle.evolution = number.evolution;
                        number.Next = middle;
                    }
                    else
                    {
                        number.number *= 2024;
                    }
                }
                number = number.Next;
            }

            //count numbers
            int counter = 0;
            while(start != null)
            {
                counter++;
                start = start.Next;
            }

            return counter;
        }

        static long Part2(string[] input)
        {
            Numbero number = StringToObject(input[0]);
            Numbero start = number;

            for (int i = 0; i < 75; i++)
            {
                //Numbero temp = start;
                //while(temp != null)
                //{
                //    Console.Write(temp.number + " ");
                //    temp = temp.Next;
                //}
                //Console.WriteLine();

                start = CombineNodes(start);

                //Numbero temp2 = start;
                //while (temp2 != null)
                //{
                //    Console.Write(temp2.number + " ");
                //    temp2 = temp2.Next;
                //}
                //Console.WriteLine();

                number = start;
                while(number != null)
                {
                    if(number.evolution == i)
                    {
                        number.evolution++;
                        if (number.number == 0)
                        {
                            number.number = 1;
                        }
                        else if (Convert.ToString(number.number).Length % 2 == 0)
                        {
                            long part1 = SplitNumber(number.number, 0);
                            long part2 = SplitNumber(number.number, 1);

                            number.number = part1;
                            Numbero middle = new Numbero();
                            middle.number = part2;
                            middle.Next = number.Next;
                            middle.evolution = number.evolution;
                            middle.count = number.count;
                            number.Next = middle;
                        }
                        else
                        {
                            number.number *= 2024;
                        }
                    }
                    number = number.Next;
                }
            }

            //count numbers
            long counter = 0;
            long counter_number = 0;
            while (start != null)
            {
                if(start.evolution != 75)
                {
                    Console.WriteLine("Error! - Evolution" + start.evolution);
                }

                counter += start.count;
                counter_number++;
                start = start.Next;

                if(counter_number % 1000 == 0)
                {
                    Console.WriteLine("Counter: " + counter_number + " " + counter);
                }
            }

            return counter;
        }

        static long SplitNumber(long number, int part)
        {
            string numberString = Convert.ToString(number);
            string part1 = "";
            string part2 = "";
            for(int i = 0; i < numberString.Length; i++)
            {
                if(i < numberString.Length / 2)
                {
                    part1 += Convert.ToString(numberString[i]);
                }
                else
                {
                    part2 += Convert.ToString(numberString[i]);
                }
            }

            if(part == 0)
            {
                return Int64.Parse(part1);
            }
            else
            {
                return Int64.Parse(part2);
            }
        }

        static Numbero StringToObject(string input)
        {
            string[] split = input.Split(' ');
            Numbero main = new Numbero();
            Numbero second = main;
            for(int i = 0; i < split.Length; i++)
            {
                main.number = Int64.Parse(split[i]);
                main.evolution = 0;
                main.count = 1;
                
                if(!(i == split.Length - 1))
                {
                    main.Next = new Numbero();
                    main = main.Next;
                }
            }
            return second;
        }

        static Numbero CombineNodes(Numbero beginning)
        {
            Numbero start = beginning;
            while(start != null)
            {
                long count = CountNumbero(start, start.number);
                start.count = count;
                start = RemoveNumbero(start, start.number);
                start = start.Next;
            }
            return beginning;
        }

        static long CountNumbero(Numbero beginning, long number)
        {
            long counter = 0;
            int beginning_evolution = beginning.evolution;
            while(beginning != null)
            {
                if(beginning_evolution != beginning.evolution)
                {
                    Console.WriteLine("Evolution Error!");
                }

                if(beginning.number == number)
                {
                    counter += beginning.count;
                }
                beginning = beginning.Next;
            }
            return counter;
        }

        static Numbero RemoveNumbero(Numbero beginning, long number)
        {
            Numbero start = beginning;
            while(beginning != null)
            {
                while(beginning.Next != null && beginning.Next.number == number)
                {
                    beginning.Next = beginning.Next.Next;
                }
                beginning = beginning.Next;
            }
            return start;
        }
    }

    class Numbero
    {
        public long number;
        public int evolution;
        public long count;
        public Numbero Next;
    }
}
