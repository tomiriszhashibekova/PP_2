using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\Users\Ерлан\Desktop\tomi\copyThisfile.txt", FileMode.Create, FileAccess.Write); // create new file 
            StreamWriter sw = new StreamWriter(file); // Access to write 

            sw.Write("copy this line"); // in sw write text

            sw.Close(); 
            file.Close();
            string fileName = "copyThisfile.txt"; 
            string sourcePath = @"C:\Users\Ерлан\Desktop\tomi";
            string path2 = @"C:\Users\Ерлан\Desktop\tomi2";
            string sourceFile = Path.Combine(sourcePath, fileName); //Combines two strings into a path.
            string destFile = Path.Combine(path2, fileName); // Combines two strings into a path.
            File.Copy(sourceFile, destFile, true); // Copies an existing file to a new file. Overwriting a file of the same name is allowed.
            File.Delete(@"C:\Users\Ерлан\Desktop\tomi\copyThisfile.txt"); // delete original one

        }
    }
}
