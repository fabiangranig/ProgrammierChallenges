using System;
using System.IO;
using System.Collections.Generic;

namespace Advent_of_Code_Tag_8
{
    class Program
    {
        //Searches for an specific string length in an array
        static string Search_String_Length(string[] array, int length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == length)
                {
                    return array[i];
                }
            }

            return "";
        }

        //Checks which char is missing from 2 strings (only one char difference allowed)
        static string Check_Char_Missing(string s1, string s2)
        {
            //Check which Length is higher
            if (s1.Length > s2.Length)
            {

            }
            else
            {
                string quicksave = s1;
                s1 = s2;
                s2 = quicksave;
            }

            //Sort the strings into array
            char[] s1_char = s1.ToCharArray();
            Array.Sort(s1_char);
            char[] s2_char = s2.ToCharArray();
            Array.Sort(s2_char);

            //Check which char is missing
            for (int i = 0; i < s2_char.Length; i++)
            {
                if (s1_char[i] != s2_char[i])
                {
                    return Convert.ToString(s1_char[i]);
                }
            }

            //If it is not returned it is the last one
            return Convert.ToString(s1_char[s1_char.Length - 1]);
        }

        //Checks which chars are missing from 2 strings (all differences allowed)
        static List<char> Check_Char_Missing_Plus(string s1, string s2)
        {
            bool schalter = false;
            //Check which Length is higher
            if (s1.Length > s2.Length)
            {
                
            }
            else
            {
                schalter = true;
                string quicksave = s1;
                s1 = s2;
                s2 = quicksave;
            }

            //Sort the strings into array
            char[] s1_char = s1.ToCharArray();
            Array.Sort(s1_char);
            char[] s2_char = s2.ToCharArray();
            Array.Sort(s2_char);

            //Get the items into 2 Lists
            List<char> s1_char_list = new List<char>();
            List<char> s2_char_list = new List<char>();

            //Add the items to the list
            for(int i = 0; i < s1.Length; i++)
            {
                s1_char_list.Add(s1_char[i]);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                s2_char_list.Add(s2_char[i]);
            }

            //Remove the items which are to much
            for(int i = 0; i < s2_char.Length; i++)
            {
                s1_char_list.Remove(s2_char_list[i]);
            }

            if (schalter == true)
            {
                char char1 = s1_char_list[0];
                s1_char_list[0] = s1_char_list[1];
                s1_char_list[1] = char1;
            }

            //Return the list
            return s1_char_list;
        }

        //Checks which 2 of the potential chars it is
        static string[] Checks_2_potential_Chars(string s1, List<char> characters, string[] array)
        {
            //Declare for solution
            string[] solution = new string[2];
            string s11 = s1 + Convert.ToString(characters[0]);
            string s12 = s1 + Convert.ToString(characters[1]);

            //Checking with for for the potential Value character
            for (int i = 0; i < array.Length; i++)
            {
                //Sort the values
                s1 = s11;
                char[] s1_characters = s1.ToCharArray();
                Array.Sort(s1_characters);
                char[] array_characters = array[i].ToCharArray();
                Array.Sort(array_characters);

                //Bring the values back to strings
                string string1 = s1_characters.ToString();
                string string2 = array_characters.ToString();

                //Check if it is the right one
                if(string1 == string2)
                {
                    solution[0] = Convert.ToString(characters[1]);
                    solution[1] = Convert.ToString(characters[0]);
                }
            }

            //Checking with for for the potential Value character2
            for (int i = 0; i < array.Length; i++)
            {
                //Sort the values
                s1 = s12;
                char[] s1_characters = s1.ToCharArray();
                Array.Sort(s1_characters);
                char[] array_characters = array[i].ToCharArray();
                Array.Sort(array_characters);

                //Bring the values back to strings
                string string1 = s1_characters.ToString();
                string string2 = array_characters.ToString();

                //Check if it is the right one
                if (string1 == string2)
                {
                    solution[0] = Convert.ToString(characters[0]);
                    solution[1] = Convert.ToString(characters[1]);
                }
            }

            //Return the answer
            return solution;
        }

        static void Main(string[] args)
        {
            /*
             Solution:
                Part1:
                    239 - right answer
             */

            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] list = System.IO.File.ReadAllLines(path);

            //Split the list in Input and Output values
            string[,] list_in_out_put = new string[list.Length, 2];
            string[] splitter;
            for(int i = 0; i < list.Length; i++)
            {
                splitter = list[i].Split(" | ");
                list_in_out_put[i, 0] = splitter[0];
                list_in_out_put[i, 1] = splitter[1];
            }

            //Part 1
            //Part 1
            //Part 1
            //Split the output
            int solution = 0;
            string[] splitter2;
            for(int i = 0; i < list.Length; i++)
            {
                splitter2 = list_in_out_put[i, 1].Split(" ");

                //Check if there is an easy number and when this is so just +1
                for(int i2 = 0; i2 < splitter2.Length; i2++)
                {
                    //Check if the length is number 2, 3, 4 or 7 
                    if(splitter2[i2].Length == 2 || splitter2[i2].Length == 3 || splitter2[i2].Length == 4 || splitter2[i2].Length == 7)
                    {
                        solution++;
                    }
                }
            }

            //Output Solution
            Console.WriteLine("There are {0} unique numbers.", solution);

            //Empty Space
            Console.WriteLine(" ");

            //Part 2
            //Part 2
            //Part 2
            //You can see my thinking in the .png File
            string[] splitter3;
            for(int i = 0; i < list.Length; i++)
            {
                //Create an empty Array to store Strings which are in the right position
                string[] array_position = new string[7];

                //Split the Output
                splitter3 = list_in_out_put[i, 0].Split(" ");

                //Search for an 2 length string and an 3 length string
                string string_length_2 = Search_String_Length(splitter3, 2);
                string string_length_3 = Search_String_Length(splitter3, 3);

                //Position 1 can be found with the function "Check_Char_Missing"
                array_position[0] = Check_Char_Missing(string_length_2, string_length_3);

                //Search for the string with length 4
                string string_length_4 = Search_String_Length(splitter3, 4);

                //Call the Function to get 2 Values which than be considered position 2 and 4
                List<char> char_position_2_and_4 = Check_Char_Missing_Plus(string_length_2, string_length_4);

                //Search for a string with length 7
                string string_length_7 = Search_String_Length(splitter3, 7);
                string string_chars_without_5_and_7 = string_length_3 + Convert.ToString(char_position_2_and_4[0]) + Convert.ToString(char_position_2_and_4[1]);

                //Get Positions 5 and 7
                List<char> char_position_5_and_7 = Check_Char_Missing_Plus(string_length_7, string_chars_without_5_and_7);
                string[] array = Checks_2_potential_Chars(string_chars_without_5_and_7, char_position_5_and_7, splitter3);
                array_position[4] = array[0];
                array_position[6] = array[1];

                //Get Positions 2 and 4
                string string_chars_without_2_and_4 = string_length_3 + array_position[4] + array_position[6];
                array = Checks_2_potential_Chars(string_chars_without_2_and_4, char_position_2_and_4, splitter3);
                array_position[3] = array[1];
                array_position[1] = array[0];

                //Get positions 3 and 6
                string string_chars_without_3_and_6 = array_position[0] + array_position[1] + array_position[3] + array_position[4] + array_position[6];
                List<char> char_position_3_and_6 = Check_Char_Missing_Plus(string_length_7, string_chars_without_3_and_6);
                array = Checks_2_potential_Chars(string_chars_without_3_and_6, char_position_3_and_6, splitter3);
                array_position[2] = array[0];
                array_position[5] = array[1];

                //Assign to the position the numbers
                string[] array_numbers_in_characters = new string[10];
                array_numbers_in_characters[0] = array_position[0] + array_position[1] + array_position[2] + array_position[4] + array_position[5] + array_position[6];
                array_numbers_in_characters[1] = array_position[2] + array_position[5];
                array_numbers_in_characters[2] = array_position[0] + array_position[2] + array_position[3] + array_position[4] + array_position[6];
                array_numbers_in_characters[3] = array_position[0] + array_position[2] + array_position[3] + array_position[5] + array_position[6];
                array_numbers_in_characters[4] = array_position[1] + array_position[2] + array_position[3] + array_position[5];
                array_numbers_in_characters[5] = array_position[0] + array_position[1] + array_position[3] + array_position[5] + array_position[6];
                array_numbers_in_characters[6] = array_position[0] + array_position[1] + array_position[3] + array_position[4] + array_position[5] + array_position[6];
                array_numbers_in_characters[7] = array_position[0] + array_position[2] + array_position[5];
                array_numbers_in_characters[8] = array_position[0] + array_position[1] + array_position[2] + array_position[3] + array_position[4] + array_position[5] + array_position[6];
                array_numbers_in_characters[9] = array_position[0] + array_position[1] + array_position[2] + array_position[3] + array_position[5] + array_position[6];

                //Sort every string
                string quicksave2;
                for(int i2 = 0; i2 < array_numbers_in_characters.Length; i2++)
                {
                    quicksave2 = array_numbers_in_characters[i2];
                    char[] a1 = quicksave2.ToCharArray();
                    Array.Sort(a1);
                    quicksave2 = "";
                    for (int i3 = 0; i3 < a1.Length; i3++)
                    {
                        quicksave2 += Convert.ToString(a1[i3]);
                    }
                    array_numbers_in_characters[i2] = quicksave2;
                }

                //Convert the numbers from the output into the numbers
                string[] splitter_output = list_in_out_put[i, 1].Split(" ");

                //Sort the splitter Output
                string quicksave3;
                for (int i2 = 0; i2 < splitter_output.Length; i2++)
                {
                    quicksave3 = splitter_output[i2];
                    char[] a1 = quicksave3.ToCharArray();
                    Array.Sort(a1);
                    quicksave3 = "";
                    for (int i3 = 0; i3 < a1.Length; i3++)
                    {
                        quicksave3 += Convert.ToString(a1[i3]);
                    }
                    splitter_output[i2] = quicksave3;
                }

                //Solution Output
                for (int i2 = 0; i2 < 4; i2++)
                {
                    for(int i3 = 0; i3 < array_numbers_in_characters.Length; i3++)
                    {
                        if(splitter_output[i2] == array_numbers_in_characters[i3])
                        {
                            Console.Write(i3);
                        }
                    }
                }

                Console.WriteLine(" ");
            }
        }
    }
}
