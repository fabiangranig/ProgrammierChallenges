using System;
using System.Numerics;
using static FG.Lib1;

public class Program
{
    public static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());
        
        //Check how long the sequence will be
        int binary_length = BinaryLength(number);

        //Get the sequence
        string sequence = "";
        for(int i = 0; i < binary_length; i++)
        {
            sequence += BitAtPosition(number, i);
        }
        char[] arr = sequence.ToCharArray();
        Array.Reverse(arr);
        sequence = new String(arr);

        string new_sequence = "";
        bool schalter = true;
        for(int i = 0; i < sequence.Length; i++)
        {
            if(sequence[i] == '0' && schalter == true)
            {
                binary_length--;
            }
            if(sequence[i] == '1' || schalter == false)
            {
                new_sequence += sequence[i];
                schalter = false;
            }
        }
        sequence = new_sequence;

        int sum = 0;
        for(int i = 0; i < binary_length; i++)
        {
            if(sequence[i] == '1')
            {
                sum += MathPowInt(2, i);
            }
        }
        Console.WriteLine(sum);
    }

    static int BinaryLength(long input)
    {
        int i = 0;
        while(Math.Pow(i, 2) <= input)
        {
            i++;
        }
    
        return i;
    }
}
