using System;

public class Program
{
    public static void Main()
    {
        //Get the both input lines
        string text1 = Convert.ToString(Console.ReadLine());
        string text2 = Convert.ToString(Console.ReadLine());

        //Get the length
        int length1 = text1.Length;
        int length2 = text2.Length;

        //Check which is larger and then Output
        if(length1 >= length2)
        {
            Console.WriteLine("go");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
