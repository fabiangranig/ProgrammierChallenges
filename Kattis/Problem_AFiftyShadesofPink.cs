using System;

public class Program
{
    public static void Main()
    {
        //Get how many lines to follow
        int length1 = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the  input and get the solution
        string[] arr = new String[length1];
        int sol = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToString(Console.ReadLine());
            if(arr[i].ToUpper().Contains("PINK"))
            {
                sol++;
            }
            else
            {
                if(arr[i].ToUpper().Contains("ROSE"))
                {
                    sol++;
                }
            }
        }

        //Output the solution
        if(sol > 0)
        {
            Console.WriteLine(sol);
        }
        else
        {
            Console.WriteLine("I must watch Star Wars with my daughter");
        }
    }
}
