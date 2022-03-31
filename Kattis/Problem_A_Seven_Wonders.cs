using System;

public class Program
{
    static int[] Count_Cards(string u)
    {
        //Create Variable for each card
        int[] cards = new Int32[3];
        cards[0] = 0;
        cards[1] = 0;
        cards[2] = 0;

        //Go through with for-loop and get the number of each card
        for(int i = 0; i < u.Length; i++)
        {
            if(u[i] == 'T')
            {
                cards[0]++;
            }
            if(u[i] == 'C')
            {
                cards[1]++;
            }
            if(u[i] == 'G')
            {
                cards[2]++;
            }
        }

        //Return the solution
        return cards;
    }

    static int lowestNumberinArray(int[] k)
    {
        //Go through with for loop and get the lowest number
        int number = k[0];
        for(int i = 1; i < k.Length; i++)
        {
            if(k[i] < number)
            {
                number = k[i];
            }
        }

        //Return the solution
        return number;
    }

    public static void Main()
    {
        //Get the input
        string o = Convert.ToString(Console.ReadLine());

        //Get the numbers counted
        int[] count = Count_Cards(o);

        //Get the amount of +7 extra point
        int amount_extra = lowestNumberinArray(count);

        //Calculate the solution
        double sol = Math.Pow(count[0], 2) + Math.Pow(count[1], 2) + Math.Pow(count[2], 2) + (amount_extra * 7);

        //Output the solution
        Console.WriteLine(sol);
    }
}
