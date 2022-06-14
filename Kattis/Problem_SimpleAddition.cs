using System;

public class Program
{
    static string Calculate(string s1, string s2)
    {
        //Reverse the string
        s1 = Reverse(s1);
        s2 = Reverse(s2);        

        //Add one letter at an the time togheter
        string newSol = "";
        int quicksave = 0;
        for(int i = 0; i < s1.Length; i++)
        {
            //Get the int of this step
            int n1 = Int32.Parse(Convert.ToString(s1[i]));
            int n2 = Int32.Parse(Convert.ToString(s2[i]));

            //Add them together
            int sum = n1 + n2 + quicksave;
            quicksave = 0;

            //If it is bigger then 10 or not
            if(sum > 9)
            {
                //Convert the sum to an string
                string sum1 = Convert.ToString(sum);
                quicksave = Int32.Parse(Convert.ToString(sum1[0]));
                newSol += Int32.Parse(Convert.ToString(sum1[1]));
            }
            else
            {
                newSol += Convert.ToString(sum);
            }
        }
        
        //Add the quicksave if there still is one
        if(quicksave > 0)
        {
            newSol += Convert.ToString(quicksave);
        }

        //Reverse the solution
        newSol = Reverse(newSol);
        

        //Return the solution
        return newSol;
    }

    static string Reverse(string s)
    {
        //Go through with for-loop and get turn the string around
        string sol = "";
        for(int i = 0; i < s.Length; i++)
        {
            sol += Convert.ToString(s[s.Length - 1 - i]);
        }

        //Return the solution
        return sol;
    }

    static string EvenOut(string s1, string s2)
    {
        //Get the difference of tiles
        int length = s1.Length - s2.Length;

        //Build an string with that much "0" at the beginning
        string sol = "";
        for(int i = 0; i < length; i++)
        {
            sol += "0";
        }

        //Add the rest of the string
        sol += s2;

        //Return the solution
        return sol;
    }

    public static void Main()
    {
        //Get the input of the two numbers
        string n1 = Convert.ToString(Console.ReadLine());
        string n2 = Convert.ToString(Console.ReadLine());

        //Even out the number
        if(n1.Length > n2.Length)
        {
            n2 = EvenOut(n1, n2);
        }
        else if (n2.Length > n1.Length)
        {
            n1 = EvenOut(n2, n1);
        }
        
        //Add the two numbers togheter
        string sol = Calculate(n1, n2);

        //Output the solution
        Console.WriteLine(sol);
    }
}
