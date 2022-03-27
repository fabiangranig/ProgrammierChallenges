using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Output "yup" at the given dates and everything else should show "nope"
        if(o == "OCT 31" || o == "DEC 25")
        {
            //Output yup
            Console.WriteLine("yup");
        }
        else
        {
            //Output nope
            Console.WriteLine("nope");
        }
    }
}
