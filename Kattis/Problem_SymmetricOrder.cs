using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = Convert.ToString(Console.ReadLine());
        List<string[]> lists = new List<string[]>(); 
        while(input != "0")
        {
            //Get all of the inputs
            int counting = Int32.Parse(input);
            string[] arr = new String[counting];
            for(int i = 0; i < counting; i++)
            {
                arr[i] = Convert.ToString(Console.ReadLine());
            }

            //Add the array to the list
            lists.Add(arr);

            //Get next value
            input = Convert.ToString(Console.ReadLine());    
        }

        //SymmetricSort the lists
        for(int i = 0; i < lists.Count; i++)
        {
            lists[i] = SymmetricSort(lists[i]);
        }

        //Output the solution
        Output(lists);
    }

    static string[] SymmetricSort(string[] arr)
    {
        string[] new_arr = new String[arr.Length];
        int count = 1;
        int NextFreeSlot_Top = 0;
        int NextFreeSlot_Bottom = arr.Length - 1;
        for(int i = 0; i < arr.Length; i++)
        {
            if(count % 2 == 1)
            {
                new_arr[NextFreeSlot_Top] = arr[i];
                NextFreeSlot_Top++;
                count++;
            }
            else if(count % 2 == 0)
            {
                new_arr[NextFreeSlot_Bottom] = arr[i];
                NextFreeSlot_Bottom--;
                count++;
            }
        }

        //Return the list
        return new_arr;
    }

    static void Output(List<string[]> lists)
    {
        for(int i = 0; i < lists.Count; i++)
        {
            Console.WriteLine("SET " + (i+1));
            OutputIntArr(lists[i]);
        }
    }

    static void OutputIntArr(string[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
