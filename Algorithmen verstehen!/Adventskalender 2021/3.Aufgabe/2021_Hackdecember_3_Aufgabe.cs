using System;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "Cybergeschichte.txt";
            string[] story = System.IO.File.ReadAllLines(path);

            //Split at every " "
            string[] story_space_splitte = story[0].Split(" ");

            //Solutions
            string solution = "";

            //Check with for when it contains "Cyber" or "Cyber-"
            for(int i = 0; i < story_space_splitte.Length; i++)
            {
                //Set the current word for the iteration
                string current_word = story_space_splitte[i];

                //Check if it contains a Cyber
                if(current_word.Contains("Cyber") || current_word.Contains("cyber"))
                {
                    if(current_word.Contains("Cyber-") || current_word.Contains("cyber-"))
                    {
                        solution += 1;
                    }
                    else
                    {
                        solution += 0;
                    }
                }
                else
                {

                }
            }

            //Output Solution
            Console.WriteLine("This is the solution of the algorithm: ");
            Console.WriteLine(solution);
        }
    }
}
