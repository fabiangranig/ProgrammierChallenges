using System;

public class Program
{
    static int Calculate(int start_time, int[] walks, int[] bus_time, int[] bus_interval, int n)
    {
        //Walk to the bus
        int current_time = start_time + walks[0];

        //Get the time between (travel all buses)
        int travelled_buses = 0;
        for(int i = 0; i < n; i++)
        {
            //Travel bus if possible
            if(current_time % bus_interval[travelled_buses] == 0)
            {
                current_time += bus_time[travelled_buses];
                travelled_buses++;

                //Add time to the next bus station
                current_time += walks[i+1];
            }
            else
            {
                //Let the time pass
                i--;
                current_time++;
            }
        }

        //Return the solution
        return current_time;
    }
    
    public static void Main()
    {
        //How the input works
        //s=0 t=20 n=2
        //w1=2 w2=2 w3=2
        //bt1=5 bt2=5
        //i1=3 i2=5

        //Get the lines of input
        string s1 = Convert.ToString(Console.ReadLine());
        string s2 = Convert.ToString(Console.ReadLine());
        string s3 = Convert.ToString(Console.ReadLine());
        string s4 = Convert.ToString(Console.ReadLine());

        //Get the input in another variables
        string[] split1 = s1.Split(" ");
        string[] split2 = s2.Split(" ");
        string[] split3 = s3.Split(" ");
        string[] split4 = s4.Split(" ");
        int start_time = Int32.Parse(split1[0]);
        int end_time = Int32.Parse(split1[1]);
        int n = Int32.Parse(split1[2]);
        int[] walks = new Int32[n+1];
        for(int i = 0; i < walks.Length; i++)
        {
            walks[i] = Int32.Parse(split2[i]);
        }
        int[] bus_time = new Int32[n];
        for(int i = 0; i < bus_time.Length; i++)
        {
            bus_time[i] = Int32.Parse(split3[i]);
        }
        int[] bus_interval = new Int32[n];
        for(int i = 0; i < bus_interval.Length; i++)
        {
            bus_interval[i] = Int32.Parse(split4[i]);
        }

        //Calculate the solution
        int sol = Calculate(start_time, walks, bus_time, bus_interval, n);

        //Output the solution
        if(end_time >= sol)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
