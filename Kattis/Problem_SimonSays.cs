using System;

public class Program
{
    static bool Comparing(string real, string cont)
    {
        //Go through and check if something is different
        for(int i = 0; i < cont.Length; i++)
        {
            if(real[i] != cont[i])
            {
                return false;
            }
        }

        //If everything is the same return true
        return true;
    }

    public static void Main()
    {
        //Get the first number which determits the number of lines following
        int n = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get all the strings into an array
        string[] arr = new String[n];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
        }

        //Write down the string with which should be checked if it accours
        string inp = "Simon says";

        //Go through all strings and check if it accours
        for(int i = 0; i < arr.Length; i++)
        {
            if(Comparing(arr[i], inp))
            {
                //Output the end of the line
                string sol = "";
                for(int i2 = inp.Length; i2 < arr[i].Length; i2++)
                {
                    sol += Convert.ToString(arr[i][i2]);
                }
                Console.WriteLine(sol);
            }
        }
    }
}
