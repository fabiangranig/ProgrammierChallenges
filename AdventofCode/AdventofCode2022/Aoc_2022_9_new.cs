using System;
using System.IO;
using System.Collections.Generic;

namespace Template_Datei
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }

        public void Output()
        {
            Console.WriteLine("(" + this.x + "/" + this.y + ")");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] directions = System.IO.File.ReadAllLines(path);
            
            //Set the start position
            Position Head = new Position(1, 1);
            Position Tail = new Position(1, 1);

            Position Head2 = new Position(1,1);
            Position[] Tail2 = new Position[9];

            //Fill up the Tail2 array
            for(int i = 0; i < Tail2.Length; i++)
            {
                Tail2[i] = new Position(1,1);
            }

            //List to check from
            List<string> total_moves = new List<string>();
            List<string> total_moves2 = new List<string>();

            //Move in the direction and show it onscreen
            for(int i = 0; i < directions.Length; i++)
            {
                //Check move order
                string[] split = directions[i].Split(" "); 
                for(int u = 0; u < Int32.Parse(split[1]); u++)
                {
                    //Get where the Head was before
                    Position temp = new Position(Head.x, Head.y);
                    Position temp2 = new Position(Head2.x, Head2.y);
                    
                    //Add positions to the head
                    if(directions[i][0] == 'R')
                    {
                        Head.x++;
                        Head2.x++;
                    }
                    if(directions[i][0] == 'L')
                    {
                        Head.x--;
                        Head2.x--;
                    }
                    if(directions[i][0] == 'U')
                    {
                        Head.y++;
                        Head2.y++;
                    }
                    if(directions[i][0] == 'D')
                    {
                        Head.y--;
                        Head2.y--;
                    }

                    Tail = newPosition(Head, Tail, temp);
                    Position temp3 = Tail2[0];
                    Tail2[0] = newPosition(Head2, Tail2[0], temp2);

                    //Compute Part2
                    Console.WriteLine("Head: " + Head2.x + " " + Head2.y);
                    Console.WriteLine("Tail0: " + Tail2[0].x + " " + Tail2[0].y);
                    for(int m = 1; m < Tail2.Length; m++)
                    {
                        Position te = Tail2[m];
                        Tail2[m] = newPosition(Tail2[m - 1], Tail2[m], temp3);
                        Console.WriteLine("Tail" + m + ": "  + Tail2[m].x + " " + Tail2[m].y);
                        temp3 = te;
                    }

                    //When needed add move to total_moves
                    bool contains = false;
                    string parser = Tail.x + "|" + Tail.y;
                    for(int z = 0; z < total_moves.Count; z++)
                    {
                        if(total_moves[z] == parser)
                        {
                            contains = true;
                        }
                    }

                    if(contains == false)
                    {
                        total_moves.Add(parser);
                    }
    
                    //When needed add move to total_moves
                    bool contains2 = false; 
                    string parser2 = Tail2[8].x + "|" + Tail2[8].y;
                    for(int z = 0; z < total_moves2.Count; z++)
                    {
                        if(total_moves2[z] == parser2)
                        {
                            contains2 = true;
                        }
                    }

                    if(contains2 == false)
                    {
                        total_moves2.Add(parser2);
                    }
                }
            }

            //Output the solution
            Console.WriteLine("The solution for the first part is: " + total_moves.Count);
            Console.WriteLine("The solution for the second part is: " + total_moves2.Count);
            for(int i = 0; i < total_moves2.Count; i++)
            {
                Console.WriteLine(total_moves2[i]);
            }
        }

        static Position newPosition(Position Head, Position Tail, Position temp)
        {
            int minus_x = Head.x - Tail.x;
            int minus_y = Head.y - Tail.y;

            if((minus_x >= -1 && minus_x <= 1) && (minus_y >= -1 && minus_y <= 1))
            {
            }
            else
            {
                return new Position(temp.x, temp.y);
            }

            //If everything is okey
            return Tail;
        }
    }
}
