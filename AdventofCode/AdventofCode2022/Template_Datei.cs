using System;
using System.IO;

namespace Template_Datei
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the input
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @""));
            path = path + "input.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

        }
    }
}
