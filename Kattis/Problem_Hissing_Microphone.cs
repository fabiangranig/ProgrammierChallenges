using System;

public class Program
{
    public static void Main()
    {
        //Get the input string
        string o = Convert.ToString(Console.ReadLine());

        //Check if there are two "s" behind each other
        bool switch1 = false;
        for(int i = 1; i < o.Length; i++)
        {
            if(o[i - 1] == o[i] && o[i] == 's')
            {
                switch1 = true;
                break;
            }
        }

        //Output the solution
        if(switch1 == true)
        {
            Console.WriteLine("hiss");
        }
        else
        {
            Console.WriteLine("no hiss");
        }
    }
}
