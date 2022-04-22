using System;

public class Program
{
    static int Calculate(string card, string trumph, string[] t_c1, int[] t_c2, int[] t_c3)
    {
        //Get the position of the card
        int a = -1;
        for(int i = 0; i < t_c1.Length; i++)
        {
            if(card[0] == t_c1[i][0])
            {
                a = i;
            }
        }

        //Check if the card is an trumph card
        if(card[1] == trumph[0])
        {
            return t_c2[a];
        }

        //Return if the card is not an trumph card
        return t_c3[a];
    }

    public static void Main()
    {
        //Get the first line for to check how many cards are there
        string fl = Convert.ToString(Console.ReadLine());

        //Split it to get the first and second character
        string[] split = fl.Split(" ");
        int fv = Int32.Parse(split[0]);
        string trumph = split[1];

        //Now get the real number of values
        int count_values = fv * 4;

        //Get all the values
        string[] array = new String[count_values];
        for(int i = 0; i < count_values; i++)
        {
            array[i] = Convert.ToString(Console.ReadLine());
        }

        //Get the table into an array
        string[] table_column1 = new String[8] {"A", "K", "Q", "J", "T", "9", "8", "7"};
        int[] table_column2 = new Int32[8] {11, 4, 3, 20, 10, 14, 0, 0};
        int[] table_column3 = new Int32[8] {11, 4, 3, 2, 10, 0, 0, 0};

        //Get the point of the cards and get through all of them
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += Calculate(array[i], trumph, table_column1, table_column2, table_column3);
        }

        //Output the solution
        Console.WriteLine(sum);
    }
}
