using System;

public class Program
{
    public static void Main()
    {
        string numbers = Convert.ToString(Console.ReadLine());
        Console.WriteLine(GetOperation(numbers));
    }

    //Finished output
    static string GetOperation(string textinput)
    {
        //Put the input into an array
        string[] arr = textinput.Split(" ");
        int[] input = new Int32[3];
        for(int i = 0; i < input.Length; i++)
        {
            input[i] = Int32.Parse(arr[i]);
        }

        //Plus
        string TestPlus = OperationPlus(input[0], input[1], input[2]);
        if(TestPlus != " ")
        {
            return input[0] + Convert.ToString(TestPlus[0]) + input[1] + Convert.ToString(TestPlus[1]) + input[2]; 
        }

        //Minus
        string TestMinus = OperationMinus(input[0], input[1], input[2]);
        if(TestMinus != " ")
        {
            return input[0] + Convert.ToString(TestMinus[0]) + input[1] + Convert.ToString(TestMinus[1]) + input[2]; 
        }

        //Mult
        string TestMult = OperationMult(input[0], input[1], input[2]);
        if(TestMult != " ")
        {
            return input[0] + Convert.ToString(TestMult[0]) + input[1] + Convert.ToString(TestMult[1]) + input[2]; 
        }

        //Divide
        string TestDivide = OperationDivide(input[0], input[1], input[2]);
        if(TestDivide != " ")
        {
            return input[0] + Convert.ToString(TestDivide[0]) + input[1] + Convert.ToString(TestDivide[1]) + input[2]; 
        }

        //If there was nothing found
        return "No possible";
    }

    //Calculate Plus
    static string OperationPlus(int a, int b, int c)
    {
        //Test both possible Methods
        if(a + b == c)
        {
            return "+=";
        }
        if(c + b == a)
        {
            return "=+";
        }

        //When nothing is right
        return " ";
    }

    
    //Calculate Minus
    static string OperationMinus(int a, int b, int c)
    {
        //Test both possible Methods
        if(a - b == c)
        {
            return "-=";
        }
        if(b - c == a)
        {
            return "=-";
        }

        //When nothing is right
        return " ";
    }


    //Calculate Mult
    static string OperationMult(int a, int b, int c)
    {
        //Test both possible Methods
        if(a * b == c)
        {
            return "*=";
        }
        if(c * b == a)
        {
            return "=*";
        }

        //When nothing is right
        return " ";
    }

    //Calculate Divide
    static string OperationDivide(int a, int b, int c)
    {
        //Test both possible Methods
        if(a / b == c)
        {
            return "/=";
        }
        if(b / c == a)
        {
            return "=/";
        }

        //When nothing is right
        return " ";
    }
}
