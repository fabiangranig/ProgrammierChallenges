using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        string s1 = Convert.ToString(Console.ReadLine());
        int state = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get all the numbers
        string[] split = s1.Split(" ");
        int[] grade_set = new Int32[split.Length];
        for(int i = 0; i < grade_set.Length; i++)
        {
            grade_set[i] = Int32.Parse(split[i]);
        }

        //Get the solution
        string grades = "ABCDEF";
        string sol = "";
        for(int i = 0; i < grades.Length; i++)
        {
            if(i == 5)
            {
                sol = Convert.ToString(grades[5]);
                break;
            }
            if(state >= grade_set[i])
            {
                sol = Convert.ToString(grades[i]);
                break;
            }
        }

        //Output the solution
        Console.WriteLine(sol);
    }
}
