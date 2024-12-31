using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AoC2024_day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] example = File.ReadAllLines("example.txt");
            int example_solution = Example(example);
            Console.WriteLine("Example: " + example_solution);

            string[] input = File.ReadAllLines("input.txt");
            int part1_solution = Part1(input);
            Console.WriteLine("Part1: " + part1_solution);
            int part2_solution = Part2(input);
            Console.WriteLine("Part2: " + part2_solution);
        }

        static int Example(string[] input)
        {
            Robot[] robots = RobotFillExample(input);

            for (int i = 0; i < robots.Length; i++)
            {
                for (int u = 0; u < 100; u++)
                {
                    robots[i].MakeMove();
                    //Console.WriteLine();
                    //ShowMap(robots);
                }
            }

            int quadrant1 = CountRobotersInQuadrantExample(robots, 1);
            int quadrant2 = CountRobotersInQuadrantExample(robots, 2);
            int quadrant3 = CountRobotersInQuadrantExample(robots, 3);
            int quadrant4 = CountRobotersInQuadrantExample(robots, 4);

            return quadrant1 * quadrant2 * quadrant3 * quadrant4;
        }

        static int Part1(string[] input)
        {
            Robot[] robots = RobotFill(input);
            
            for(int i = 0; i < robots.Length; i++)
            {
                for(int u = 0; u < 100; u++)
                {
                    robots[i].MakeMove();
                    //Console.WriteLine();
                    //ShowMap(robots);
                }
            }

            int quadrant1 = CountRobotersInQuadrantInput(robots, 1);
            int quadrant2 = CountRobotersInQuadrantInput(robots, 2);
            int quadrant3 = CountRobotersInQuadrantInput(robots, 3);
            int quadrant4 = CountRobotersInQuadrantInput(robots, 4);

            return quadrant1 * quadrant2 * quadrant3 * quadrant4;
        }

        //Needs user input
        static int Part2(string[] input)
        {
            Robot[] robots = RobotFill(input);

            for (int u = 1; u < 10000; u++)
            {
                for (int i = 0; i < robots.Length; i++) 
                {
                    robots[i].MakeMove();
                }
                //ShowMapPart2(robots);
                //Thread.Sleep(1000);
                //Console.Clear();
                int quadrant11 = CountRobotersInQuadrantInput(robots, 1);
                int quadrant22 = CountRobotersInQuadrantInput(robots, 2);
                int quadrant33 = CountRobotersInQuadrantInput(robots, 3);
                int quadrant44 = CountRobotersInQuadrantInput(robots, 4);
                if (quadrant11 * quadrant22 * quadrant33 * quadrant44 < 100000000)
                {
                    Console.WriteLine(u + " " + u + " " + u);
                    Console.WriteLine(quadrant11 * quadrant22 * quadrant33 * quadrant44);
                    ShowMapPart2(robots);
                    //Thread.Sleep(5000);
                }
            }

            int quadrant1 = CountRobotersInQuadrantInput(robots, 1);
            int quadrant2 = CountRobotersInQuadrantInput(robots, 2);
            int quadrant3 = CountRobotersInQuadrantInput(robots, 3);
            int quadrant4 = CountRobotersInQuadrantInput(robots, 4);

            return quadrant1 * quadrant2 * quadrant3 * quadrant4;
        }



        static Robot[] RobotFill(string[] input)
        {
            Robot[] robots = new Robot[input.Length];
            for (int i = 0; i < robots.Length; i++)
            {
                string[] split = input[i].Split(' ');
                string[] split2 = split[0].Split('=');
                string[] split3 = split2[1].Split(',');

                string[] split4 = split[1].Split('=');
                string[] split5 = split4[1].Split(',');

                robots[i] = new Robot(Int32.Parse(split3[0]), Int32.Parse(split3[1]), Int32.Parse(split5[0]), Int32.Parse(split5[1]), 101, 103);
            }
            return robots;
        }

        static Robot[] RobotFillExample(string[] input)
        {
            Robot[] robots = new Robot[input.Length];
            for (int i = 0; i < robots.Length; i++)
            {
                string[] split = input[i].Split(' ');
                string[] split2 = split[0].Split('=');
                string[] split3 = split2[1].Split(',');

                string[] split4 = split[1].Split('=');
                string[] split5 = split4[1].Split(',');

                robots[i] = new Robot(Int32.Parse(split3[0]), Int32.Parse(split3[1]), Int32.Parse(split5[0]), Int32.Parse(split5[1]), 11, 7);
            }
            return robots;
        }

        static void ShowMap(Robot[] robots)
        {
            for(int i = 0; i < robots[0].mapHeigth; i++)
            {
                for(int u = 0; u < robots[0].mapLength; u++)
                {
                    Console.Write(CountRobotersOnPosition(robots, u, i));
                }
                Console.WriteLine();
            }
        }

        static void ShowMapPart2(Robot[] robots)
        {
            for (int i = 0; i < robots[0].mapHeigth; i++)
            {
                for (int u = 0; u < robots[0].mapLength; u++)
                {
                    if(0 < CountRobotersOnPosition(robots, u, i))
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }                    
                }
                Console.WriteLine();
            }
        }

        static int CountRobotersOnPosition(Robot[] robots, int PosX, int PosY)
        {
            int counter = 0;
            for(int i = 0; i < robots.Length; i++)
            {
                if (robots[i].PosX == PosX && robots[i].PosY == PosY)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountRobotersInQuadrantExample(Robot[] robots, int quadrant)
        {
            int counter = 0;
            for (int i = 0; i < robots.Length; i++)
            {
                //Quadrant1
                if (quadrant == 1 && robots[i].PosX < robots[i].mapLength / 2 && robots[i].PosY < robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant2
                if (quadrant == 2 && robots[i].PosX > robots[i].mapLength / 2 && robots[i].PosY < robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant3
                if (quadrant == 3 && robots[i].PosX < robots[i].mapLength / 2 && robots[i].PosY > robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant4
                if (quadrant == 4 && robots[i].PosX > robots[i].mapLength / 2 && robots[i].PosY > robots[i].mapHeigth / 2)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int CountRobotersInQuadrantInput(Robot[] robots, int quadrant)
        {
            int counter = 0;
            for (int i = 0; i < robots.Length; i++)
            {
                //Quadrant1
                if (quadrant == 1 && robots[i].PosX < robots[i].mapLength / 2 && robots[i].PosY < robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant2
                if (quadrant == 2 && robots[i].PosX > robots[i].mapLength / 2 && robots[i].PosY < robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant3
                if (quadrant == 3 && robots[i].PosX < robots[i].mapLength / 2 && robots[i].PosY > robots[i].mapHeigth / 2)
                {
                    counter++;
                }
                //Quadrant4
                if (quadrant == 4 && robots[i].PosX > robots[i].mapLength / 2 && robots[i].PosY > robots[i].mapHeigth / 2)
                {
                    counter++;
                }
            }
            return counter;
        }
    }

    public class Robot
    {
        public int PosX;
        public int PosY;
        public int VelX;
        public int VelY;
        public int mapLength;
        public int mapHeigth;

        public Robot(int start_x, int start_y, int velocity_x, int velocity_y, int mapLength, int mapHeight)
        {
            this.PosX = start_x;
            this.PosY = start_y;
            this.VelX = velocity_x;
            this.VelY = velocity_y;
            this.mapLength = mapLength;
            this.mapHeigth = mapHeight;
        }

        public void MakeMove()
        {
            this.PosX += VelX;
            this.PosY += VelY;

            if(this.PosX >= mapLength)
            {
                int minusLength = this.PosX - mapLength;
                this.PosX = minusLength;
            }
            if (this.PosX < 0)
            {
                int minusLength = this.PosX * -1;
                this.PosX = mapLength - minusLength;
            }
            if (this.PosY >= mapHeigth)
            {
                int minusLength = this.PosY - mapHeigth;
                this.PosY = minusLength;
            }
            if (this.PosY < 0)
            {
                int minusLength = this.PosY * -1;
                this.PosY = mapHeigth - minusLength;
            }
        }
    }
}
