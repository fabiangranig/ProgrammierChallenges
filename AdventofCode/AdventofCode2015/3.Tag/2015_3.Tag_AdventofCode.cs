using System;
using System.IO;
using System.Collections.Generic;

namespace _2015_3.Tag_AdventofCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Solution:
                Part1: 
                    2081 - right answer
                
                Part2:
                    2342 - too high
                    2341 - right answer
             */

            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "2015_challenge_3_input.txt";
            string[] directions = System.IO.File.ReadAllLines(path);

            //Create a list where already gone to positions are in and an Integer Array for the curent position ([0] = x; [1] = y)
            //For the second part is a new list needed
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            list.Add("0,0");
            list2.Add("0,0");

            //Houses he got to once
            int houses_he_got_to_once = 1;
            int houses_they_got_to = 1;

            //Get how often moved
            int movement_counter = 1;

            //Set current postion
            int[] current_position = new int[2];
            current_position[0] = 0;
            current_position[1] = 0;

            //Two new positions for Part2 Santa and RobotSanta
            int[] current_position2 = new int[2];
            current_position2[0] = 0;
            current_position2[1] = 0;
            int[] current_position3 = new int[2];
            current_position3[0] = 0;
            current_position3[1] = 0;

            //for to go through all directions
            for (int i = 0; i < directions[0].Length; i++)
            {
                //Put the used value in a new char
                char current_movement = directions[0][i];

                //Translate the position to the cordinate system
                if(current_movement == '^')
                {
                    current_position[1]++;
                }
                if (current_movement == 'v')
                {
                    current_position[1]--;
                }
                if (current_movement == '<')
                {
                    current_position[0]--;
                }
                if (current_movement == '>')
                {
                    current_position[0]++;
                }

                //Part2: Translate the position to the cordinate system
                if(movement_counter % 2 == 1)
                {
                    if (current_movement == '^')
                    {
                        current_position2[1]++;
                    }
                    if (current_movement == 'v')
                    {
                        current_position2[1]--;
                    }
                    if (current_movement == '<')
                    {
                        current_position2[0]--;
                    }
                    if (current_movement == '>')
                    {
                        current_position2[0]++;
                    }
                }
                if (movement_counter % 2 == 0)
                {
                    if (current_movement == '^')
                    {
                        current_position3[1]++;
                    }
                    if (current_movement == 'v')
                    {
                        current_position3[1]--;
                    }
                    if (current_movement == '<')
                    {
                        current_position3[0]--;
                    }
                    if (current_movement == '>')
                    {
                        current_position3[0]++;
                    }
                }

                //Check if this cordinate exist in the list and count up if not
                string current_cordinate_string = current_position[0] + "," + current_position[1];
                if(list.Contains(current_cordinate_string))
                {
                    
                }
                else
                {
                    houses_he_got_to_once++;
                    list.Add(current_cordinate_string);
                }

                //Part2: Check if this cordinate exist in the list and count up if not
                string current_cordinate_string2 = current_position2[0] + "," + current_position2[1];
                if (list2.Contains(current_cordinate_string2))
                {

                }
                else
                {
                    houses_they_got_to++;
                    list2.Add(current_cordinate_string2);
                }
                string current_cordinate_string3 = current_position3[0] + "," + current_position3[1];
                if (list2.Contains(current_cordinate_string3))
                {

                }
                else
                {
                    houses_they_got_to++;
                    list2.Add(current_cordinate_string3);
                }

                movement_counter++;
            }

            //Output Solution Part 1
            Console.WriteLine("He visited {0}.Houses at least once.", houses_he_got_to_once);
            //Output Solution Part 2
            Console.WriteLine("Both visited {0}.Houses at least once.", houses_they_got_to);
        }
    }
}
