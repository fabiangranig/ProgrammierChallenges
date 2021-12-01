using System;
using System.IO;

namespace AdventofCode_Tag1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ausgabe "erstes  Beispiel"
            Console.WriteLine("Das ist das erste Beispiel");

            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge_1_input_2021.txt";
            string[] numbers = System.IO.File.ReadAllLines(path);

            //Berechnung
            int zaehler_increase = 0;
            int speicher = 9999;
            
            //Mithilfe der for-Schleife durchgehen und hochzählen wenn der Wert größer geworden ist
            for(int zaehler = 0; zaehler < numbers.Length; zaehler++)
            {
                //Bedingung
                if(Int32.Parse(numbers[zaehler]) > speicher)
                {
                    zaehler_increase++;
                }

                //Den neuen Wert abspeichern
                speicher = Int32.Parse(numbers[zaehler]);
            }

            //Ausagebe des Ergebnisses
            Console.WriteLine("Die Erhöhung hat {0}.Mal stattgefunden.", zaehler_increase);

            //Leere Zeile
            Console.WriteLine(" ");

            //Ausgabe "zweite Beispiel"
            Console.WriteLine("Das ist das zweite Beispiel");

            //Die Variablen zurücksetzen
            zaehler_increase = 0;
            speicher = 9999;
            int summe = 0;

            //Mithilfe von for-Schleifen summieren und durchgehen
            for(int zaehler = 0; zaehler < numbers.Length; zaehler++)
            {
                //Wenn zu wenig Werte sind bricht die Schleife ab
                if (zaehler + 3 > 2000)
                {
                    break;
                }

                //Summiert die nächsten 3 Werte
                for (int zaehler2 = 0; zaehler2 < 3; zaehler2++)
                {
                    summe += Int32.Parse(numbers[zaehler + zaehler2]);
                }

                //Erhöht die Anzahl wenn die Zahl größer ist
                if(summe > speicher)
                {
                    zaehler_increase++;
                }

                //Die Werte zurücksetzen/umsetzen
                speicher = summe;
                summe = 0;
            }

            //Ausgabe Ergebnis
            Console.WriteLine("Mit der neuen Berechnung beträgt die Steigung: " + zaehler_increase);
        }
    }
}
