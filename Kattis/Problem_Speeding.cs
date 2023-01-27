using System;

public class Program
{
    public static void Main()
    {
        //Get how many line are to follow
        int lines = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Set the start values
        string new_dataset = Convert.ToString(Console.ReadLine());
        string[] arr = new_dataset.Split(" ");
        int time = Int32.Parse(arr[0]);
        int distance = Int32.Parse(arr[1]);

        //Go through all values and determined the max value
        int max = 0;
        for(int i = 0; i < lines - 1; i++)
        {
            //Get the values to calculate from
            string new_dataset2 = Convert.ToString(Console.ReadLine());
            string[] arr2 = new_dataset2.Split(" ");
            int time2 = Int32.Parse(arr2[0]);
            int distance2 = Int32.Parse(arr2[1]);
        
            //Calculate the new velocity
            int velocity = (distance2 - distance) / (time2 - time);

            //Check if it is the highest velocity
            if(velocity > max)
            {
                max = velocity;
            }

            //Return the values to the next staying time and distances variables
            time = time2;
            distance = distance2;
        }

        //Output the highest velocity
        Console.WriteLine(max);
    }
}
