using System;
using System.IO;
using System.IO.Compression;

namespace Algorithmen_verstehen__Dezember_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(System.AppContext.BaseDirectory, @"..\..\..\"));
            string folderpath = path + "Start_Ordner5";
            string lastpath = folderpath;


            for (int i = 0; i < 496; i++)
            {
                folderpath += @"\" + Convert.ToString(i);
                Directory.CreateDirectory(folderpath);

                /*for (int i2 = 1000000; i2 < 5000000; i2++)
                {
                    if(i2 % 500000 == 0)
                    {
                        Console.WriteLine("Progress: " + i2 + " Folder: " + i);
                    }

                    if (File.Exists(lastpath + @"\" + i2 + ".zip"))
                    {
                        Console.WriteLine(i2);
                        ZipFile.ExtractToDirectory(lastpath + @"\" + i2 + ".zip", folderpath);
                        break;
                    }
                }*/

                if(i % 10 == 0)
                {
                    Console.WriteLine("Ordner: " + i);
                }

                if(i <= 494)
                {
                    string[] files = Directory.GetFiles(lastpath, "*.zip");
                    ZipFile.ExtractToDirectory(files[0], folderpath);
                }
                else
                {
                    string[] files = Directory.GetFiles(lastpath, "*.zip");
                    ZipFile.ExtractToDirectory(files[0], path + "Start_Ordner6");
                }

                lastpath = folderpath;
            }
        }
    }
}
