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
            string[] numbers = System.IO.File.ReadAllLines(path);
            
            //Write the string into an new file
            string input = numbers[0];

            //Build a string with 4 characters and then check each time
            for(int i = 0; i < input.Length; i++)
            {
                string check = "";

                //Change condition u < value | Part1: 4, Part2:14
                for(int u = 0; u < 14; u++)
                {
                    check += input[i + u];
                }
        
                //Check for double characters
                bool sol = Dublicates(check);
                if(sol == false)
                {
                    //+1 because loop starts counting at 0
                    //Change condition (i+1+value) | Part1: 3, Part2: 13
                    Console.WriteLine("The selected parts solution is: " + (i+1+13));
                    break;
                }

                //Reset the test string
                check = "";
            }
        }

        static bool Dublicates(string input)
        {
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                char check = input[i];
                for(int u = 0; u < input.Length; u++)
                {
                    if(check == input[u])
                    {
                        count++;
                    }
                    if(count > 1)
                    {
                        return true;
                    }
                }
                count = 0;
            }

            //When nothing is found
            return false;
        }
    }
}
