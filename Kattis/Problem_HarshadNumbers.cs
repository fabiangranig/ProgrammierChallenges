using System;

public class Program
{
    public static void Main()
    {
        //Get the input
        int input = Convert.ToInt32(Console.ReadLine());

        //Get the "Ziffernsumme" of the input
        int sum = SumofDigits(Convert.ToString(input));

        //Output if it is alright
        if(input % sum == 0)
        {
            Console.WriteLine(input);
        }
        else
        {
            //Get the next harshad number
            input++;
            while(input % SumofDigits(Convert.ToString(input)) != 0)
            {
                input++;
            }
            Console.WriteLine(input);
        }
    }

    static int SumofDigits(string input)
    {
        int sum = 0;
        for(int i = 0; i < input.Length; i++)
        {
            sum += Int32.Parse(Convert.ToString(Convert.ToChar(input[i])));
        }
        return sum;
    }
}
