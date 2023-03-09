using System;

namespace FG
{
    //Lib1 Database:
    //-string SwitchDotandComa(string input, char charactertochangeinto)
    //-bool NoRepeatedLetter(string input)
    //-int BitAtPosition(int number, int position)
    //-string[] SimpleSymmetricSort(string[] arr)
    //-int CharToInt(char input)
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
            int number_temp = MathPowInt(2, position);

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

        public static int MathPowInt(int a1, int a2)
        {
            if(a2 == 0)
            {
                return 1;
            }

            int sol = a1;
            for(int i = 1; i < a2; i++)
            {
                sol *= a1;
            }
            return sol;
        }

        public static string[] SimpleSymmetricSort(string[] arr)
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

        public static int CharToInt(char input)
        {
            return Int32.Parse(Convert.ToString(input));
        }
    }
}
