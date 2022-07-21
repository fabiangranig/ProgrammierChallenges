using System;

public class Program
{
    public static void Main()
    {
        //Get all the teams and calculate the solution
        int t_length = Int32.Parse(Convert.ToString(Console.ReadLine()));
        int winner_count = 0;
        string[] winners = new String[12];
        for(int i = 0; i < winners.Length; i++){winners[i] = Convert.ToString(i);}
        bool lock1 = false;
        for(int i = 0; i < t_length; i++)
        {
            //Read in
            string read = Convert.ToString(Console.ReadLine());

            //Check if the value is in the array
            bool switch1 = true;
            for(int u = 0; u < winners.Length; u++)
            {
                string[] split1 = read.Split(' ');
                string s1 = split1[0];
                string[] split2 = winners[u].Split(' ');
                string s2 = split2[0];
                if(s1 == s2)
                {
                    switch1 = false;
                    break;
                }
            }

            //When it is not in the array add it
            if(switch1 == true && lock1 == false)
            {
                winners[winner_count] = read;
                winner_count++;
            }

            //Break if there are 12 winners
            if(winner_count == 12)
            {
                lock1 = true;
            }
        }

        //Output the solution
        for(int i = 0; i < winners.Length; i++)
        {
            Console.WriteLine(winners[i]);
        }
    }
}
