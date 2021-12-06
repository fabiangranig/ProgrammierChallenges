using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Tag3_AdevntofCode
{
    class Program
    {
        private static void D3P2()
        {
            //life support rating = oxygen rating * CO2 rating
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input_Tag3.txt";
            string[] binary = System.IO.File.ReadAllLines(path);
            string[] strInput = binary;
            //Most commong, 1>0
            List<string> o = strInput.ToList();
            //Least common, 0>1
            List<string> c = strInput.ToList();

            for (int i = 0; i < strInput[0].Length; i++)
            {
                if (o.Count != 1)
                {
                    int zeroCounter = 0;
                    int oneCounter = 0;
                    foreach (string str in o)
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                    char oType = (zeroCounter == oneCounter || oneCounter > zeroCounter) ? '1' : '0';
                    foreach (string str in o.ToList())
                    {
                        if (str[i] != oType)
                            o.Remove(str);
                    }
                }

                if (c.Count != 1)
                {
                    int zeroCounter = 0;
                    int oneCounter = 0;
                    foreach (string str in c)
                        _ = str[i] == '0' ? zeroCounter++ : oneCounter++;

                    char cType = (zeroCounter == oneCounter || oneCounter > zeroCounter) ? '0' : '1';
                    foreach (string str in c.ToList())
                    {
                        if (str[i] != cType)
                            c.Remove(str);
                    }
                }

                if (o.Count == 1 && c.Count == 1)
                    break;
            }

            Console.WriteLine("D3P2: " + Convert.ToInt32(o[0], 2) * Convert.ToInt32(c[0], 2));
        }

        static void Main(string[] args)
        {
            //Einlesen der .txt
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            path = path + "input_Tag3.txt";
            string[] binary = System.IO.File.ReadAllLines(path);

            //for
            int counter0 = 0;
            int counter1 = 0;
            string lower = "";
            string higher = "";
            for (int zaehler2 = 0; zaehler2 < binary[0].Length; zaehler2++)
            {
                for (int zaehler = 0; zaehler < binary.Length; zaehler++)
                {
                    if(binary[zaehler][zaehler2] == '0')
                    {
                        counter0++;
                    }

                    if(binary[zaehler][zaehler2] == '1')
                    {
                        counter1++;
                    }
                }

                if(counter0 > counter1)
                {
                    higher += "0";
                    lower += "1";
                }
                
                if(counter1 > counter0)
                {
                    higher += "1";
                    lower += "0";
                }


                counter0 = 0;
                counter1 = 0;
            }

            Console.WriteLine(higher);
            Console.WriteLine(lower);

            counter0 = 0;
            counter1 = 0;
            higher = Convert.ToString(higher[0]);
            for (int zaehler2 = 0; zaehler2 < binary[0].Length; zaehler2++)
            {
                for (int zaehler = 1; zaehler < binary.Length; zaehler++)
                {
                    if (binary[zaehler][zaehler2] == '0' && binary[zaehler].StartsWith(higher))
                    {
                        counter0++;
                    }

                    if (binary[zaehler][zaehler2] == '1' && binary[zaehler].StartsWith(higher))
                    {
                        counter1++;
                    }
                }

                if (counter0 > counter1)
                {
                    higher += "0";
                }

                if (counter1 > counter0)
                {
                    higher += "1";
                }

                if(counter1 == counter0)
                {
                    higher += "1";
                }
            }

            D3P2();
        }
    }
}
