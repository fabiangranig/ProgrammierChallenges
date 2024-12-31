using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024_day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            long part1_solution = Part1(input[0]);
            Console.WriteLine("The solution to part one is: " + part1_solution);

            long part2_solution = Part2(input[0]);
            Console.WriteLine("The solution to part two is: " + part2_solution);
        }

        static long Part1(string input)
        {
            string renewed = OutputComputedString(input);
            string[] exported = ReorderString(renewed);

            long sum = 0;
            for(int i = 0; i < exported.Length; i++)
            {
                if(exported[i] != "" && exported[i] != "r" && exported[i] != ".")
                {
                    sum += Int32.Parse(exported[i]) * i;
                }
            }
            return sum;
        }

        static long Part2(string input)
        {
            string renewed = OutputComputedString(input);
            string[] exported = ReorderString2(renewed);

            long sum = 0;
            for (int i = 0; i < exported.Length; i++)
            {
                if (exported[i] != "" && exported[i] != "r" && exported[i] != ".")
                {
                    sum += Int32.Parse(exported[i]) * i;
                }
            }
            return sum;
        }

        static string[] ReorderString(string input)
        {
            string[] converted = input.Split(' ');
            for(int i = 0; i < converted.Length; i++)
            {
                if (converted[i] == ".")
                {
                    int latestNumberId = GetIdOfLastestNumber(converted);

                    if(i > latestNumberId)
                    {
                        break;
                    }

                    converted[i] = converted[latestNumberId];
                    converted[latestNumberId] = "r";
                }
            }

            return converted;
        }

        static string[] ReorderString2(string input)
        {
            string[] converted = input.Split(' ');
            int endStartIndex = converted.Length - 1;
            while(1 == 1)
            {
                int latestNumberIdEnd = GetIdOfLastestNumber(converted, endStartIndex);
                int latestNumberIdStart = GetIdOfLastestNumberStart(latestNumberIdEnd, converted);
                int size = latestNumberIdEnd - latestNumberIdStart + 1;
                int space = SearchForSpace(converted, size);

                if(space != -1 && size != -1 && latestNumberIdStart != -1 && latestNumberIdEnd != -1)
                {
                    if(space < latestNumberIdEnd)
                    {
                        //Set number to proper space
                        for (int u = space; u < space + size; u++)
                        {
                            converted[u] = converted[latestNumberIdStart];
                        }

                        //Delete old values
                        for (int u = latestNumberIdStart; u < latestNumberIdEnd + 1; u++)
                        {
                            converted[u] = ".";
                        }
                    }
                }

                endStartIndex = latestNumberIdStart - 1;

                if(endStartIndex < 3)
                {
                    break;
                }
            }

            return converted;
        }

        static int SearchForSpace(string[] strings, int size)
        {
            for(int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == ".")
                {
                    for(int z = 0; z < 10; z++)
                    {
                        if(strings[i + z] != ".")
                        {
                            break;
                        }
                        if(size - 1 == z)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        static int GetIdOfLastestNumberStart(int latestNumberEnd, string[] strings)
        {
            int indexer = 0;
            while (strings[latestNumberEnd - indexer] == strings[latestNumberEnd])
            {
                indexer++;

                if(latestNumberEnd - indexer < 0)
                {
                    break;
                }
            }
            return latestNumberEnd - indexer + 1;
        }

        static int GetIdOfLastestNumber(string[] strings)
        {
            for(int u = strings.Length - 1; u > -1; u--)
            {
                int number;
                if (Int32.TryParse(strings[u], out number))
                {
                    return u;
                }
            }
            return -1;
        }

        static int GetIdOfLastestNumber(string[] strings, int end_index)
        {
            for (int u = end_index; u > -1; u--)
            {
                int number;
                if (Int32.TryParse(strings[u], out number))
                {
                    return u;
                }
            }
            return -1;
        }

        static char[] ConvertStringToCharArray(string toChange)
        {
            char[] chars = new char[toChange.Length];
            for(int i = 0; i < chars.Length; i++)
            {
                chars[i] = toChange[i];
            }
            return chars;
        }

        static string OutputComputedString(string input)
        {
            int file_id = 0;
            string renewedString = "";
            for(int i = 0; i < input.Length; i++)
            {
                if(i % 2 == 0)
                {
                    string character = Convert.ToString(file_id);
                    int times = Int32.Parse(Convert.ToString(input[i]));
                    renewedString += BuildIterateString(character, times);
                    file_id++;
                }
                if (i % 2 == 1)
                {
                    string character = ".";
                    int times = Int32.Parse(Convert.ToString(input[i]));
                    renewedString += BuildIterateString(character, times);
                }
            }
            return renewedString;
        }

        static string BuildIterateString(string character, int times)
        {
            string sum = "";
            for(int i = 0; i < times; i++)
            {
                sum += character + " ";
            }
            return sum;
        }
    }
}
