using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Split the line
        string[] k = input.Split(" ");

        //Put the string array in a workable format
        int a = Int32.Parse(k[0]);
        int b = Int32.Parse(k[1]);

        //Calculate the solution
        while(1 == 1)
        {
            //Guard if
            if(a == b)
            {
                int c = a + 1;
                Console.WriteLine(c);
                break;
            }

            //Get the lower number
            if(b < a)
            {
                int c = a;
                a = b;
                b = c;
            }

            //Loop through and output the solution
            for(int i = a + 1; i < b + 2; i++)
            {
                Console.WriteLine(i);
            }
            
            //Destroy the while
            break;
        }
    }
}
