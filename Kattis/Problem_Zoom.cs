using System;

public class Program
{
    public static void Main()
    {
        //Get the two lines of input
        string s1 = Convert.ToString(Console.ReadLine());
        string s2 = Convert.ToString(Console.ReadLine());

        //Get the first string split
        string[] split1 = s1.Split(" ");
        int length1 = Int32.Parse(split1[0]);
        int skip = Int32.Parse(split1[1]);

        //Get the second string split
        string[] split2 = s2.Split(" ");

        //Output the new solution
        for(int i = skip - 1; i < length1; i = i + skip)
        {
            Console.Write(split2[i]  + " ");
        }
    }
}
