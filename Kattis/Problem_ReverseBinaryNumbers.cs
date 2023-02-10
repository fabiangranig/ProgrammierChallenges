using System;
using System.Numerics;
using static FG.Lib1;

public class Program
{
    public static void Main()
    {
        //Get the number
        int number = Convert.ToInt32(Console.ReadLine());
        
        //Check the length of the number    
        int binary_length = GetBinaryNumbers(number);

        //Get the sum of each bit
        int sum = 0;
        int counter = 0;
        for(int i = binary_length - 1; i > -1; i--)
        {
            if(BitAtPosition(number, i) == 1)
            {
                sum += MathPowInt2(2, counter);
            }
            counter++;
        }

        //Output the sum
        Console.WriteLine(sum);
    }

    static int GetBinaryNumbers(int input)
    {
        int sum = 0;
        int counter = 0;
        while(input > sum)
        {
            int quick = MathPowInt2(2, counter);
            sum = sum + quick;
            counter++;
        }
        return counter;
    }

    static int MathPowInt2(int low, int high)
    {
        int number = 1;
        for(int i = 0; i < high; i++)
        {
            number *= low;
        }
        return number;
    }
}
