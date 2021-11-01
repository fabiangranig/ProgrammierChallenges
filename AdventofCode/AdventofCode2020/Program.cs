using System;
using System.IO;
using System.Linq;

namespace Advent_of_Code_2020
{
    class Program
    {
        //TODO: .txt ortsunabhängig machen

        static void Main(string[] args)
        {
            //Advent of Code Aufgaben
            //Schleife des Offenbleibens
            bool offenbleiben = true;
            while (offenbleiben == true)
            {
                //Eingabe der Aufgaben
                Console.Write("Gib ein welche Aufgabe du aufrufen möchtest: ");
                int welchechallenge = Convert.ToInt32(Console.ReadLine());

                //Leere Zeile
                Console.WriteLine(" ");

                //Checken welche Aufgabe gemeint ist
                if (welchechallenge == 1)
                {
                    Aufgabe1();
                }
                else
                {
                    if (welchechallenge == 2)
                    {
                        Aufgabe2();
                    }
                    else
                    {
                        if (welchechallenge == 3)
                        {
                            Aufgabe3();
                        }
                        else
                        {
                            if (welchechallenge == 4)
                            {
                                Aufgabe4();
                            }
                            else
                            {
                                if (welchechallenge == 5)
                                {
                                    //Teil auswählen
                                    Console.Write("Welchen Teil möchtest du berechnen (1/2)?");
                                    int welcheaufgabe = Convert.ToInt32(Console.ReadLine());

                                    if (welcheaufgabe == 1)
                                    {
                                        Aufgabe5();
                                    }
                                    else
                                    {
                                        if (welcheaufgabe == 2)
                                        {
                                            Aufgabe5_2();
                                        }
                                        else
                                        {
                                            //Nichts passiert
                                        }
                                    }
                                }
                                else
                                {
                                    if (welchechallenge == 6)
                                    {
                                        Aufgabe6();
                                    }
                                    else
                                    {
                                        //Nächste Aufgabe
                                    }
                                }
                            }
                        }
                    }
                }

                //Leere Zeile
                Console.WriteLine(" ");

                //Ob die Console offen bleibt
                Console.Write("Soll die Console offen bleiben (Ja / Nein)? ");
                string stringoffenbleiben = Convert.ToString(Console.ReadLine());
                if (stringoffenbleiben == "Nein" || stringoffenbleiben == "nein")
                {
                    offenbleiben = false;
                }
                else
                {
                    //Nichts passiert
                }
            }
        }

        static void Aufgabe1()
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge1_input.txt";
            string[] input = System.IO.File.ReadAllLines(path);

            //Part1 oder Part2
            Console.Write("Möchtest du Teil 1 oder Teil 2 aufrufen (1/2)? ");
            int welchenpart = Convert.ToInt32(Console.ReadLine());

            if (welchenpart == 1)
            {
                //Part One
                //In dieser Aufgabe geht es darum aus einer Zahlenliste die zwei Zahlen zu finden welche zusammen 2020 ergeben.
                for (int zaehler = 0; zaehler <= 199; zaehler++)
                {
                    for (int zaehler2 = 0; zaehler2 <= 199; zaehler2++)
                    {
                        int ergebnis = Int32.Parse(input[zaehler]) + Int32.Parse(input[zaehler2]);

                        if (ergebnis == 2020)
                        {
                            Console.WriteLine("Zahl1: {0}", input[zaehler]);
                            Console.WriteLine("Zahl2: {0}", input[zaehler2]);
                            int key = Int32.Parse(input[zaehler]) * Int32.Parse(input[zaehler2]);
                            Console.WriteLine("Key: {0}", key);

                            //Leere Zeile
                            Console.WriteLine("");
                        }
                        else
                        {
                            //Es passiert nichts
                        }
                    }
                }
            }
            else
            {
                if (welchenpart == 2)
                {
                    //Part Two
                    //In dieser Aufgabe geht es darum aus einer Zahlenliste die drei Zahlen zu finden welche zusammen 2020 ergeben.
                    for (int zaehler1 = 0; zaehler1 <= 199; zaehler1++)
                    {
                        for (int zaehler2 = 0; zaehler2 <= 199; zaehler2++)
                        {
                            for (int zaehler3 = 3; zaehler3 <= 199; zaehler3++)
                            {
                                int ergebnis = Int32.Parse(input[zaehler1]) + Int32.Parse(input[zaehler2]) + Int32.Parse(input[zaehler3]);

                                if (ergebnis == 2020)
                                {
                                    Console.WriteLine("Zahl 1: {0}", input[zaehler1]);
                                    Console.WriteLine("Zahl 2: {0}", input[zaehler2]);
                                    Console.WriteLine("Zahl 3: {0}", input[zaehler3]);

                                    //Key berechnen
                                    int key = Int32.Parse(input[zaehler1]) * Int32.Parse(input[zaehler2]) * Int32.Parse(input[zaehler3]);
                                    Console.WriteLine("Key: {0}", key);
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Aufgabe2()
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge2_input.txt";
            string[] input = System.IO.File.ReadAllLines(path);
            
            //Part auswählen
            Console.Write("Möchtest du Teil 1 oder 2 aufrufen (1/2)?");
            int welchenpart = Convert.ToInt32(Console.ReadLine());

            //Part 1
            //In der Aufgabe sollen Passwörter ausgegeben werden die richtig sind.
            //Sie müssen Sich in der Anzahl des jeweiligen Buchstaben liegen.
            if (welchenpart == 1)
            {
                int ergebnis = 0;
                for (int zaehler = 0; zaehler < input.Length; zaehler++)
                {
                    //In einen Zwischenspeicher umwandeln
                    string[] input_zwischenspeicher = input[zaehler].Split(" ");

                    //Einzelne Eigenschaften herausfinden
                    //Die richtige Anzahl von Buchstaben nehmen
                    string[] min_max_buchstaben = input_zwischenspeicher[0].Split("-");

                    //Den Buchstaben speichern
                    char gesuchter_buchstabe = input_zwischenspeicher[1][0];

                    //Zu kontrollierentes Wort
                    string passwort_zum_kontrollieren = input_zwischenspeicher[2];

                    //Kontrollieren
                    int wieviele_buchstaben_es_beinhaltet = 0;
                    for (int zaehler2 = 0; zaehler2 < passwort_zum_kontrollieren.Length; zaehler2++)
                    {
                        if (gesuchter_buchstabe == passwort_zum_kontrollieren[zaehler2])
                        {
                            wieviele_buchstaben_es_beinhaltet++;
                        }
                    }

                    if (wieviele_buchstaben_es_beinhaltet >= Int32.Parse(min_max_buchstaben[0]) == wieviele_buchstaben_es_beinhaltet <= Int32.Parse(min_max_buchstaben[1]))
                    {
                        ergebnis++;
                    }
                }

                //Ausgabe
                Console.WriteLine("Es gibt {0} Passwörter welche richtig sind.", ergebnis);
            }
            else
            {
                //Part 2
                //Diese Aufgabe verändert die Umständen.
                //Nun heißt es das man die Position des Buchtabens überprüfen muss
                if (welchenpart == 2)
                {
                    int ergebnis = 0;
                    for (int zaehler3 = 0; zaehler3 < input.Length; zaehler3++)
                    {
                        //In einen Zwischenspeicher umwandeln
                        string[] input_zwischenspeicher = input[zaehler3].Split(" ");

                        //Einzelne Eigenschaften herausfinden
                        //Die richtige Anzahl von Buchstaben nehmen
                        string[] min_max_buchstaben = input_zwischenspeicher[0].Split("-");

                        //Den Buchstaben speichern
                        char gesuchter_buchstabe = input_zwischenspeicher[1][0];

                        //Zu kontrollierentes Wort
                        string passwort_zum_kontrollieren = input_zwischenspeicher[2];

                        //Kontrollieren
                        if (passwort_zum_kontrollieren[Int32.Parse(min_max_buchstaben[0]) - 1] == gesuchter_buchstabe && passwort_zum_kontrollieren[Int32.Parse(min_max_buchstaben[1]) - 1] != gesuchter_buchstabe)
                        {
                            ergebnis++;
                        }

                        if (passwort_zum_kontrollieren[Int32.Parse(min_max_buchstaben[0]) - 1] != gesuchter_buchstabe && passwort_zum_kontrollieren[Int32.Parse(min_max_buchstaben[1]) - 1] == gesuchter_buchstabe)
                        {
                            ergebnis++;
                        }
                    }

                    //Ausgabe
                    Console.WriteLine("Es gibt {0} richtige Passwörter.", ergebnis);
                }
            }
        }

        static void Aufgabe3()
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge3_input.txt";
            string[] map = System.IO.File.ReadAllLines(path);
            
            //Auswählen welchen Teil der Aufgabe man ansehen möchte
            Console.Write("Welchen Teil der Aufgabe möchtest du ansehen (1/2)?");
            int welchenpart = Convert.ToInt32(Console.ReadLine());

            if (welchenpart == 1)
            {
                //Part 1
                //In dieser Aufgabe geht es darum herauszufinden in wie viele Bäume ein Flugzeug berührt wenn es durch die Map fliegt
                int x_position = 0;
                int y_position = 0;
                int moving_right = 3;
                int moving_down = 1;
                int ergebnis = 0;

                //Den gesuchten Buchstaben angeben
                char gesuchter_buchstabe = '#';

                //Berechnung
                for (int zaehler = 0; zaehler < map.Length - 1 / moving_down; zaehler++)
                {
                    x_position += moving_right;
                    y_position += moving_down;

                    if (x_position > map[0].Length - 1)
                    {
                        x_position -= map[0].Length;
                    }

                    if (map[y_position][x_position] == gesuchter_buchstabe)
                    {
                        ergebnis++;
                    }
                }

                //Ergebnis ausgeben
                Console.WriteLine("Das Ergebnis beträgt {0} Bäume.", ergebnis);
            }
            else
            {
                if (welchenpart == 2)
                {
                    //Mit diesem Programm werden verschiedene Flugrouten berechnet
                    double ergebnis1 = Flugzeug(1, 1);
                    double ergebnis2 = Flugzeug(3, 1);
                    double ergebnis3 = Flugzeug(5, 1);
                    double ergebnis4 = Flugzeug(7, 1);
                    double ergebnis5 = Flugzeug(1, 2);

                    Console.WriteLine(ergebnis1);
                    Console.WriteLine(ergebnis2);
                    Console.WriteLine(ergebnis3);
                    Console.WriteLine(ergebnis4);
                    Console.WriteLine(ergebnis5);

                    double entgültiges_ergebnis = ergebnis1 * ergebnis2 * ergebnis3 * ergebnis4 * ergebnis5;

                    Console.WriteLine("Das Ergebnis beträgt {0}.", entgültiges_ergebnis);
                }
            }
        }

        public static int Flugzeug(int moving_right, int moving_down)
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge3_input.txt";
            string[] map = System.IO.File.ReadAllLines(path);

            //Deklarierte Variablen
            int x_position = 0;
            int y_position = 0;
            int ergebnis = 0;
            int moving_down_ad = 0;

            //Wenn moving_down höher als 2 ist
            if (moving_down > 1)
            {
                moving_down_ad = 2;
            }

            //Den gesuchten Buchstaben angeben
            char gesuchter_buchstabe = '#';

            //Berechnung
            for (int zaehler = 0; zaehler < (map.Length / moving_down) - 1 - moving_down_ad; zaehler++)
            {
                x_position += moving_right;
                y_position += moving_down;

                if (x_position > map[0].Length - 1)
                {
                    x_position -= map[0].Length;
                }

                if (map[y_position][x_position] == gesuchter_buchstabe)
                {
                    ergebnis++;
                }
            }
            return ergebnis;
        }

        static void Aufgabe4()
        {
            //Eingabe der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge4_input.txt";
            string[] passports_map = System.IO.File.ReadAllLines(path);

            //Aufteilung der Passports
            int oben_letzte_zeile = 0;
            int unten_letzte_zeile = 0;
            int ergebnis1 = 0;
            int ergebnis2 = 0;

            //Berechnung
            for (int zaehler = 0; zaehler < passports_map.Length; zaehler++)
            {
                if (passports_map[zaehler] == "")
                {
                    unten_letzte_zeile = zaehler - 1;

                    string zeile = passports_map[oben_letzte_zeile];
                    for (int zaehler2 = oben_letzte_zeile + 1; zaehler2 <= unten_letzte_zeile; zaehler2++)
                    {
                        zeile += " " + passports_map[zaehler2];
                    }
                    oben_letzte_zeile = unten_letzte_zeile + 2;

                    if (zeile.Contains("byr") == true && zeile.Contains("iyr") == true && zeile.Contains("eyr") == true && zeile.Contains("hgt") == true && zeile.Contains("hcl") == true && zeile.Contains("ecl") == true && zeile.Contains("pid") == true)
                    {
                        ergebnis1++;
                    }

                    string[] passport_liste = zeile.Split(" ");

                    int byr = 0;
                    int iyr = 0;
                    int eyr = 0;
                    int hgt = 0;
                    int hcl = 0;
                    int ecl = 0;
                    int pid = 0;

                    if (passport_liste.Length == 7 || passport_liste.Length == 8)
                    {
                        for (int zaehler3 = 0; zaehler3 < passport_liste.Length; zaehler3++)
                        {
                            if (passport_liste[zaehler3].Contains("byr"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (Int32.Parse(aufgeteilt[1]) >= 1920 && Int32.Parse(aufgeteilt[1]) <= 2002)
                                {
                                    byr++;
                                }
                            }

                            if (passport_liste[zaehler3].Contains("iyr"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (Int32.Parse(aufgeteilt[1]) >= 2010 && Int32.Parse(aufgeteilt[1]) <= 2020)
                                {
                                    iyr++;
                                }
                            }

                            if (passport_liste[zaehler3].Contains("eyr"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (Int32.Parse(aufgeteilt[1]) >= 2020 && Int32.Parse(aufgeteilt[1]) <= 2030)
                                {
                                    eyr++;
                                }
                            }

                            if (passport_liste[zaehler3].Contains("hgt"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (aufgeteilt[1].Contains("cm"))
                                {
                                    string[] zwischenspeicher = aufgeteilt[1].Split("cm");
                                    
                                    if (Int32.Parse(zwischenspeicher[0]) >= 150 && Int32.Parse(zwischenspeicher[0]) <= 193)
                                    {
                                        hgt++;
                                    }
                                }

                                if (aufgeteilt[1].Contains("in"))
                                {
                                    string[] zwischenspeicher = aufgeteilt[1].Split("in");

                                    if (Int32.Parse(zwischenspeicher[0]) >= 59 && Int32.Parse(zwischenspeicher[0]) <= 76)
                                    {
                                        hgt++;
                                    }
                                }
                            }

                            if (passport_liste[zaehler3].Contains("hcl"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (aufgeteilt[1].Length == 7)
                                {
                                    hcl++;
                                }
                            }

                            if (passport_liste[zaehler3].Contains("ecl"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (aufgeteilt[1].Contains("amb") || aufgeteilt[1].Contains("blu") || aufgeteilt[1].Contains("brn") || aufgeteilt[1].Contains("gry") || aufgeteilt[1].Contains("grn") || aufgeteilt[1].Contains("hzl") || aufgeteilt[1].Contains("oth"))
                                {
                                    ecl++;
                                }
                            }

                            if (passport_liste[zaehler3].Contains("pid"))
                            {
                                string[] aufgeteilt = passport_liste[zaehler3].Split(":");

                                if (aufgeteilt[1].Length == 9)
                                {
                                    if (aufgeteilt[1][8] != 0)
                                    {
                                        pid++;
                                    }
                                }
                            }
                        }
                    }

                    if (byr == 1 && iyr == 1 && eyr == 1 && hgt == 1 && hcl == 1 && ecl == 1 && pid == 1)
                    {
                        ergebnis2++;
                    }
                }
            }

            //Ergebnis 1: Ausgabe
            Console.WriteLine("Das erste Ergebnis beträgt {0}.", ergebnis1);

            //Ergebnis 2: Ausgabe
            Console.WriteLine("Das zweite Ergebnis beträgt {0}.", ergebnis2);
        }

        static void Aufgabe5()
        {
            //Aufgabe 5 .txt einlesen
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge5_input.txt";
            string[] seats = System.IO.File.ReadAllLines(path);

            //Anfangswerte deklarieren
            double ergebnis = 0;
            double fertigesergebnis = 0;
            double vorneplatz = 0;
            double hintenplatz = 127;
            double linksplatz = 0;
            double rechtsplatz = 7;

            double zwischenspeichervorne = 0;
            double zwischenspeicherhinten = 0;

            double zwischenspeicherlinks = 0;
            double zwischenspeicherrechts = 0;

            double row = 0;
            double column = 0;

            int[] differenz = new int[10];
            differenz[0] = 64;
            differenz[1] = 32;
            differenz[2] = 16;
            differenz[3] = 8;
            differenz[4] = 4;
            differenz[5] = 2;
            differenz[6] = 1;

            differenz[7] = 4;
            differenz[8] = 2;
            differenz[9] = 1;

            //Alle Reihen durchgehen
            for (int zaehler = 0; zaehler < seats.Length; zaehler++)
            {
                //Berechnung der Reihe
                zwischenspeichervorne = vorneplatz;
                zwischenspeicherhinten = hintenplatz;
                zwischenspeicherlinks = linksplatz;
                zwischenspeicherrechts = rechtsplatz;
                for (int zaehler2 = 0; zaehler2 < seats[0].Length; zaehler2++)
                {
                    if (seats[zaehler][zaehler2] == 'F')
                    {
                        zwischenspeicherhinten -= differenz[zaehler2];

                        if (zaehler2 == 6)
                        {
                            row = zwischenspeicherhinten;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'B')
                    {
                        zwischenspeichervorne += differenz[zaehler2];

                        if (zaehler2 == 6)
                        {
                            row = zwischenspeichervorne;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'L')
                    {
                        zwischenspeicherrechts -= differenz[zaehler2];

                        if (zaehler2 == 9)
                        {
                            column = zwischenspeicherrechts;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'R')
                    {
                        zwischenspeicherlinks += differenz[zaehler2];

                        if (zaehler2 == 9)
                        {
                            column = zwischenspeicherlinks;
                        }
                    }
                }

                //Ergebnis berechnen
                ergebnis = row * 8 + column;

                if (ergebnis > fertigesergebnis)
                {
                    fertigesergebnis = ergebnis;
                }
            }
            
            //Ergebnis ausgeben
            Console.WriteLine("Das Ergebnis ist: {0}", fertigesergebnis);
        }

        static void Aufgabe5_2()
        {
            //Einlesen der 5.2 .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge5_input.txt";
            string[] seats = System.IO.File.ReadAllLines(path);

            //Anfängliche Variablen deklarieren
            double ergebnis = 0;
            double vorneplatz = 0;
            double hintenplatz = 127;
            double linksplatz = 0;
            double rechtsplatz = 7;

            double zwischenspeichervorne = 0;
            double zwischenspeicherhinten = 0;

            double zwischenspeicherlinks = 0;
            double zwischenspeicherrechts = 0;

            double row = 0;
            double column = 0;

            int[] differenz = new int[10];
            differenz[0] = 64;
            differenz[1] = 32;
            differenz[2] = 16;
            differenz[3] = 8;
            differenz[4] = 4;
            differenz[5] = 2;
            differenz[6] = 1;

            differenz[7] = 4;
            differenz[8] = 2;
            differenz[9] = 1;

            int[] sortarray = new int[seats.Length];

            //Alle Reihen durchgehen
            for (int zaehler = 0; zaehler < seats.Length; zaehler++)
            {
                //Berechnung der Reihe
                zwischenspeichervorne = vorneplatz;
                zwischenspeicherhinten = hintenplatz;
                zwischenspeicherlinks = linksplatz;
                zwischenspeicherrechts = rechtsplatz;
                for (int zaehler2 = 0; zaehler2 < seats[0].Length; zaehler2++)
                {
                    if (seats[zaehler][zaehler2] == 'F')
                    {
                        zwischenspeicherhinten -= differenz[zaehler2];

                        if (zaehler2 == 6)
                        {
                            row = zwischenspeicherhinten;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'B')
                    {
                        zwischenspeichervorne += differenz[zaehler2];

                        if (zaehler2 == 6)
                        {
                            row = zwischenspeichervorne;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'L')
                    {
                        zwischenspeicherrechts -= differenz[zaehler2];

                        if (zaehler2 == 9)
                        {
                            column = zwischenspeicherrechts;
                        }
                    }

                    if (seats[zaehler][zaehler2] == 'R')
                    {
                        zwischenspeicherlinks += differenz[zaehler2];

                        if (zaehler2 == 9)
                        {
                            column = zwischenspeicherlinks;
                        }
                    }
                }

                //Ergebnis berechnen
                ergebnis = row * 8 + column;

                sortarray[zaehler] = Convert.ToInt32(ergebnis);
            }

            //Array sotieren um dann zu checken wo der angegebene Wert sich befindet
            Array.Sort(sortarray);

            for (int zaehler40 = 0; zaehler40 < sortarray.Length; zaehler40++)
            {
                Console.WriteLine(zaehler40 + ". " + sortarray[zaehler40]);
            }

            for (int zaehler50 = 0; zaehler50 < sortarray.Length - 2; zaehler50++)
            {
                if (sortarray[zaehler50 + 1] - sortarray[zaehler50] == 2)
                {
                    Console.WriteLine(zaehler50);
                }
            }
        }

        static void Aufgabe6()
        {
            //Einlesen der 6 .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "challenge6_input.txt";
            string[] rows = System.IO.File.ReadAllLines(path);

            //Reihen seperarien
            int start = 0;
            int stop = 0;

            for (int zaehler = 0; zaehler < rows.Length; zaehler++)
            {
                string ergebnis = "";
                if (rows[zaehler] == rows[2])
                {
                    stop = zaehler - 1;

                    for (int zaehler2 = start; stop + 1 > zaehler2; zaehler2++)
                    {
                        if (zaehler2 <= 2172)
                        {
                            ergebnis += rows[zaehler2];
                        }

                        start = stop + 2;
                    }

                    //
                    Console.WriteLine(ergebnis);
                    string ergebnis2 = "";

                    for (int zaehler3 = 0; zaehler3 < ergebnis.Length; zaehler3++)
                    {
                        Console.WriteLine(ergebnis[zaehler3]);
                    }
                    //
                }
            }
        }
    }
}
