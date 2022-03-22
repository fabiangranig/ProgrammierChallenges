using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string z = Convert.ToString(Console.ReadLine());
        string o = Convert.ToString(Console.ReadLine());

        //Split the input
        string[] m = o.Split(" ");

        //Go through the array and find the lowest value
        int l = 1000000000;
        for(int i = 0; i < m.Length; i++)
        {
            //Get the lowest number
            if(Int32.Parse(m[i]) < l)
            {
                //Set the newer lowest number
                l = Int32.Parse(m[i]);
            }
        }

        //Check on which position the lowest number is
        int pos = -1;
        for(int i = 0; i < m.Length; i++)
        {
            //Check for the number
            if(Int32.Parse(m[i]) == l)
            {
                pos = i;
                break;
            }
        }
    
        //Output the solution
        Console.WriteLine(pos);
    }
}
