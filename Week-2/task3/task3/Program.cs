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
                DirectoryInfo dir = new DirectoryInfo(@"C:\pp1");
                PrintInfo(dir, 0);
            }

            static void PrintInfo(FileSystemInfo fileSysInfo, int k)
            {
                string s = new string(' ', k);
                Console.WriteLine(s + fileSysInfo.Name);

                if (fileSysInfo.GetType() == typeof(DirectoryInfo))
                {
                    FileSystemInfo[] arr = ((DirectoryInfo)fileSysInfo).GetFileSystemInfos();
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        PrintInfo(arr[i], k + 6);
                    }
                }
                Console.ReadKey();
            }
        }
    }

        