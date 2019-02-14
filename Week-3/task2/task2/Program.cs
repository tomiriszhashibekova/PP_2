﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    enum FSIMode
    {
        DirectoryInfo = 1, // Справочник
        File = 2
    }
    class Layer
    {
        public DirectoryInfo[] DirectoryContent
        {
            get;
            set;
        }
        public FileInfo[] FileContent
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get;
            set;
        }
        void SelectedColor(int i)
        {
            if (i == SelectedIndex)
                Console.BackgroundColor = ConsoleColor.Red;
            else
                Console.BackgroundColor = ConsoleColor.Black;
        }
        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < DirectoryContent.Length; ++i)
            {
                SelectedColor(i);
                Console.WriteLine((i + 1) + ". " + DirectoryContent[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < FileContent.Length; ++i)
            {
                SelectedColor(i + DirectoryContent.Length);
                Console.WriteLine((i + DirectoryContent.Length + 1) + ". " + FileContent[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static bool pathExists(string path, int mode)
        {
            if ((mode == 1 && new DirectoryInfo(path).Exists) || (mode == 2 && new FileInfo(path).Exists))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\test");
            if (!dir.Exists)
            {
                Console.WriteLine("Directory not exist");
                return;
            }
            Layer l = new Layer
            {
                DirectoryContent = dir.GetDirectories(),
                FileContent = dir.GetFiles(),
                SelectedIndex = 0
            };
            Stack<Layer> history = new Stack<Layer>();
            history.Push(l);
            bool esc = false;
            FSIMode curMode = FSIMode.DirectoryInfo;
            while (!esc)
            {
                if (curMode == FSIMode.DirectoryInfo)
                {
                    history.Peek().Draw();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Delete: Del | Rename: F4 | Back: Backspace | Exit: Esc");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ConsoleKeyInfo consolekeyInfo = Console.ReadKey();
                switch (consolekeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (history.Peek().SelectedIndex > 0)
                            history.Peek().SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 1 > history.Peek().SelectedIndex)
                            history.Peek().SelectedIndex++;
                        break;
                    case ConsoleKey.Enter:
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length == 0)
                            break;
                        int index = history.Peek().SelectedIndex;
                        if (index < history.Peek().DirectoryContent.Length)
                        {
                            DirectoryInfo d = history.Peek().DirectoryContent[index];
                            history.Push(new Layer
                            {
                                DirectoryContent = d.GetDirectories(),
                                FileContent = d.GetFiles(),
                                SelectedIndex = 0
                            });
                        }
                        else
                        {
                            curMode = FSIMode.File;
                            using (FileStream fs = new FileStream(history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                            }

                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (curMode == FSIMode.DirectoryInfo)
                        {
                            if (history.Count > 1)
                                history.Pop();
                        }
                        else
                        {
                            curMode = FSIMode.DirectoryInfo;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Escape:
                        esc = true;
                        break;
                    case ConsoleKey.Delete:
                        if (curMode != FSIMode.DirectoryInfo || (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length) == 0)
                            break;
                        index = history.Peek().SelectedIndex;
                        int ind = index;
                        if (index < history.Peek().DirectoryContent.Length)
                            history.Peek().DirectoryContent[index].Delete(true);
                        else
                            history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].Delete();
                        int numofcontent = history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 2;
                        history.Pop();
                        if (history.Count == 0)
                        {
                            Layer nl = new Layer
                            {
                                DirectoryContent = dir.GetDirectories(),
                                FileContent = dir.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        else
                        {
                            index = history.Peek().SelectedIndex;
                            DirectoryInfo di = history.Peek().DirectoryContent[index];
                            Layer nl = new Layer
                            {
                                DirectoryContent = di.GetDirectories(),
                                FileContent = di.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        break;
                    case ConsoleKey.F4:
                        if (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length == 0)
                            break;
                        index = history.Peek().SelectedIndex;
                        string name, fullname;
                        int selectedMode;
                        if (index < history.Peek().DirectoryContent.Length)
                        {
                            name = history.Peek().DirectoryContent[index].Name;
                            fullname = history.Peek().DirectoryContent[index].FullName;
                            selectedMode = 1;
                        }
                        else
                        {
                            name = history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].Name;
                            fullname = history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName;
                            selectedMode = 2;
                        }
                        fullname = fullname.Remove(fullname.Length - name.Length);
                        Console.WriteLine("Please enter the new name, to rename {0}:", name);
                        Console.WriteLine(fullname);
                        string newname = Console.ReadLine();
                        while (newname.Length == 0 || pathExists(fullname + newname, selectedMode))
                        {
                            Console.WriteLine("This directory was created, Enter the new one");
                            newname = Console.ReadLine();
                        }
                        Console.WriteLine(selectedMode);
                        if (selectedMode == 1)
                        {
                            new DirectoryInfo(history.Peek().DirectoryContent[index].FullName).MoveTo(fullname + newname);
                        }
                        else
                            new FileInfo(history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName).MoveTo(fullname + newname);
                        index = history.Peek().SelectedIndex;
                        ind = index;
                        numofcontent = history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 1;
                        history.Pop();
                        if (history.Count == 0)
                        {
                            Layer nl = new Layer
                            {
                                DirectoryContent = dir.GetDirectories(),
                                FileContent = dir.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        else
                        {
                            index = history.Peek().SelectedIndex;
                            DirectoryInfo di = history.Peek().DirectoryContent[index];
                            Layer nl = new Layer
                            {
                                DirectoryContent = di.GetDirectories(),
                                FileContent = di.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl);
                        }
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
