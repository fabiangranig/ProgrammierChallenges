using System;
using System.IO;
using System.Collections.Generic;

namespace Template_Datei
{
    class Position
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

            //List to check from
            List<string> total_moves = new List<string>();

            //Move in the direction and show it onscreen
            for(int i = 0; i < directions.Length; i++)
            {
                //Check move order
                Console.WriteLine(i + ".Run: " + directions[i]);
                string[] split = directions[i].Split(" "); 
                for(int u = 0; u < Int32.Parse(split[1]); u++)
                {
                    //Calculate the difference
                    int minus_x = Head.x - Tail.x;
                    int minus_y = Head.y - Tail.y;     
        
                    //Output the Head and Tail
                    Console.Write("Head: ");
                    Head.Output();
                    Console.Write("Tail: ");
                    Tail.Output();

                    //Get the last position of the Head
                    Position temp = new Position(Head.x, Head.y);
                    Console.WriteLine("Temp: " + temp.x + " " + temp.y);

                    //Add positions to the head
                    if(directions[i][0] == 'R')
                    {
                        Head.x++;
                    }
                    if(directions[i][0] == 'L')
                    {
                        Head.x--;
                    }
                    if(directions[i][0] == 'U')
                    {
                        Head.y++;;
                    }
                    if(directions[i][0] == 'D')
                    {
                        Head.y--;
                    }

                    minus_x = Head.x - Tail.x;
                    minus_y = Head.y - Tail.y;

                    if((minus_x >= -1 && minus_x <= 1) && (minus_y >= -1 && minus_y <= 1))
                    {
                    }
                    else
                    {
                        Tail = new Position(temp.x, temp.y);
                        Console.WriteLine("new Tail: " + Tail.x + " " + Tail.y);
                    }

                    //Output the Head and the Tail
                    Console.Write("Head: ");
                    Head.Output();
                    Console.Write("Tail: ");
                    Tail.Output();

                    minus_x = Head.x - Tail.x;
                    minus_y = Head.y - Tail.y;

                    if((minus_x >= -1 && minus_x <= 1) && (minus_y >= -1 && minus_y <= 1))
                    {
                        Console.WriteLine("in Reach");
                    }
                    else
                    {
                        Console.WriteLine("not in reach");
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
                    
                    //New line
                    Console.WriteLine();  
                }
            }

            //Output the solution
            Console.WriteLine("The solution for the first part is: " + total_moves.Count);
        }
    }
}
