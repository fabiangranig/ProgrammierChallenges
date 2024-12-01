using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace AoC2024_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start info
            Console.WriteLine("Start calculation...");

            string[] input = File.ReadAllLines("input.txt");
            int[] list_left = GetLists(input, 0);
            int[] list_right = GetLists(input, 1);

            Array.Sort(list_left);
            Array.Sort(list_right);

            int part1_solution = CompareList(list_left, list_right);
            Console.WriteLine("The solution to part one is: " + part1_solution);

            int part2_solution = SimilarityScore(list_left, list_right);
            Console.WriteLine("The solution to part two is: " + part2_solution);

            //End info
            Console.WriteLine("End calculation!");
        }

        static int[] GetLists(string[] input, int index)
        {
            int[] array = new int[input.Length];
            for(int i = 0; i < array.Length; i++)
            {
                string[] split = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                array[i] = Int32.Parse(split[index]);
            }
            return array;
        }

        static int CompareList(int[] left, int[] right)
        {
            int sum = 0;
            for(int i = 0; i < left.Length; i++)
            {
                sum += Math.Abs(left[i] - right[i]);
            }
            return sum;
        }

        static int SimilarityScore(int[] left, int[] right)
        {
            int sum = 0;
            for(int i = 0; i < left.Length; i++)
            {
                sum += left[i] * CountAppereancesInList(left[i], right);
            }
            return sum;
        }

        static int CountAppereancesInList(int number, int[] list)
        {
            int counter = 0;
            for(int i = 0; i < list.Length; i++)
            {
                if(number == list[i])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
