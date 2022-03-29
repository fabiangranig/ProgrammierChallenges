using System;

public class Program
{
    static string double_Values(string[] k)
    {
        //Count how many dublicates there are
        string o = "";
        for(int i = 0; i < k.Length; i++)
        {
            if(!o.Contains(k[i]))
            {
                o += k[i] + ".";
            }
        }

        //Split the array
        string sol = o;
        
        //Return the solution
        return sol;
    }

    static string num_sort(string input)
    {
        //Split the string and convert it to an integer
        string[] k = input.Split(" ");
        int[] j = new Int32[] {Int32.Parse(k[0]), Int32.Parse(k[1]), Int32.Parse(k[2])};
        string sol = "";
    
        //Calculate the solution
        Array.Sort(j);

        //Build the new string
        sol = j[0] + " " + j[1] + " " + j[2];
        
        //Return the solution
        return sol;
   }

        
    static bool Sim(string text1, string text2, string text3)
    {    
        //Get the requirements for this problem
        int[] A = new Int32[] {1, 2, 3};
        char[] B = new Char[] {'D', 'S', 'O'};
        char[] C = new Char[] {'S', 'T', 'O'};
        char[] D = new Char[] {'R', 'G', 'B'};

        //Go through the single characters
        bool[] h = new bool[4];
        for(int i = 0; i < 4; i++)
        {
            //Get the chars 
            char[] char1 = new Char[] {text1[i], text2[i], text3[i]};

            //Check if different
            bool bool01 = false;
            bool bool02 = false;
            bool bool03 = false;
            int found = 0;
            for(int f = 0; f < 3; f++)
            {
                if(i == 0)
                {
                     if(char1[f] == '1' && bool01 == false)
                     {
                        found++;
                        bool01 = true;
                     }
                     if(char1[f] == '2' && bool02 == false)
                     {
                        found++;
                        bool02 = true;
                     }
                     if(char1[f] == '3' && bool03 == false)
                     {
                        found++;
                        bool03 = true;
                     }
                }
                if(i == 1)
                {
    
                     if(char1[f] == 'D' && bool01 == false)
                     {
                        found++;
                        bool01 = true;
                     }
                     if(char1[f] == 'S' && bool02 == false)
                     {
                        found++;
                        bool02 = true;
                     }
                     if(char1[f] == 'O' && bool03 == false)
                     {
                        found++;
                        bool03 = true;
                     }
                }
                if(i == 2)
                {
    
                     if(char1[f] == 'S' && bool01 == false)
                     {
                        found++;
                        bool01 = true;
                     }
                     if(char1[f] == 'T' && bool02 == false)
                     {
                        found++;
                        bool02 = true;
                     }
                     if(char1[f] == 'O' && bool03 == false)
                     {
                        found++;
                        bool03 = true;
                     }
                }
                if(i == 3)
                {
    
                     if(char1[f] == 'R' && bool01 == false)
                     {
                        found++;
                        bool01 = true;
                     }
                     if(char1[f] == 'G' && bool02 == false)
                     {
                        found++;
                        bool02 = true;
                     }
                     if(char1[f] == 'P' && bool03 == false)
                     {
                        found++;
                        bool03 = true;
                     }
                }

                if(found == 3)
                {
                    h[i] = true;
                }
            }
                
            //Check if all are the same
            if(char1[0] == char1[1] && char1[1] == char1[2])
            {
                h[i] = true;
            }
        }
       
        //Go through all and check if there true
        int g = 0;
        for(int i = 0; i < 4; i++)
        {
            if(h[i] == true)
            {
                g++;
            }
        }

        //Return the solution 
        if(g == 4)
        {
            return true;
        }
        return false;
    }

    public static void Main()
    {    
        //Get the input
        string[] o = new String[4];
        for(int i = 0; i < 4; i++)
        {
            o[i] = Convert.ToString(Console.ReadLine());
        }

        //Split the lines and put everything into an array
        string[] u = new String[12];
        int j = 0;
        for(int i = 0; i < 4; i++)
        {
            //Split the string
            string[] l = o[i].Split(" ");

            //Get all the numbers in the same array
            for(int z = 0; z < 3; z++)
            {
                u[j] = l[z];
                j++;
            }
        }
        
        //Filter through and get the index numbers
        int sol_number = 0;
        bool sol = false;
        for(int i = 0; i < 12; i++)
        {
            for(int k = 0; k < 12; k++)
            {
                for(int z = 0; z < 12; z++)
                {
                    //Save the 3 string in an other format
                    string text1 = u[i];
                    string text2 = u[k];
                    string text3 = u[z];

                    //Check for the simalarities
                    if(text1 != text2 && text1 != text3 && text2 != text3)
                    {
                        sol = Sim(text1, text2, text3);
                    }

                    //Get the number of solutions
                    if(sol == true && i != k && i != z && z != k)
                    {
                        sol_number++;
                    }
                }
            }
        }

        
        //Filter through and get the index numbers
        string[] sol3 = new String[sol_number];
        int v = 0;
        bool sol2 = false;
        for(int i = 0; i < 12; i++)
        {
            for(int k = 0; k < 12; k++)
            {
                for(int z = 0; z < 12; z++)
                {
                    //Save the 3 string in an other format
                    string text1 = u[i];
                    string text2 = u[k];
                    string text3 = u[z];

                    //Check for the simalarities
                    if(text1 != text2 && text1 != text3 && text2 != text3)
                    {
                        sol2 = Sim(text1, text2, text3);
                    }                    

                    //Get the solutions
                    if(sol2 == true && i != k && i != z && z != k)
                    {
                        sol3[v] = (i+1) + " " + (k+1) + " " + (z+1);
                        v++;
                    }
                }
            }
        }

        //Put the numbers of a string in the correct order
        for(int i = 0; i < sol3.Length; i++)
        {
            sol3[i] = num_sort(sol3[i]);
        }

        //Sort the array
        Array.Sort(sol3);
        
        //Get the end string
        string a = double_Values(sol3);
        
        //If there are no values
        if(sol_number == 0)
        {
            Console.Write("no sets");
        }
        else
        {
            //Split and output it
            string[] ab = a.Split(".");
            for(int i = 0; i < ab.Length - 1; i++)
            {
                Console.WriteLine(ab[i]);
            }
        }
    }
}
