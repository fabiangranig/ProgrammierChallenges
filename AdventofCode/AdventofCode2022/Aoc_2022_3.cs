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
            
            //Output the solution
            int sol1 = CheckforCharacter(numbers);
            Console.WriteLine("The solution for the first part is: "+ sol1);
            int sol2 = CheckforCharactersinthreeStack(numbers);
            Console.WriteLine("The solution for the second part is: "+ sol2);
        }
        
        static int CheckforCharactersinthreeStack(string[] arr)
        {
            //Create the sum
            int sum = 0;
            
            //Check each time three lines and get the right character
            for(int i = 0; i < arr.Length; i = i + 3)
            {
                string s1 = arr[i];
                string s2 = arr[i + 1];
                string s3 = arr[i + 2];
                char working = '#';
                for(int u = 0; u < s1.Length; u++)
                {
                    //If the condition is met, break;
                    if(s2.Contains(Convert.ToString(s1[u])) && s3.Contains(Convert.ToString(s1[u])))
                    {
                        working = s1[u];
                        //Add the number to the sum and break the loop
                        //Check if string is an Upper or Lower Case letter
                        if(Char.IsUpper(working))
                        {
                            sum += (int)working - 38;
                        }
                        else
                        {
                            sum += (int)working - 96;
                        }
                        
                        //Break the loop
                        break;
                    }
                }
            }

            //Return the sum
            return sum;
        }

        static int CheckforCharacter(string[] arr)
        {
            //Loop over all items
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {                
                //Quicksave components
                string first_comp = "";
                string second_comp = "";                

                //Split the line into two apartments
                for(int u = 0; u < arr[i].Length / 2; u++)
                {
                    first_comp += Convert.ToString(arr[i][u]);
                    second_comp += Convert.ToString(arr[i][arr[i].Length / 2 + u]);
                }

                //Check which character is in question
                for(int u = 0; u < second_comp.Length; u++)
                {
                    //Check for the character
                    if(first_comp.Contains(Convert.ToString(second_comp[u])))
                    {
                        //Add the number to the sum and break the loop
                        //Check if string is an Upper or Lower Case letter
                        char working = second_comp[u];
                        if(Char.IsUpper(working))
                        {
                            sum += (int)working - 38;
                        }
                        else
                        {
                            sum += (int)working - 96;
                        }
                        
                        //Break the loop
                        break;
                    }
                }
            }

            //Return the sum 
            return sum;
        }
    }
}
