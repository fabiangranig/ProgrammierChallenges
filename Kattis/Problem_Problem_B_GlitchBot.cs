using System;

public class Program
{   
    //function which changes the direction
    static string Facing(string o, int c)
    {
        //Create array with all the items in it
        string[] d = new String[4];
        d[0] = "Up";
        d[1] = "Right";
        d[2] = "Down";
        d[3] = "Left";

        //Find the number to the position
        int n;
        for(int i = 0; i < d.Length; i++)
        {
            //Get the number
            if(d[i] == o)
            {
                n = i;
            }
        }

        //Position change
        n += c;
        
        //Reset when there is a border
        if(n > 3)
        {
            n = 0;
        }
        if(n < 0)
        {
            n = 3;
        }

        //Give back the direction
        return d[n];
    }
    
    //function to move forward
    static int[] Move_Forward(string dir, int pos_x, int pos_y)
    {
        if("Forward" == array[m])
        {
            if(dir == "Up")
            {
                pos_y++;
            }

            if(dir == "Down")
            {
                pos_y--;
            }
                
            if(dir == "Right")
            {
                pos_x++;
            }
                
            if(dir == "Left")
            {
                pos_x--;
            }

        //Put the pos into an array
        int[] array2 = new Int32[2];
        array2[0] = pos_x;
        array2[1] = pos_y;
        
        //Return the solution
        return array2;
    }

    //function to check if movement is correct
    public static int[] Movements(string[] array, int res_x, int res_y)
    {
        //Create variables in for-loop
        string dir  = "Up";
        int pos_x = 0;
        int pos_y = 0;
        for(int i = 0; i < array.Length; i++)
        {
            //Go through the array and move
            if("Forward" == array[i])
            {
                if(dir == "Up")
                {
                    pos_y++;
                }

                if(dir == "Down")
                {
                    pos_y--;
                }
                
                if(dir == "Right")
                {
                    pos_x++;
                }
                
                if(dir == "Left")
                {
                    pos_x--;
                }
            }

            if("Right" == array[i])
            {
                dir = Facing(dir, 1);
                int[] b = Move_Forward(dir, pos_x, pos_y);
                pos_x = b[0];
                pos_y = b[1];
            }

            if("Left" == array[i])
            {
                dir = Facing(dir, -1);
                int[] b = Move_Forward(dir, pos_x, pos_y);
                pos_x = b[0];
                pos_y = b[1];
            }
        }

        //Return the solution
        int[] v = new Int32[2];
        v[0] = pos_x;
        v[1] = pos_y;
        return v;
    }
    
    public static void Main()
    {
        //Get the result of the point
        string res = Convert.ToString(Console.WriteLine());
        string[] res2 = res.Split(" ");
        int res_x = Int32.Parse(res2[0]);
        int res_y = Int32.Parse(res2[1]);

        //Get how often the roboter moves
        int moves = Int32.Parse(Convert.ToString(Console.ReadLine()));

        //Get the directions
        string[] array = new String[moves];
        for(int i = 0; i < moves; i++)
        {
            //Read in the lines
            array[i] = Convert.ToString(Console.ReadLine());
        }

        //Display the cordinates
        int[] v = Movements(array, 1, 1);
        Console.WriteLine(v[0] + " " + v[1]); 
    }
}
