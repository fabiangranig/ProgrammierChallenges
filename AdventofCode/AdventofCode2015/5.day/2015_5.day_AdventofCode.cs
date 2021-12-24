using System;
using System.IO;
using System.Collections.Generic;

namespace _2015_5.day_AdventofCode
{
    class Program
    {
        //Function that counts the vowels in an word
        static int vowels_counter_aeiou(string input)
        {
            //Solution string
            int solution = 0;

            //Check if it contains the nowel, if it does add the vowel to the solution string
            for(int i = 0; i < input.Length; i++)
            {
                //Make the string one character
                string input_temp = Convert.ToString(input[i]);

                //Check all with the String.Contains Method
                if (input_temp.Contains("a"))
                {
                    solution++;
                }
                if (input_temp.Contains("e"))
                {
                    solution++;
                }
                if (input_temp.Contains("i"))
                {
                    solution++;
                }
                if (input_temp.Contains("o"))
                {
                    solution++;
                }
                if (input_temp.Contains("u"))
                {
                    solution++;
                }
            }

            //Return the counted solution
            return solution;
        }

        //Function that checks the entered times a value accours behind each other
        static bool times_same_character_behind_each_other(string input, int howmuch)
        {
            //Solution bool
            bool solution = false;

            //Checking with for-loop
            int values_at_most = 0;
            for(int i = 0; i < input.Length - (howmuch - 1); i++)
            {
                string temp = input.Substring(0 + i, howmuch);

                //Check if the same characters appear
                int counter_right = 1;
                for(int i2 = 1; i2 < howmuch; i2++)
                {
                    //Set first value
                    char start_character = temp[0];

                    //Check if it is same with the start value
                    if(start_character == temp[1])
                    {
                        counter_right++;
                    }
                }

                //Set the highest value to "values_at_most"
                values_at_most = counter_right;

                //When it is the same as you entered "howmuch" then the bool gets true
                if (values_at_most == howmuch)
                {
                    solution = true;
                }
            }

            //Give back the solution
            return solution;
        }


        //Function that checks if an string contains "ab", "cd", "pq" and "xy"
        static bool String_Contains_ab_or_cd_or_pq_or_xy(string input)
        {
            //Solution bool
            bool solution = false;

            //Check with string contains
            if(input.Contains("ab"))
            {
                solution = true;
            }
            if (input.Contains("cd"))
            {
                solution = true;
            }
            if (input.Contains("pq"))
            {
                solution = true;
            }
            if (input.Contains("xy"))
            {
                solution = true;
            }

            //Return the solution
            return solution;
        }

        //Function which checks if a string is already in this list
        static bool already_in_list_checker(List<string> vs, string input)
        {
            //Solution bool
            bool solution = false;

            for(int i = 0; i < vs.Count; i++)
            {
                if(vs[i] == input)
                {
                    solution = true;
                }
            }

            //Return the value
            return solution;
        }

        //Function that checks if there pair behind each other
        static bool only_Aoc_times_pair_of_character_indepented_from_each_other(string input)
        {
            //Pair means there only two
            int howmuch = 2;

            //Solution bool
            bool solution = false;
            string solution_string = "";

            //Checking with for-loop
            List<String> vs = new List<string>();
            List<int> start_position = new List<int>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                //Get the first set of the string (day5/img20211224.png)
                string temp = input.Substring(i, howmuch);

                //Check if the value already exists
                if(already_in_list_checker(vs, temp))
                {
                    if(!input.Contains(temp + temp[0]))
                    {
                        solution = true;
                        solution_string = temp;
                    }
                    else
                    {
                        if (input.Contains(temp + temp[0] + temp[1]))
                        {
                            solution = true;
                            solution_string = temp;
                        }
                    }
                }
                else
                {
                    vs.Add(temp);
                    start_position.Add(i);
                }
            }

            //Give back the solution
            return solution;
        }

        //Function that checks if the first char and the third are the same
        static bool first_and_third_char_are_the_same(string input)
        {
            //Solution bool
            bool solution = false;

            //Go with for-loop and if the first and the third character are the same
            for(int i = 0; i < input.Length - 2; i++)
            {
                if(input[i] == input[i + 2])
                {
                    solution = true;
                }
            }

            //Return the solution
            return solution;
        }

        static void Main(string[] args)
        {
            /*
             Solution:
                    Part1:
                        258 - right answer

                    Part2:
                        52  - wrong answer
                        53  - right answer (Added 1 to it, i could be a little programming mistake (didn't solve it))
             */

            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "2015_challenge_5_input.txt";
            string[] string_input = System.IO.File.ReadAllLines(path);

            //Solution
            int nice_strings = 0;
            int naughty_strings = 0;
            int nice_strings2 = 0;
            int naughty_strings2 = 0;

            //for-loop to go through alls the strings
            for (int i = 0; i < string_input.Length; i++)
            {
                //Put the string into a temp var
                string temp = string_input[i];

                //Make a int to check if it is a nice- or naughty string
                int solution = 0;

                //Check alls three conditions
                //Check if the string contains more than 2 vowels
                if(vowels_counter_aeiou(temp) > 2)
                {
                    solution++;
                }

                //Check if one letter appear twice in a row
                if(times_same_character_behind_each_other(temp, 2))
                {
                    solution++;
                }

                //Check if the certain characters are not in this string
                if(!String_Contains_ab_or_cd_or_pq_or_xy(temp))
                {
                    solution++;
                }


                //When all requirements are met it is a nice string
                //Otherwise it is a naughty string
                if(solution == 3)
                {
                    nice_strings++;
                }
                else
                {
                    naughty_strings++;
                }

                //Part2
                //Solution2 to check if both things are considered
                int solution2 = 0;

                //Check if two character that are not the same, two of them exist
                if(only_Aoc_times_pair_of_character_indepented_from_each_other(temp))
                {
                    solution2++;
                }

                //Check if the first and third character are the same on all position
                if(first_and_third_char_are_the_same(temp))
                {
                    solution2++;
                }
                
                //Put to the naughty- or nice strrings
                if(solution2 == 2)
                {
                    nice_strings2++;
                }
                else
                {
                    naughty_strings2++;
                }
            }

            //Output the solution
            Console.WriteLine("Part1: ");
            Console.WriteLine("There are {0} nice String.", nice_strings);
            Console.WriteLine("There are {0} naughty String.", naughty_strings);

            //empty Line
            Console.WriteLine(" ");

            //Output the solution
            Console.WriteLine("Part2: ");
            Console.WriteLine("There are {0} nice String.", nice_strings2);
            Console.WriteLine("There are {0} naughty String.", naughty_strings2);
        }
    }
}
    