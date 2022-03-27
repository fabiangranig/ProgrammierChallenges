using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Check if there are two times the same character
        //Create variable to detect if it is possible
        int j = 1;
        for(int i = 0; i < o.Length; i++)
        {
            //If it is already found that it won't work break the for-loop
            if(j == 0)
            {
                break;
            }
            
            //Select character
            char k = o[i];
            
            //Go through and check if there are two of them
            int g = 0;
            for(int u = 0; u < o.Length; u++)
            {
                if(k == o[u])
                {
                    g++;
                    if(g > 1)
                    {
                        j = 0;
                    }
                }
            }
        }

        //Output the solution
        Console.WriteLine(j);
    }
}
