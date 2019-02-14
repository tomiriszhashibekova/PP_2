using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        
            static void Main(string[] args)
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\pp1"); // open the folder
                PrintInfo(dir, 0); //show content in folder
        }

            static void PrintInfo(FileSystemInfo fileSysInfo, int k)  //create the method which consider folder/file
            {
                string s = new string(' ', k);  //create string,where space repeat preset times 
            Console.WriteLine(s + fileSysInfo.Name); // output to the consol given string and folder/file

            if (fileSysInfo.GetType() == typeof(DirectoryInfo)) 
                {
                    FileSystemInfo[] arr = ((DirectoryInfo)fileSysInfo).GetFileSystemInfos(); //create method ,where add folder 
                    for (int i = 0; i < arr.Length; ++i) 
                    {
                        PrintInfo(arr[i], k + 6); // output folders with space number + 6 
                    }
                }
                Console.ReadKey();
            }
        }
    }

        