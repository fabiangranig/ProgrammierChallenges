using System;

public class Program
{
    static string FizzBuzz(int FizzBuzz_length)
    {
        string solution = "";
        for(int i = 0; i < FizzBuzz_length; i++)
        {
            //Get the real number
            int real = i + 1;

            //Check and add to solution
            if(real % 3 == 0 && real % 5 == 0)
            {
                solution += "fizzbuzz" + " ";
            }
            else
            {
                if(real % 3 == 0)
                {
                    solution += "fizz" + " ";
                }
                else if(real % 5 == 0)
                {
                    solution += "buzz" + " ";
                }
                else
                {
                    solution += real + " ";
                }
            }
        }

        //Return the solution
        return solution;
    }

    public static void Main()
    {
        //Get the first line of input
        string input1 = Convert.ToString(Console.ReadLine());
        string[] split1 = input1.Split(" ");
        int lines_length = Int32.Parse(split1[0]);
        int FizzBuzz_length = Int32.Parse(split1[1]);

        //Get all the lines
        string[] lines = new String[lines_length];
        for(int i = 0; i < lines.Length; i++)
        {
            lines[i] = Convert.ToString(Console.ReadLine());
        }

        //Get the right output
        string c_answer = FizzBuzz(FizzBuzz_length);

        //Check how many answers of each sample are correct
        int[] answer_number = new Int32[lines.Length];
        string[] right_answers_split = c_answer.Split(" ");
        for(int i = 0; i < lines.Length; i++)
        {
            //Split that sample
            string[] split5 = lines[i].Split(" ");

            //Go through and check how many are correct
            answer_number[i] = 0;
            int temp;
            for(int u = 0; u < split5.Length; u++)
            {
                if(right_answers_split[u] == split5[u])
                {
                    answer_number[i]++;
                }
            }
        }

        //Get the slot of the highest number also get the slot of the lowest number
        bool double_highest_value = false;
        int highest_index = -1;
        int highest_number = -1;
        int lowest_index = -1;
        int lowest_number = 1001;
        for(int i = 0; i < answer_number.Length; i++)
        {
            //Get highest for this runthrough
            if(answer_number[i] == highest_number)
            {
                double_highest_value = false;
            }
            if(answer_number[i] > highest_number)
            {
                highest_index = i;
                highest_number = answer_number[i];
                double_highest_value = false;
            }

            //Get lowest for this runthrough
            if(answer_number[i] < lowest_number)
            {
                lowest_index = i;
                lowest_number = answer_number[i];
            }
        }

        //Output the solution
        if(double_highest_value == false)
        {
            Console.WriteLine(highest_index + 1);
        }
        else
        {
            Console.WriteLine(lowest_index + 1);
        }
    }
}
