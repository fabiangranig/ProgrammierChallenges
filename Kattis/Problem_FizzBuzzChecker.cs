using System;

public class Program
{
    static string FizzBuzz(int FizzBuzz_length)
    {
        string solution = "";
        for(int i = 0; i < FizzBuzz_length)
        {
            //Get the real number
            int real = i + 1;

            //Check and add to solution
            if(real % 3 = 0 && real % 5 == 0)
            {
                solution += "FizzBuzz" + " ";
            }
            else
            {
                if(real % 3 == 0)
                {
                    solution += "Fizz" + " ";
                }
                else if(real % 5 == 0)
                {
                    solution += "Buzz" + " ";
                }
                else
                {
                    solution += real + " ";
                }
            }
        }
    }

    public static void Main()
    {
        //Get the first line of input
        string input1 = Convert.ToString(Console.ReadLine());
        string[] split1 = input1.Split(" ");
        int lines_length = Int32.Parse(split1[0]);
        int FizzBuzz_length = Int32.Parse(split[1]);

        //Get all the lines
        string[] lines = new String[lines_length];
        for(int i = 0; i < lines.Length; i++)
        {
            lines[i] = Convert.ToString(Console.ReadLine());
        }

        //Get the right output
        string c_answer = FizzBuzz(FizzBuzz_lenth);
    }
}
