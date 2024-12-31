using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC2024_day12.Program;
using System.Threading;

namespace AoC2024_day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int part1_solution = Part1(input);
            Console.WriteLine("The solution to part 1 is: " + part1_solution);

            int part2_solution = Part2(input);
            Console.WriteLine("The solution to part 2 is: " + part2_solution);

            string[] example1 = File.ReadAllLines("example1.txt");
            int example1_solution = Part2(example1);
            Console.WriteLine("Example1: " + example1_solution + " | 80");

            string[] example2 = File.ReadAllLines("example2.txt");
            int example2_solution = Part2(example2);
            Console.WriteLine("Example2: " + example2_solution + " | 436");

            string[] example3 = File.ReadAllLines("example3.txt");
            int example3_solution = Part2(example3);
            Console.WriteLine("Example3: " + example3_solution + " | 1206");

            string[] eshape = File.ReadAllLines("eshape.txt");
            int eshape_solution = Part2(eshape);
            Console.WriteLine("Eshape: " + eshape_solution + " | 236");

            string[] squares = File.ReadAllLines("squares.txt");
            int squares_solution = Part2(squares);
            Console.WriteLine("Squares: " + squares_solution + " | 368");

            string[] custom = File.ReadAllLines("custom.txt");
            int custom_solution = Part2(custom);
            Console.WriteLine("Custom: " + custom_solution);
        }

        static int Part1(string[] input)
        {
            Square[,] squares = ConvertInputToSquares(input);
            return GetFenceCost(squares);
        }

        static int Part2(string[] input)
        {
            Square[,] squares = ConvertInputToSquares(input);
            return GetFenceCost2(squares);
        }

        static int GetFencesAtPosition(Square[,] squares, int positionY, int positionX)
        {
            int fences = 0;
            if (squares[positionY, positionX].Fence_Up == true)
            {
                fences++;
            }
            if (squares[positionY, positionX].Fence_Right == true)
            {
                fences++;
            }
            if (squares[positionY, positionX].Fence_Down == true)
            {
                fences++;
            }
            if (squares[positionY, positionX].Fence_Left == true)
            {
                fences++;
            }
            return fences;
        }

        static string GetFencesAtPositionString(Square[,] squares, int positionY, int positionX)
        {
            string fences = "";
            if (squares[positionY, positionX].Fence_Up == true)
            {
                fences += "U" + positionY + "|" + positionX + " ";
            }
            if (squares[positionY, positionX].Fence_Right == true)
            {
                fences += "R" + positionY + "|" + positionX + " ";
            }
            if (squares[positionY, positionX].Fence_Down == true)
            {
                fences += "D" + positionY + "|" + positionX + " ";
            }
            if (squares[positionY, positionX].Fence_Left == true)
            {
                fences += "L" + positionY + "|" + positionX + " ";
            }
            return fences;
        }

        static int RecursiveFences(ref Square[,] squares, int positionY, int positionX)
        {
            int fences = 0;
            fences += GetFencesAtPosition(squares, positionY, positionX);
            squares[positionY, positionX].CheckedFences = true;

            if (positionY - 1 > -1 && squares[positionY - 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY - 1, positionX].CheckedFences == false)
            {
                fences += RecursiveFences(ref squares, positionY - 1, positionX);
            }

            if (positionX + 1 < squares.GetLength(1) && squares[positionY, positionX + 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX + 1].CheckedFences == false)
            {
                fences += RecursiveFences(ref squares, positionY, positionX + 1);
            }

            if (positionY + 1 < squares.GetLength(0) && squares[positionY + 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY + 1, positionX].CheckedFences == false)
            {
                fences += RecursiveFences(ref squares, positionY + 1, positionX);
            }

            if (positionX - 1 > -1 && squares[positionY, positionX - 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX - 1].CheckedFences == false)
            {
                fences += RecursiveFences(ref squares, positionY, positionX - 1);
            }

            return fences;
        }

        static string RecursiveFences2(ref Square[,] squares, int positionY, int positionX)
        {
            string fences = "";
            fences += GetFencesAtPositionString(squares, positionY, positionX);
            squares[positionY, positionX].CheckedFences = true;

            if (positionY - 1 > -1 && squares[positionY - 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY - 1, positionX].CheckedFences == false)
            {
                fences += RecursiveFences2(ref squares, positionY - 1, positionX);
            }

            if (positionX + 1 < squares.GetLength(1) && squares[positionY, positionX + 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX + 1].CheckedFences == false)
            {
                fences += RecursiveFences2(ref squares, positionY, positionX + 1);
            }

            if (positionY + 1 < squares.GetLength(0) && squares[positionY + 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY + 1, positionX].CheckedFences == false)
            {
                fences += RecursiveFences2(ref squares, positionY + 1, positionX);
            }

            if (positionX - 1 > -1 && squares[positionY, positionX - 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX - 1].CheckedFences == false)
            {
                fences += RecursiveFences2(ref squares, positionY, positionX - 1);
            }

            return fences;
        }

        static int GetFenceCost(Square[,] squares)
        {
            int cost = 0;
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int u = 0; u < squares.GetLength(1); u++)
                {
                    if (squares[i, u].CheckedArea == false)
                    {
                        int area = RecursiveArea(ref squares, i, u);
                        int fences = RecursiveFences(ref squares, i, u);
                        cost += area * fences;
                    }
                }
            }
            return cost;
        }

        static int GetFenceCost2(Square[,] squares)
        {
            int cost = 0;
            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int u = 0; u < squares.GetLength(1); u++)
                {
                    if (squares[i, u].CheckedArea == false)
                    {
                        int area = RecursiveArea(ref squares, i, u);
                        string AllFencesString = RecursiveFences2(ref squares, i, u);
                        int fenceSides = GetFences2(AllFencesString);
                        int quicksum = area * fenceSides;
                        cost += quicksum;
                    }
                }
            }
            return cost;
        }

        static int GetFences2(string fences)
        {
            string[] split = fences.Split(' ');
            Array.Sort(split);
            split = ShrinkArrByLeading(split);

            Side[] side = new Side[split.Length];
            for(int i = 0; i < split.Length; i++)
            {
                side[i] = new Side();
                side[i].Direction = split[i][0];
                string renewed = ShortenLinkByLeadingOne(split[i]);
                string[] split2 = renewed.Split('|');
                side[i].Y = Int32.Parse(split2[0]);
                side[i].X = Int32.Parse(split2[1]);
            }

            //Check if values can be removed
            for(int i = 0; i < side.Length; i++)
            {
                for(int u = 0; u < side.Length; u++)
                {
                    if (u  < side.Length && side[i].Direction == side[u].Direction)
                    {
                        if (i != u && side[i].Y == side[u].Y && side[i].X + 1 == side[u].X && side[u].CombinedAndRemoved == false)
                        {
                            side[u].CombinedAndRemoved = true;
                        }
                        else if (i != u && side[i].X == side[u].X && side[i].Y + 1 == side[u].Y && side[u].CombinedAndRemoved == false)
                        {
                            side[u].CombinedAndRemoved = true;
                        }
                    }
                }
            }

            int sides = 0;
            for(int i = 0; i < side.Length; i++)
            {
                if (side[i].CombinedAndRemoved == false)
                {
                    sides++;
                }
            }
            return sides;
        }

        static int RecursiveArea(ref Square[,] squares, int positionY, int positionX)
        {
            int area = 1;
            squares[positionY, positionX].CheckedArea = true;

            if (positionY - 1 > -1 && squares[positionY - 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY - 1, positionX].CheckedArea == false)
            {
                area += RecursiveArea(ref squares, positionY - 1, positionX);
            }

            if (positionX + 1 < squares.GetLength(1) && squares[positionY, positionX + 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX + 1].CheckedArea == false)
            {
                area += RecursiveArea(ref squares, positionY, positionX + 1);
            }

            if (positionY + 1 < squares.GetLength(0) && squares[positionY + 1, positionX].Character == squares[positionY, positionX].Character && squares[positionY + 1, positionX].CheckedArea == false)
            {
                area += RecursiveArea(ref squares, positionY + 1, positionX);
            }

            if (positionX - 1 > -1 && squares[positionY, positionX - 1].Character == squares[positionY, positionX].Character && squares[positionY, positionX - 1].CheckedArea == false)
            {
                area += RecursiveArea(ref squares, positionY, positionX - 1);
            }

            return area;
        }

        static Square[,] ConvertInputToSquares(string[] input)
        {
            Square[,] squares = new Square[input.Length, input[0].Length];
            for(int i = 0; i < squares.GetLength(0); i++)
            {
                for(int u = 0; u < squares.GetLength(1); u++)
                {
                    squares[i, u] = new Square();
                    squares[i, u].Character = input[i][u];
                    squares[i, u].CheckedArea = false;
                    squares[i, u].CheckedFences = false;
                }
            }

            for (int i = 0; i < squares.GetLength(0); i++)
            {
                for (int u = 0; u < squares.GetLength(1); u++)
                {
                    //Check in all for directions for character matches
                    if(i - 1 > -1 && squares[i - 1,u].Character == squares[i,u].Character)
                    {
                        squares[i, u].Fence_Up = false;
                    }
                    else
                    {
                        squares[i, u].Fence_Up = true;
                    }

                    if(u + 1 < squares.GetLength(1) && squares[i, u + 1].Character == squares[i, u].Character)
                    {
                        squares[i, u].Fence_Right = false;
                    }
                    else
                    {
                        squares[i, u].Fence_Right = true;
                    }

                    if (i + 1 < squares.GetLength(0) && squares[i + 1, u].Character == squares[i, u].Character)
                    {
                        squares[i, u].Fence_Down = false;
                    }
                    else
                    {
                        squares[i, u].Fence_Down = true;
                    }

                    if(u - 1 > -1 && squares[i, u - 1].Character == squares[i, u].Character)
                    {
                        squares[i, u].Fence_Left = false;
                    }
                    else
                    {
                        squares[i, u].Fence_Left = true;
                    }
                }
            }

            return squares;
        }

        static string ShortenLinkByLeadingOne(string text)
        {
            string result = "";
            for(int i = 1; i < text.Length; i++)
            {
                result += Convert.ToString(text[i]);
            }
            return result;
        }

        static string[] ShrinkArrByLeading(string[] arr)
        {
            string[] newArr = new string[arr.Length - 1];
            for(int i = 1; i < arr.Length; i++)
            {
                newArr[i-1] = arr[i];
            }
            return newArr;
        }

        public class Square
        {
            public char Character;

            public bool Fence_Up;
            public bool Fence_Right;
            public bool Fence_Down;
            public bool Fence_Left;

            public bool CheckedArea;
            public bool CheckedFences;
        }

        public class Side
        {
            public char Direction;
            public int Y;
            public int X;
            public bool CombinedAndRemoved;
        }
    }
}
