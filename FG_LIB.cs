using System;

namespace FG
{
    //Lib1 Database:
    //-string SwitchDotandComa(string input, char charactertochangeinto)
    //-bool NoRepeatedLetter(string input)
    //-int BitAtPosition(int number, int position)
    public class Lib1
    {
        public static string SwitchDotandComa(string input, char charactertochange)
        {
            //Go through the string and change on dot and coma
            string sol = "";
            for(int i = 0; i < input.Length; i++)
            {
                //if it is an dot or coma
                if(input[i] == '.' || input[i] == ',')
                {
                    sol += Convert.ToString(charactertochange);
                }
                else
                {
                    sol += Convert.ToString(input[i]);
                }
            }

            //Return the solution
            return sol;
        }

        public static bool NoRepeatedLetter(string input)
        {
            //Go through the string and check if there a repeating letters
            for(int i = 0; i < input.Length; i++)
            {
                char c1 = input[i];
                int count = 0;
                for(int i2 = 0; i2 < input.Length; i2++)
                {
                    char c2 = input[i2];
                    if(c1 == c2)
                    {
                        count++;
                    }

                    if(count > 1)
                    {
                        return false;
                    }
                }
            }
        
            //If there is no double character return true
            return true;
        }

        public static int BitAtPosition(int number, int position)
        {
            //Die Nummer finden um zu vergleichen
            int number_temp = Convert.ToInt32(Math.Pow(2, position));

            //Die beiden mit und verbinden
            int sol = number & number_temp;

            //Ausgeben wenn es vorkommt
            if (sol > 0)
            {
                return 1;
            }

            //Wenn es nicht vorkommt
            return 0;
        }
    }
}
