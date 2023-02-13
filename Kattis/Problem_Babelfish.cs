using System;
using System.Threading;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        string input = Convert.ToString(Console.ReadLine());
        while(1 == 1)
        {
            if(input == "")
            {
                break;
            }
            string[] split = input.Split(" ");
            dict.Add(split[1], split[0]);
            input = Convert.ToString(Console.ReadLine());
        }

        List<string> Ausgabe = new List<string>();
        int counter = 0;
        try
        {
        while(1 == 1)
        {
            input = Convert.ToString(Console.ReadLine());
            if(input == "")
            {
                break;
            }
            if(dict.ContainsKey(input))
            {
                Console.WriteLine(dict[input]);
            }
            else
            {
                Console.WriteLine("eh");
            }
            counter++;
        }
}
        catch(Exception e)
        {
            int a;
        }
    }
}
