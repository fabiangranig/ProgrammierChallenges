using System;

public class Program
{
    public static void Main()
    {
        //Get how many inputs are to follow
        int input_length = Int32.Parse(Convert.ToString(Console.ReadLine()));
        
        //Get all inputs into an array, with that instantly compute the solution
        string[] arr = new String[input_length];
        for(int i = 0; i < arr.Length; i++)
        {
            //Get the value
            arr[i] = Convert.ToString(Console.ReadLine());

            //Calculate
            arr[i] = Encode(arr[i]);
        }                

        //Output the solution
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static string Encode(string input)
    {
        //Get the length of the string
        int s_length = input.Length;
        
        //Get the x from x*x
        int x = Convert.ToInt32(Math.Sqrt(s_length));

        //Create an array and iterate through the word
        string[] arr = new String[x];
        int count = 0;
        for(int i = 0; i < input.Length; i++)
        {
            //Add the character to the array layer
            arr[count] += Convert.ToString(input[i]);

            //Higher one up
            count++;
            
            //Reset the count
            if(count > x - 1)
            {
                count = 0;
            }
        }

        //Build the string
        string sol = "";
        for(int i = 0; i < arr.Length; i++)
        {
            sol += arr[arr.Length - 1 -i];
        }

        //Return the solution
        return sol;
    }
}
