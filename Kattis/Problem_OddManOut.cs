using System;

public class Program
{
    public static void Main()
    {
        //Get how many testcases are to follow
        int testcases = Convert.ToInt32(Console.ReadLine());

        string[] arr = new String[testcases];

        for(int i = 0; i < testcases; i++)
        {
            //Get how many numbers are in the line
            int input_lines = Convert.ToInt32(Console.ReadLine());
            string input = Convert.ToString(Console.ReadLine());
            string[] split = input.Split(" ");
            
            Array.Sort(split);        

            for(int u = 0; u < split.Length - 1; u = u + 2)
            {
                if(split[u] != split[u+1])
                {
                    arr[i] = split[u];
                    break;
                }

                if(arr[i] == null)
                {
                    arr[i] = split[split.Length-1];
                }
            }
        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Case #" + (i+1) + ": " + arr[i]);
        }
    }
}
