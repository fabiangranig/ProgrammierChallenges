using System;
using System.IO;
using System.Collections.Generic;

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {   
            //IMPORTANT: "END" is required at the end of the .txt file            

            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] input = System.IO.File.ReadAllLines(path);
            
            //Go through the input
            string current_directory = "";
            int sum_all = 0;
            List<string> sample = new List<string>();
            for(int i = 0; i < input.Length; i++)
            {
                //Directory reading
                if(BeginsWith(input[i], "$ cd "))
                {
                    //Split to seperate the stuff
                    string[] split = input[i].Split(" ");

                    //Check for /
                    if(split[2] == "/")
                    {
                        current_directory += "base";
                    }

                    //Check for new directoty
                    if(split[2] != "/" && split[2] != "..")
                    {
                        current_directory += "/" + split[2];
                    }

                    //Go back one directory
                    if(split[2] == "..")
                    {
                        current_directory = RemoveToCertainCharacter(current_directory, '/');                        
                    }
                }

                //Get insides of an directory
                int quick_sum = 0;
                if(BeginsWith(input[i], "$ ls"))
                {
                    //Output the following lines
                    int count = 0;
                    while(!BeginsWith(input[i + count + 1], "$") && !(input[i + count + 1] == "END"))
                    {
                        string[] split34 = input[i + count + 1].Split(" ");
                        if(split34[0] != "dir")
                        {
                            quick_sum += Int32.Parse(split34[0]);
                        }
                        count++;
                    }
                    i = i + count;
                    sample.Add(current_directory + "|" + quick_sum); 
                }
            }

            //Output all directories with sizes
            for(int i = 0; i < sample.Count; i++)
            {
                Console.WriteLine(sample[i]);
            }

            //emty line
            Console.WriteLine(" ");

            //Get the new sum
            int sum_final = 0;
            int part2_used = -1;
            int[] sample2_int = new Int32[sample.Count];
            for(int i = 0; i < sample.Count; i++)
            {
                string[] split12 = sample[i].Split("|");
                sum_final = 0;
                for(int u = 0; u < sample.Count; u++)
                {
                    string[] split23 = sample[u].Split("|");
                    if(split23[0].Contains(split12[0]))
                    {
                        sum_final += Int32.Parse(split23[1]);
                    }
                }

                Console.WriteLine(split12[0] + "|" + sum_final);
                sample2_int[i] = sum_final;

                if(sum_final <= 100000)
                {
                    sum_all += sum_final;
                }
                if(i == 0)
                {
                    part2_used = sum_final;
                }
            }

            //Get the required space
            int remaining_space = 70000000 - part2_used;
            int required_space = 30000000 - remaining_space;

            //Get the minimum of required space
            int best_number = 70000000;
            for(int i = 0; i < sample2_int.Length; i++)
            {
                if(required_space < sample2_int[i] && sample2_int[i] < best_number)
                {
                    best_number = sample2_int[i];
                }
            }

            //Output the solution
            Console.WriteLine("The solution for part 1 is: " + sum_all);
            Console.WriteLine("The solution for part 2 is: " + best_number);
        }

        static bool BeginsWith(string should_contain, string tocheck)
        {
            for(int i = 0; i < tocheck.Length; i++)
            {
                if(tocheck[i] != should_contain[i])
                {
                    return false;
                }
            }  

            //When everything is alright
            return true;
        }

        static bool BeginsWith2(string should_contain, string tocheck, int checker)
        {
            for(int i = 0; i < checker; i++)
            {
                if(tocheck[i] != should_contain[i])
                {
                    return false;
                }
            }  

            //When everything is alright
            return true;
        }

        static string RemoveToCertainCharacter(string input, char checker)
        {
            string sol = "";
            int length = -1;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[input.Length - 1 - i] == checker)
                {
                    length = input.Length - i - 1;
                    break;
                }
            }

            //Build the new string
            for(int i = 0; i < length; i++)
            {
                sol += input[i];
            }

            //Return the solution
            return sol;
        }
    }
}
