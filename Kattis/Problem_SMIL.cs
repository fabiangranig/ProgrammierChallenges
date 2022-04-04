using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Add a few characters for insurance
        o += "  ";

        //Go through an check for ":"
        for(int i = 0; i < o.Length; i++)
        {
            if(o[i] == ':' || o[i] == ';')
            {
                //The check if the next characters are right
                if(o[i+1] == ')')
                {
                    Console.WriteLine(i);
                }
                if(o[i+1] == '-' && o[i+2] == ')')
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
