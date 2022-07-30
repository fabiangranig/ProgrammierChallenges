using System;

namespace FG
{
    public class Lib
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
    }
}
