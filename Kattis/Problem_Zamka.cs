using System;

public class Program
{
    static int SumChar(int a)
    {
        //Convert the int to an string
        string m = Convert.ToString(a);

        //Go through with an for loop and add the characters togheter
        int sum = 0;
        for(int i = 0; i < m.Length; i++)
        {
            sum += Int32.Parse(Convert.ToString(m[i]));
        }

        //Return the solution
        return sum;
    }

    static int NumLow(int min, int max, int target)
    {
        //Go through with for-loop and get all possible answers
        for(int i = min; i < max + 1; i++)
        {
            if(SumChar(i) == target)
            {
                return i;
            }
        }

        //If there is no solution
        return -1;
    }
    
    static int NumHigh(int min, int max, int target)
    {
        //Go through with an while-loop
        int count = max;
        while(1 == 1)
        {
            //If the solution is found return it
            if(SumChar(count) == target)
            {
                return count;
            }

            //If the limit is reached break out of the while loop
            if(count == min)
            {
                break;
            }

            //If no matches found go to the next number
            count--;
        }

        //If there is no solution
        return -1;
    }

    public static void Main()
    {
        //Get the three inputs
        int L = Int32.Parse(Convert.ToString(Console.ReadLine())); 
        int D = Int32.Parse(Convert.ToString(Console.ReadLine()));
        int X = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Change the variables to bester names
        int min = L;
        int max = D;
        int target = X;

        //Calculate the low  solution
        Console.WriteLine(NumLow(min, max, target));
        Console.WriteLine(NumHigh(min, max, target));
    }
}
