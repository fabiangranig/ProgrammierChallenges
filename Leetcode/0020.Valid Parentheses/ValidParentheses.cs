using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(IsValid(Convert.ToString(Console.ReadLine())));
    }

    static bool IsValid(string s) {
        //Search for next to and delete them
        string s1 = s;
        int tried = 0;
        while(1 == 1)
        {
            //Check for every backet and delete it
            if(s1.Contains("()"))
            {
                s1 = RemoveFromString(s1, "()");
                tried = 0;
            }
            if(s1.Contains("[]"))
            {
                s1 = RemoveFromString(s1, "[]");
                tried = 0;
            }
            if(s1.Contains("{}"))
            {
                s1 = RemoveFromString(s1, "{}");
                tried = 0;
            }

            //Exit condition
            tried++;
            if(tried > 2)
            {
                break;
            }
        }

        //Check if it meets the conditions or not
        if(s1.Length > 0)
        {
            return false;
        }
        return true;
    }

    static string RemoveFromString(string s, string searched)
    {
        //Search for searched string and delete it
        for(int i = 0; i < s.Length; i++)
        {
            if(searched[0] == s[i] && searched[1] == s[i + 1])
            {
                string new_s = s.Remove(i, 2);
                return new_s;
            }
        }

        //Return the start value when nothing was found
        return s;
    }
}