using System;
using System.Collections.Generic;

public class Program
{
    static bool NoRepeatedLetter(string input)
    {
        //Go through the string and check if there a repeating letters
        for(int i = 0; i < input.Length; i++)
        {
            char c1 = input[i];
            int count = 0;
            for(int i2 = 0; i2 < input.Length; i2++)
            {
                char c2 = input[i2];
                if(c1 == c2)
                {
                    count++;
                }

                if(count > 1)
                {
                    return false;
                }
            }
        }
        
        //If there is no double character return true
        return true;
    }

    public static void Main()
    {
        //Get the input
        int length1 = Int32.Parse(Convert.ToString(Console.ReadLine()));
        List<string> names = new List<string>();
        for(int i = 0; i < length1; i++)
        {
            string in1 = Convert.ToString(Console.ReadLine());
            
            //Put the first requirements
            if(in1.Length >= 5 && NoRepeatedLetter(in1))
            {
                names.Add(in1);
            }
        }
        

        //Get the num of the shortest string
        int shortest = 21;
        for(int i = 0; i < names.Count; i++)
        {
            if(names[i].Length < shortest)
            {
                shortest = names[i].Length;
            }
        }

        //Get a list of the names with that "shortest" as String.Length 
        List<string> names2 = new List<string>();
        int values = 0;
        for(int i = 0; i < names.Count; i++)
        {
            if(names[i].Length == shortest)
            {
                values++;
                names2.Add(names[i]);
            }
        }

        //Output if there is no value
        if(values == 0)
        {
            Console.WriteLine("neibb!");
        }
        else
        {
            //Sort the list and get the largest in the alphabet
            names2.Sort();
            names2.Reverse();
            
            //Output the solution
            Console.WriteLine(names2[0]);
        }
    }
}
