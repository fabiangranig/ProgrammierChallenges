using System;
using System.IO;

namespace Advent_of_Code_Tag_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Solutions - Tests:
                Part1:
                    355764 - right answer

                Part2:
                    99634572 - right answer
            */
            
            //Read the .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input.txt";
            string[] input = System.IO.File.ReadAllLines(path);

            //Split by ","
            string[] numbers_string = input[0].Split(",");

            //Convert from String into Int32
            int[] numbers = new int[numbers_string.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Int32.Parse(numbers_string[i]);
            }

            //Creating an other Array
            int[] numbers_fake = new Int32[numbers.Length];
            //Copy the normal Array into the Fake One
            Array.Copy(numbers, numbers_fake, numbers.Length);
            
            //Set Variables to confirm the best solution
            long recordcount = 99999999999999;
            int recordnumber = 0;
            int totalcount = 0;
            
            //Enabel Fuelcount for second Part
            int fuelcounter = 1;
            bool enable_fuelcount = false;

            //Calculating
            //for is used to check if this number is a valid solution
            for(int i = 0; i < 1000; i++)
            {
                //for is used for checking every number against the first for number
                for(int i2 = 0; i2 < numbers_fake.Length; i2++)
                {
                    //Checks if it's needing to count up or down
                    if (numbers_fake[i2] > i)
                    {
                        while(numbers_fake[i2] > i)
                        {
                            numbers_fake[i2]--;
                            totalcount = totalcount + fuelcounter;

                            if(enable_fuelcount == true)
                            {
                                fuelcounter++;
                            }
                        }

                        fuelcounter = 1;
                    }  
                    if (numbers_fake[i2] < i)
                    {
                        while(numbers_fake[i2] < i)
                        {
                            numbers_fake[i2]++;
                            totalcount = totalcount + fuelcounter;

                            if (enable_fuelcount == true)
                            {
                                fuelcounter++;
                            }
                        }
                    }
                    fuelcounter = 1;
                }

                //If the fuel count is lower it is getting saved
                if(totalcount < recordcount)
                {
                    recordcount = totalcount;
                    recordnumber = i;
                }

                //Reset a few variables
                totalcount = 0;
                Array.Copy(numbers, numbers_fake, numbers.Length);
            }

            //Give back the solution
            Console.WriteLine("All needed to go to position {0} with the fuel amount of {1}.", recordnumber, recordcount);
        }
    }
}
