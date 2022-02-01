using System;

public class Program
{
    public static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] split = line.Split(" ");
            int  a = Int32.Parse(split[0]); 
            int b = Int32.Parse(split[1]);
            Console.WriteLine(a + b);
        }
    }
}
