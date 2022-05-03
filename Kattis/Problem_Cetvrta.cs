using System;

public class Program
{
    static int[] SearchHelp(int[,] points, int xy)
    {
        //Search for the x-Axis which connects to an point
        int[] sol = new Int32[2];
        for(int i = 0; i < 3; i++)
        {
            for(int i2 = 0; i2 < 3; i2++)
            {
                if(points[i, xy] == points[i2, xy] && i != i2)
                {
                    sol[0] = i;
                    sol[1] = i2;
                }
            }    
        }

        //Return the solution
        return sol;
    }

    static int Matches(int[] solx, int[] soly)
    {
        //Put the two arrays togheter
        int[] new_arr = new Int32[solx.Length + soly.Length];
        for(int i = 0; i < solx.Length; i++)
        {
            new_arr[i] = solx[i];
        }
        for(int i = 2; i < 4; i++)
        {
            new_arr[i] = soly[i-2];
        }

        //Get the number of which there are two
        for(int i = 0; i < new_arr.Length; i++)
        {
            for(int i2 = 0; i2 < new_arr.Length; i2++)
            {
                if(new_arr[i] == new_arr[i2] && i != i2)
                {
                    return new_arr[i2];
                }
            }
        }

        //Return if there is no solution the solution
        return -1;
    }

    static int[] Center(int[,] points)
    {
        //Get both the x and y Matches
        int[] solx = SearchHelp(points, 0);
        int[] soly = SearchHelp(points, 1);

        //Get the point which doesn't match from both arrays
        int no_match = Matches(solx, soly);

        //Return the solution
        int[] sol = new Int32[2];
        sol[0] = points[no_match, 0];
        sol[1] = points[no_match, 1];
        return sol;
    }

    static int Calculate(int[,] points, int[] point_center, int axes)
    {
        //Make an opposite axes
        int opposite_axes = axes;
        if(opposite_axes == 0)
        {
            opposite_axes = 1;
        }
        else
        {
            if(opposite_axes == 1)
            {
                opposite_axes = 0; 
            }
        }

        //Matchs another y-point
        for(int i = 0; i < 3; i++)
        {
            if(point_center[axes] == points[i, axes] && point_center[opposite_axes] != points[i, opposite_axes])
            {
                return points[i, opposite_axes];
            }
        }

        //Return if there is no solution
        return -1; 
    } 

    public static void Main()
    {
        //Get the input
        int[,] points = new Int32[3, 2];
        for(int i = 0; i < 3; i++)
        {
            string inp = Convert.ToString(Console.ReadLine());
            string[] u = inp.Split(" ");
            points[i, 0] = Int32.Parse(u[0]);
            points[i, 1] = Int32.Parse(u[1]);
        }

        //Calculate the point which is in the center
        int[] point_center = Center(points);

        //Get the solution
        int x = Calculate(points, point_center, 1);
        int y = Calculate(points, point_center, 0);
        
        //Output the solution
        Console.WriteLine(x + " " + y);
    }
}
