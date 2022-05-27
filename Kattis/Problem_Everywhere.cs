using System;

public class Program
{
    static string[] getTheInput(int amount)
    {
        //Read in the values
        string[] text = new String[amount];
        for(int i = 0; i < amount; i++)
        {
            text[i] = Convert.ToString(Console.ReadLine());
        }

        //Return the input
        return text;
    }

    static int Calculate(string[] input)
    {
        //Get an temp array with empty values
        string[] temp = new String[input.Length];
        for(int i = 0; i < temp.Length; i++)
        {
            temp[i] = "#";
        }

        //Check how many distinct countries there are
        int next_free_slot = 0;
        int sol = 0;
        for(int i = 0; i < input.Length; i++)
        {
            //Check if it is already counted
            bool switch1 = false;
            for(int u = 0; u < temp.Length; u++)
            {
                //Condition
                if(input[i] == temp[u])
                {
                    switch1 = true;
                    break;
                }
            }

            //When it is not in the temp array
            if(switch1 == false)
            {
                temp[next_free_slot] = input[i];
                next_free_slot++;
                sol++;
            }
        }

        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the amount of testcases to follow
        int testcases = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //for-loop for each test case
        int[] arr_sol = new Int32[testcases];
        for(int i = 0; i < testcases; i++)
        {
            //Collect the amount of input to follow and collect the input
            int count = Int32.Parse(Convert.ToString(Console.ReadLine()));
            string[] arr = getTheInput(count);

            //Calculate solution out of that array
            int sol = Calculate(arr);

            //Save the solution
            arr_sol[i] = sol;
        }

        //Output the solution
        for(int i = 0; i < arr_sol.Length; i++)
        {
            Console.WriteLine(arr_sol[i]);
        }
    }
}
