using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input_ruleset = File.ReadAllLines("ruleset.txt");
            string[] input = File.ReadAllLines("input.txt");

            int part1_solution = Part1(input_ruleset, input);
            Console.WriteLine("The solution of part 1 is: " + part1_solution);

            int part2_solution = Part2(input_ruleset, input);
            Console.WriteLine("The solution of part 2 is: " + part2_solution);
        }

        static int Part1(string[] input_ruleset, string[] input)
        {
            int sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                string[] edited_arr = CheckedLine(input[i], input_ruleset);
                string[] edited_arr2 = RemoveAllMinusOneStrings(edited_arr);
                
                if(edited_arr.Length == edited_arr2.Length)
                {
                    sum += Int32.Parse(edited_arr[edited_arr.Length/2]);
                }
            }
            return sum;
        }

        static int Part2(string[] input_ruleset, string[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] edited_arr = CheckedLine(input[i], input_ruleset);
                string[] edited_arr2 = RemoveAllMinusOneStrings(edited_arr);
                string[] edited_arr3 = CheckedLine2(input[i], input_ruleset);

                if (edited_arr.Length != edited_arr2.Length)
                {
                    sum += Int32.Parse(edited_arr3[edited_arr3.Length / 2]);
                }
            }
            return sum;
        }

        static string[] CheckedLine(string line, string[] input_ruleset)
        {
            string[] split = line.Split(',');
            for(int i = 0; i < split.Length; i++)
            {
                for(int u = 0; u < input_ruleset.Length; u++)
                {
                    bool state = CheckIfRuleSetApplies(i, split, input_ruleset[u]);
                    if(state == false)
                    {
                        split[i] = "-1";
                    }
                }
            }
            return split;
        }

        static string[] CheckedLine2(string line, string[] input_ruleset)
        {
            string[] split = line.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                for (int u = 0; u < input_ruleset.Length; u++)
                {
                    bool state = CheckIfRuleSetApplies(i, split, input_ruleset[u]);
                    if(state == false)
                    {
                        split = CheckIfRuleSetAppliesAndChangeOrder(i, split, input_ruleset[u]);
                        i = 0;
                        break;
                    }
                }
            }
            return split;
        }

        static bool CheckIfRuleSetApplies(int index, string[] list, string rule)
        {
            //Check if rule is applicable
            string[] split = rule.Split('|');
            if(list[index] != split[0])
            {
                return true;
            }

            while(index != -1)
            {
                if(list[index] == split[1])
                {
                    return false;
                }
                index--;
            }

            //If checks are okey return true
            return true;
        }

        static string[] CheckIfRuleSetAppliesAndChangeOrder(int index, string[] list, string rule)
        {
            int start_index = index;

            //Check if rule is applicable
            string[] split = rule.Split('|');
            if (list[index] != split[0])
            {
                return list;
            }

            while (index != -1)
            {
                if (list[index] == split[1])
                {
                    string saver = list[start_index];
                    list[start_index] = list[index];
                    list[index] = saver;
                    return list;
                }
                index--;
            }

            //If checks are okey return true
            return list;
        }

        static string[] RemoveAllMinusOneStrings(string[] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "-1")
                {
                    counter++;
                }
            }

            string[] newArr = new string[counter];

            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != "-1")
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            return newArr;
        }
    }
}