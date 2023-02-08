using System;

public class Program
{
    public static void Main()
    {
        string s1 = Convert.ToString(Console.ReadLine());
        string s2 = Convert.ToString(Console.ReadLine());

        string input = s1 + s2;
        char[] arr, sol;
        arr = StringtoCharArr(input);
        sol = CharBubbleSort(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(sol[i]);
        }
    }
    
    static char[] StringtoCharArr(string input)
    {
        char[] arr = new Char[input.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = input[i];
        }
        return arr;
    }

    static char[] CharBubbleSort(char[] input)
    {
        for(int i = 0; i < input.Length - 1; i++)
        {
            for(int u = 0; u < input.Length - 1; u++)
            {
                if(Convert.ToInt32(input[u + 1]) < Convert.ToInt32(input[u]))
                {
                    char temp = input[u + 1];
                    input[u + 1] = input[u];
                    input[u] = temp;
                }
            }
        }
        return input;
    }
}
