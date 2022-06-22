using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Get the name and sort them in
        string current_name = Convert.ToString(Console.ReadLine());
        Dictionary<string, int> hash = new Dictionary<string, int>();
        while(current_name != "***")
        {
            //Check if the value exits
            if(hash.ContainsKey(current_name))
            {
                hash[current_name]++;
            }
            else
            {
                hash.Add(current_name, 1);
            }

            //Get the next name
            current_name = Convert.ToString(Console.ReadLine());
        }
        
        //Go through and check for the highest values
        int highest_number = -1;
        string highest_index = "";
        int count = 0;
        foreach(KeyValuePair<string, int> pair in hash)
        {
            if(pair.Value == highest_number)
            {
                count++;
            }

            if(pair.Value > highest_number)
            {
                highest_number = pair.Value;
                highest_index = pair.Key;
                count = 1;
            }
        }

        //Output
        if(count > 1)
        {
            Console.WriteLine("Runoff!");
        }
        else
        {
            Console.WriteLine(highest_index);
        }
    }
}
