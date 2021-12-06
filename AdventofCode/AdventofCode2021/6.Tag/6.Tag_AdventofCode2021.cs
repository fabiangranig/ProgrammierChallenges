using System;
using System.IO;
using System.Collections.Generic;

namespace Advent_of_Code_Tag_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Results:
                Part 1
                621352 = too high
                362740 = right answer

                Part 2
                1644874076764 = right answer
             */

            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge_6_input_2021.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            //Number split at Komma
            numbers = numbers[0].Split(",");

            //Eingabe wieviele Tage simuliert werden sollen
            Console.Write("Gib die Anzahl der Tage ein: ");
            int tage = Convert.ToInt32(Console.ReadLine());

            //Mit einer for-Schleife alles in eine List einlesen
            List<Int32> Laternfish = new List<Int32>(numbers.Length+1);
            for(int i = 0; i < numbers.Length; i++)
            {
                Laternfish.Add(Convert.ToInt32(numbers[i]));
            }

            //In ein zweidimensionales Array umbauen für bessere Performence
            Int64[,] Laternfische_2dim = new Int64[2, 9];
            Laternfische_2dim[0, 0] = 0;
            Laternfische_2dim[0, 1] = 1;
            Laternfische_2dim[0, 2] = 2;
            Laternfische_2dim[0, 3] = 3;
            Laternfische_2dim[0, 4] = 4;
            Laternfische_2dim[0, 5] = 5;
            Laternfische_2dim[0, 6] = 6;
            Laternfische_2dim[0, 7] = 7;
            Laternfische_2dim[0, 8] = 8;

            Laternfische_2dim[1, 0] = 0;
            Laternfische_2dim[1, 1] = 0;
            Laternfische_2dim[1, 2] = 0;
            Laternfische_2dim[1, 3] = 0;
            Laternfische_2dim[1, 4] = 0;
            Laternfische_2dim[1, 5] = 0;
            Laternfische_2dim[1, 6] = 0;
            Laternfische_2dim[1, 7] = 0;
            Laternfische_2dim[1, 8] = 0;

            //Einlesen in das zweidimensionale Array
            for (int i = 0; i < Laternfish.Count; i++)
            {
                for(int i2 = 0; i2 < 9; i2++)
                {
                    if(Laternfische_2dim[0, i2] == Laternfish[i])
                    {
                        Laternfische_2dim[1, i2]++;
                    }
                }
            }

            //Mit einer for-Schleife Laternfish berechnen
            long Laternfisch_repro = 0;
            for (int i = 0; i < tage; i++)
            {
                Laternfisch_repro = 0;
                Laternfisch_repro = Laternfische_2dim[1, 0];
                Laternfische_2dim[1, 0] = 0;

                for(int i2 = 0; i2 < 8; i2++)
                {
                    Laternfische_2dim[1, i2] = Laternfische_2dim[1, i2 + 1];
                }

                Laternfische_2dim[1, 8] = 0;

                Laternfische_2dim[1, 6] += Laternfisch_repro;
                Laternfische_2dim[1, 8] += Laternfisch_repro;
            }

            //Berechnung der neuen Fische
            long summe = 0;
            for (int i = 0; i < 9; i++)
            {
                summe += Laternfische_2dim[1, i];
            }

            //Ergebnis ausgeben
            Console.WriteLine("Es werden in {0}.Tagen {1} Laternfische geboren.", tage, summe);
        }
    }
}
