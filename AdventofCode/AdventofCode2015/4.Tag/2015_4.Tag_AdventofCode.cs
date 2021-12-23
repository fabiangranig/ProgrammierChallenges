using System;
using System.Text;
using System.Collections.Generic;

namespace _2015_4.Tag_AdventofCode
{
    class Program
    {
        //Function from "https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5%28v=vs.110%29.aspx"
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            /*
             Solution:
                Part1:
                    282749 - right answer

                Part2:
                    9962624 - right answer
             */

            //Input (this time it is a small input)
            string input = "yzbqklnj";
            List<string> output_5_zeros = new List<string>();
            int still_there = 0;

            //Use for to add numbers to the string
            for(int i = 1; i < 9999999; i++)
            {
                //Checker to check if the console is still alive
                still_there++;
                if(still_there % 1000000 == 0)
                {
                    Console.WriteLine("Still alive is at: {0}", still_there);
                }

                //Add the number to the string
                string temp_input = input + Convert.ToString(i);
                string output = CreateMD5(temp_input);

                //When the number contains 5 zeros save it to a string
                if(output.StartsWith("00000"))
                {
                    output_5_zeros.Add(input + " + " + i + " = " + output);
                }
            }

            //empty Line
            Console.WriteLine(" ");

            //Output
            Console.WriteLine("This is the output:");
            for(int i = 0; i < output_5_zeros.Count; i++)
            {
                int count = i + 1;
                Console.WriteLine(count + ".Item: " + output_5_zeros[i].ToLower());
            }
        }
    }
}
