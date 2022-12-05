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
            string[] input = System.IO.File.ReadAllLines(path);
            
            //Get the line where the commands start
            int splitter = -1;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == "")
                {
                    splitter = i;
                    break;
                }
            }

            //Get all the lines for the stacks
            string[] stacks = new String[splitter];
            
            //Set all stacks to ""
            for(int i = 0; i < stacks.Length; i++)
            {
                stacks[i] = "";
            }

            //Get every stack
            int count = 0;
            for(int i = 1; i < 36; i=i+4)
            {
                for(int u = 0; u < splitter - 1; u++)
                {
                    if(input[u][i] != ' ')
                    {
                        stacks[count] += input[u][i];
                    }
                }
                count++;

                if(i == 35)
                {
                    break;
                }
            }

            //Reverse everything in the stack
            for(int i = 0; i < stacks.Length; i++)
            {
                stacks[i] = ReverseString(stacks[i]);
            }
            
            //Calculate the solution (can be shifting_containers or shifting_containers2 (Part1 or Part2))
            int command_start = splitter + 1;
            for(int i = command_start; i < input.Length; i++)
            {
                //Get all variables
                string working = input[i];
                string[] split = working.Split(" ");
                int howmany = Int32.Parse(split[1]);
                int start_point = Int32.Parse(split[3]) - 1;
                int end_point = Int32.Parse(split[5]) - 1;
 
                //Calculate the solution
                string[] tarr = shifting_containers2(stacks[start_point], stacks[end_point], howmany);
                stacks[start_point] = tarr[0];
                stacks[end_point] = tarr[1];
            }

            //Output the array
            for(int i = 0; i < stacks.Length; i++)
            {
                Console.WriteLine(stacks[i]);
            }
            
            //Output the solution for the first part
            Console.WriteLine("The solution for the selected part is: " + GetLastChar(stacks));
        }

        static string ReverseString(string input)
        {
            string sol = "";
            for(int i = 0; i < input.Length; i++)
            {
                sol += Convert.ToString(input[input.Length - 1 - i]);
            }
            return sol;
        }

        static string[] shifting_containers(string input1, string input2, int number)
        {
            //Shift the containers to the second string
            for(int i = 0; i < number; i++)
            {
                input2 += Convert.ToString(input1[input1.Length - 1 - i]);
            }
            input1 = RemoveCharacters(input1, number);

            //Return the new strings
            string[] arr = new String[2];
            arr[0] = input1;
            arr[1] = input2;

            //Return the solution
            return arr;
        }

        static string[] shifting_containers2(string input1, string input2, int number)
        {
            //Shift the containers to second string but althoughter
            string temp = "";
            for(int i = 0; i < number; i++)
            {
                temp += Convert.ToString(input1[input1.Length - 1 - i]);
            }
            temp = ReverseString(temp);
            input2 += temp;
            input1 = RemoveCharacters(input1, number);

            //Return the new strings
            string[] arr = new String[2];
            arr[0] = input1;
            arr[1] = input2;

            //Return the solution
            return arr;
        }
  

        static string RemoveCharacters(string input, int number)
        {
            //Put everything in an new string and return it
            string sol = "";
            for(int i = 0; i <  input.Length - number; i++)
            {
                sol += Convert.ToString(input[i]);
            }
            return sol;
        }

        static string GetLastChar(string[] arr)
        {
            string sol = "";
            for(int i = 0; i < arr.Length; i++)
            {
                sol += Convert.ToString(arr[i][arr[i].Length - 1]);
            }
            return sol;
        }
    }
}
