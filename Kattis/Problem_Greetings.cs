using System;

public class Program
{
    //Count characters
    static int getCharacters(string k, string c)
    {
        //Go through the string
        int counter = 0;
        for(int i = 0; i < k.Length; i++)
        {
            if(Convert.ToString(k[i]) == c)
            {
                counter++;
            }
        }   
        
        //Return the solution
        return counter;
    }

    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Get the "e"
        int e = getCharacters(o, "e");

        //Build double as many e
        o = "h";
        for(int i = 0; i < e * 2; i++)
        {
            o += "e";
        }

        //Add the rest of the string
        o += "y";

        //Output the solution
        Console.WriteLine(o);
    }
}
