using System;

public class Program
{
    public static void Main()
    {
        string sol = "";
        while(1 == 1)
        {
            //Take room
            string input2 = Convert.ToString(Console.ReadLine());
            if(input2 == "0 0")
            {
                break;
            }
            
            string[] split = input2.Split(" ");
            int[] map = new Int32[]{Int32.Parse(split[0]) - 1,Int32.Parse(split[1]) - 1};

            //Get the how many commands
            int howmany = Convert.ToInt32(Console.ReadLine());

            //Execute the commands
            int[] noBorders = new Int32[]{0,0};
            int[] Borders = new Int32[]{0,0};
            for(int i = 0; i < howmany; i++)
            {
                string input3 = Convert.ToString(Console.ReadLine());
                string[] split2 = input3.Split(" ");
                noBorders = MoveRobotnoBorders(noBorders, split2[0], split2[1]);
                Borders = MoveRobotBorders(Borders, split2[0], split2[1], map);
            }
            sol +=  "Robot thinks " + noBorders[0] + " " + noBorders[1] + "\n" + "Actually at " + Borders[0] + " " + Borders[1] +"\n\n";
        }

        Console.WriteLine(sol);
    }

    static int[] execute_command(int pos_x, int pos_y, string command_type, int move)
    {
        if(command_type == "u")
        {
           pos_y += move;
        }
        if(command_type == "d")
        {
            pos_y -= move;
        }
        if(command_type == "l")
        {
            pos_x -= move;
        }
        if(command_type == "r")
        {
            pos_x += move;
        }
        return new Int32[]{pos_x, pos_y};
    }

    static int[] MoveRobotnoBorders(int[] position, string command_type, string command_length)
    {
        position = execute_command(position[0], position[1], command_type, Int32.Parse(command_length));
        return new Int32[]{position[0],position[1]};
    }


    static int[] MoveRobotBorders(int[] position, string command_type, string command_length, int[] map)
    {
        position = execute_command(position[0], position[1], command_type, Int32.Parse(command_length));
        
        //If length is not okey reset
        if(position[0] < 0)
        {
            position[0] = 0;
        }
        if(position[1] < 0)
        {
            position[1] = 0;
        }
        if(position[0] > map[0])
        {
            position[0] = map[0];
        }
        if(position[1] > map[1])
        {
            position[1] = map[1];
        }

        return new Int32[]{position[0],position[1]};
    }
}
