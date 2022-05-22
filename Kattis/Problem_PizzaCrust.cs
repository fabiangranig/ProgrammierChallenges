using System;

public class Program
{
    public static void Main()
    {
        //Get the input line
        string input = Convert.ToString(Console.ReadLine());

        //Split that line
        string[] split = input.Split(" ");

        //Convert both values to an double
        double full_pizza = Convert.ToDouble(split[0]);
        double crust = Convert.ToDouble(split[1]);

        //Calculate the Full Pizza and the crust
        double cheese = full_pizza - crust;

        //Calculate the cheese part
        cheese = Math.Pow(cheese, 2) * Math.PI;

        //Calculate the pizza part
        full_pizza = Math.Pow(full_pizza, 2) * Math.PI;

        //Calculate the solution
        double solution = cheese / full_pizza * 100;

        //Output the solution
        Console.WriteLine(solution);
    }
}
