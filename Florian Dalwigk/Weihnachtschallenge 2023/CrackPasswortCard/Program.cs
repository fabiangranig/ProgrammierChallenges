using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.Linq.Expressions;

namespace CrackPasswortCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File: weihnachten.zip
            string[] input1 = File.ReadAllLines("input1.txt");
            string[] input2 = File.ReadAllLines("input2.txt");
            string[] input3 = File.ReadAllLines("input3.txt");
            string[] input4 = File.ReadAllLines("input4.txt");
            string[] input5 = File.ReadAllLines("input5.txt");

            int i = 0;
            foreach (string l1 in input1)
            {
                foreach (string l2 in input2)
                {
                    foreach (string l3 in input3)
                    {
                        foreach (string l4 in input4)
                        {
                            foreach (string l5 in input5)
                            {
                                i++;
                                if(i % 1000 == 0)
                                {
                                    Console.WriteLine("Try: " + i);
                                }
                                OpenZipFile(l1 + l2 + l3 + l4 + l5);
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        static void OpenZipFile(string password)
        {
            using (ZipFile archive = new ZipFile("weihnachten.zip"))
            {
                archive.Password = password;
                archive.Encryption = EncryptionAlgorithm.PkzipWeak; // the default: you might need to select the proper value here
                //archive.StatusMessageTextWriter = Console.Out;

                try
                {
                    archive.ExtractAll(@"output\", ExtractExistingFileAction.Throw);
                    Console.WriteLine("Password did match!!!! -> " + password);
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    //Console.WriteLine("Password did not match. -> " + password);
                }
            }
        }
    }
}
