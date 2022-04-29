using System;

public class Program
{
    static int Calculate(string text)
    {
        //Make an array where all cups are in the right position
        int[] array = new Int32[] {1, 2, 3};

        //Go through an do each step
        for(int i = 0; i < text.Length; i++)
        {
            //Get the string for this iteration
            string h = Convert.ToString(text[i]);

            //Move the cup
            if(h == "A")
            {
                int k = array[0];
                array[0] = array[1];
                array[1] = k;
            }
            if(h == "B")
            {
                int k = array[1];
                array[1] = array[2];
                array[2] = k;
            }
            if(h == "C")
            {
                int k = array[0];
                array[0] = array[2];
                array[2] = k;
            }
        }

        //Get the solution
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == 1)
            {
                return i + 1;
            }
        }

        //if there is no solution
        return -1;
    }

    public static void Main()
    {
        //Get the input
        string input = Convert.ToString(Console.ReadLine());

        //Calculate the solution
        int sol = Calculate(input);

        //Output the solution
        Console.WriteLine(sol);
    }
}
