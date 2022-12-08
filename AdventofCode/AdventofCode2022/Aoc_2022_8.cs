using System;
using System.IO;

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            //Check all directions and sum up the trees
            int sol = 0;
            int sum = 0;
            bool locker = true;
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int u = 0; u < numbers.Length; u++)
                {
                    //bool values
                    bool left = false;
                    bool right = false;
                    bool up = false;
                    bool down = false;

                    //numbers
                    int n_left = 0;
                    int n_right = 0;
                    int n_up = 0;
                    int n_down = 0;

                    //Used indice
                    int indice = Int32.Parse(Convert.ToString(numbers[i][u]));
                    Console.WriteLine(i + " " + u + " " + indice);

                    //Check left side
                    locker = true;
                    for(int t = 0; t < u; t++)
                    {
                        int left_side = Int32.Parse(Convert.ToString(numbers[i][u - t - 1]));
                        //Console.WriteLine("Left side: " + left_side);

                        if(indice <= left_side && !left)
                        {
                            left = true;
                        }
                        if(indice > left_side && locker)
                        {
                            n_left++;
                        }
                        if(indice <= left_side && locker)
                        {
                            n_left++;
                            locker = false;
                        }
                    }

                    //Check right side
                    locker = true;
                    for(int z = 0; z < numbers[i].Length - 1 - u; z++)
                    {
                        int right_side = Int32.Parse(Convert.ToString(numbers[i][u + z + 1]));
                        //Console.WriteLine("Right side: " + right_side);

                        if(indice <= right_side && !right)
                        {
                            right = true;
                        }
                        if(indice > right_side && locker)
                        {
                            n_right++;
                        }
                        if(indice <= right_side && locker)
                        {
                            n_right++;
                            locker = false;
                        }
                    }

                    //Check upwards
                    locker = true;
                    for(int o = 0; o < i; o++)
                    {
                        int up_side = Int32.Parse(Convert.ToString(numbers[i - o - 1][u]));
                        //Console.WriteLine("Up side: " + up_side);
                        
                        if(indice <= up_side && !up)
                        {
                            up = true;
                        }
                        if(indice > up_side && locker)
                        {
                            n_up++;
                        }
                        if(indice <= up_side && locker)
                        {
                            n_up++;
                            locker = false;
                        }
                    }

                    //Check downwards
                    locker = true;
                    for(int l = 0; l < numbers.Length - 1 - i; l++)
                    {
                        int down_side = Int32.Parse(Convert.ToString(numbers[i + l + 1][u]));
                        //Console.WriteLine("Downside: " + down_side);

                        if(indice <= down_side && !down)
                        {
                            down = true;
                        }
                        if(indice > down_side && locker)
                        {
                            n_down++;
                        }
                        if(indice <= down_side && locker)
                        {
                            n_down++;
                            locker = false;
                        }
                    }

                    //Check if it is hidden
                    if(!left || !right || !up || !down)
                    {
                        sol++;
                    }

                    //Calculate the second equation
                    int q_sum = n_left * n_right * n_down * n_up;
                    if(q_sum > sum)
                    {
                        sum = q_sum;
                    }
                }
            }

            //Output the solution
            Console.WriteLine("The solution for the first part is: " + sol);
            Console.WriteLine("The solution for the second part is: " + sum);
        }
    }
}
