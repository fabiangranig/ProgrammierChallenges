using System;

public class Program
{
    public static void Main()
    {
        //Runtime: 20ms

        //Read in the lines
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        //if-Condition
        if(x > 0)
        {
            if(y > 0)
            {
                //Output the answer
                Console.WriteLine(1);
            }
            if(y < 0)
            {
                //Output the answer
                Console.WriteLine(4);
            }
        }
        else
        {
            if(y > 0)
            {
                //Output the answer
                Console.WriteLine(2);
            }

            if(y < 0)
            {
                //Output the answer
                Console.WriteLine(3);
            }
        }
    }
}
