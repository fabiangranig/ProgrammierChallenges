using System;

public class Program
{
    static int SumItem(string o)
    {
        //Split the lines
        string[] k = o.Split(" ");

        //Sum up all the values
        int sum = 0;
        for(int i = 0; i < k.Length; i++)
        {
            sum += Int32.Parse(k[i]);
        }

        //Return the solution
        return sum;
    }    

    public static void Main()
    {
        //Get the first two lines
        string o = Convert.ToString(Console.ReadLine());
        string u = Convert.ToString(Console.ReadLine());

        //Split the first string into the different parts
        string[] l = o.Split(" ");
        double max_weight = Int32.Parse(l[0]);
        double truck_weight = Convert.ToDouble(l[1]);
        int lines = Int32.Parse(l[2]);

        //Get the sum of the second line
        int items_sum = SumItem(u);

        //Perform necessary calcultions
        double sol = max_weight - truck_weight;
        sol *= 0.9;
        sol -= items_sum;

        //Output the solution
        Console.WriteLine(sol);
    }
}
