using System;
using System.IO;

namespace Tag_4_Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "Advent_of_Code_Tag_4_Input.txt";
            string[] bingo = System.IO.File.ReadAllLines(path);

            //Abtrennen der Eingabe
            string[] solutions = bingo[0].Split(",");

            //Herausfinden wieviele Spaces es gibt
            int counter = 0;
            for(int i = 2; i < bingo.Length; i++)
            {
                if(bingo[i] == "")
                {
                    counter++;
                }
            }
            counter++;
            Console.WriteLine("Es gibt " + counter + ".Bingo Felder.");

            string[] bingo_line = new string[bingo.Length - 2];
            for(int i = 0; i < bingo_line.Length; i++)
            {
                bingo_line[i] = bingo[i + 2];
            }

            string[,,] bingo_felder = new string[counter, 5, 5];
            int bingo_feld_counter = 0;
            int bingo_line_counter = 0;
            for(int i = 0; i < bingo_line.GetLength(0); i++)
            {
                string[] save = bingo_line[i].Split(" ");

                switch(save.Length)
                {
                    case 1:
                        bingo_feld_counter++;
                        bingo_line_counter = 0;
                        break;
                    
                    case 5:
                        for (int i2 = 0; i2 < 5; i2++)
                        {
                            bingo_felder[bingo_feld_counter, bingo_line_counter, i2] = save[i2];
                        }
                        bingo_line_counter++;
                        break;

                    case 6:
                        for (int i2 = 0; i2 < 5; i2++)
                        {
                            bingo_felder[bingo_feld_counter, bingo_line_counter, i2] = save[i2+1];
                        }
                        bingo_line_counter++;
                        break;
                }
            }


            string solution_ausgabe = "";
            int checker_line = 0;
            int checker_column = 0;
            for (int i = 0; i < solutions.Length; i++)
            {
                for(int i2 = 0; i2 < bingo_felder.GetLength(0); i2++)
                {
                    for (int i3 = 0; i3 < bingo_felder.GetLength(1); i3++)
                    {
                        for (int i4 = 0; i4 < bingo_felder.GetLength(2); i4++)
                        {
                            if(solutions[i] == bingo_felder[i2,i3,i4])
                            {
                                bingo_felder[i2, i3, i4] = "*";
                            }
                        }
                    }
                }

                //Checker
                for (int i2 = 0; i2 < bingo_felder.GetLength(0); i2++)
                {
                    for (int i3 = 0; i3 < bingo_felder.GetLength(1); i3++)
                    {
                        checker_line = 0;
                        for (int i4 = 0; i4 < bingo_felder.GetLength(2); i4++)
                        {
                            if (bingo_felder[i2,i3,i4] == "*")
                            {
                                checker_line++;
                            }

                            if(checker_line == 5)
                            {
                                if(!solution_ausgabe.Contains(Convert.ToString(i2)))
                                {
                                    solution_ausgabe += i2 + " ";
                                }
                            }

                            if (solution_ausgabe.Contains("31"))
                            {
                                int test5 = 0;
                            }
                        }
                    }

                    for (int i3 = 0; i3 < bingo_felder.GetLength(1); i3++)
                    {
                        checker_column = 0;
                        for (int i4 = 0; i4 < bingo_felder.GetLength(2); i4++)
                        {
                            if (bingo_felder[i2, i4, i3] == "*")
                            {
                                checker_column++;
                            }

                            if (checker_column == 5)
                            {
                                if (!solution_ausgabe.Contains(Convert.ToString(i2)))
                                {
                                    solution_ausgabe += i2 + " ";
                                }

                                if (solution_ausgabe.Contains("31"))
                                {
                                    int test4 = 0;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(solution_ausgabe);

            //Test
            int test = 0;
        }
    }
}
