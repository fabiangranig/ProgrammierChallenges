using System;

public class Program
{
    //Function to get the sum of the single characters
    static int getSumofCharacters(string o)
    {
        //Calculate the sum
        int sum = 0;
        for(int i = 0; i < o.Length; i++)
        {
            sum += Int32.Parse(Convert.ToString(o[i]));
        }

        //Return the solution
        return sum;
    }
    
    public static void Main()
    {
        //Get the input
        string[] numbers = new String[100000];
        int count = 0;
        for(int i = 0; i < 100000; i++)
        {
            string g = Convert.ToString(Console.ReadLine());
            if(g == "0")
            {
                break;
            }

            numbers[count] = g;
            count++;
        }
        
        //Build the second array
        string[] k = new String[count];
        for(int i = 0; i < k.Length; i++)
        {
            k[i] = numbers[i];
        }
        
        //Split the numbers up and convert them into integers
        int[] m = new Int32[k.Length];
        for(int i = 0; i < k.Length; i++)
        {
            m[i] = Int32.Parse(k[i]);
        }

        //Calculate all solutions
        for(int i = 0; i < m.Length; i++)
        {
            int r = m[i];
            int count2 = 11;
            while(1 == 1)
            {
                if(getSumofCharacters(Convert.ToString(r)) == getSumofCharacters(Convert.ToString(r * count2)))
                {
                    m[i] = count2;
                    break;
                }
                
                count2++;
            }
        }

        //Output the solution
        for(int i = 0; i < m.Length; i++)
        {
            Console.WriteLine(m[i]);
        }
    }
}
