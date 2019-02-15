using System;
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
        public DirectoryInfo[] DirectoryContent // для директория 
        {
            get;                                    // читает параметры, свойство 
            set;                                   // изменяет значения ,свойство
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
                Console.BackgroundColor = ConsoleColor.Red; // если куркос стоит на индексе, то цвет красный
            else
                Console.BackgroundColor = ConsoleColor.Black; // иначе цвет черный
        }
        public void Draw() // медот, который раюотает со цветами
        {
            Console.BackgroundColor = ConsoleColor.Black; // цвет фона 
            Console.Clear(); // обнавляет фон 
            for (int i = 0; i < DirectoryContent.Length; ++i)
            {
                SelectedColor(i); 
                Console.WriteLine((i + 1) + ". " + DirectoryContent[i].Name); // нумерация  индекса плюс один
            }
            Console.ForegroundColor = ConsoleColor.Yellow;  // желтый цвет обозначен желтым 
            for (int i = 0; i < FileContent.Length; ++i)
            {
                SelectedColor(i + DirectoryContent.Length); // что бы знать что по красить 
                Console.WriteLine((i + DirectoryContent.Length + 1) + ". " + FileContent[i].Name); // продолжить нумерацию кол-во файлов 
            }
            Console.ForegroundColor = ConsoleColor.White; // белый текст для папок
        }
    }
    class Program
    {
        static bool pathExists(string path, int mode) //Определяет, существует ли указанный файл
        {
            if ((mode == 1 && new DirectoryInfo(path).Exists) || (mode == 2 && new FileInfo(path).Exists))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\pp1"); // указываем путь
            if (!dir.Exists) // если файл не существует то выводится следуйщее сообщение 
            {
                Console.WriteLine("Directory not exist");
                return;
            }
            Layer l = new Layer // создается ноый слой, которому передаются ниже указынные параметры 
            {
                DirectoryContent = dir.GetDirectories() ,
                FileContent = dir.GetFiles(),
                SelectedIndex = 0
            };
            Stack<Layer> history = new Stack<Layer>(); // создает память пути 
            history.Push(l); // передаем все в слой 
            bool esc = false; // заводим булиновую переменную
            FSIMode curMode = FSIMode.DirectoryInfo;
            while (!esc) // пока не вышли 
            {
                if (curMode == FSIMode.DirectoryInfo) // создаем метод с параметрами
                {
                    history.Peek().Draw();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Delete: Del | Rename: F2 | Back: Backspace | Exit: Esc");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                ConsoleKeyInfo consolekeyInfo = Console.ReadKey();
                switch (consolekeyInfo.Key) // набор через клавиатуру 
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
                            using (FileStream fs = new FileStream(history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].FullName, FileMode.Open, FileAccess.Read))  // читаем фолдер по указанному пути 
                            {
                                using (StreamReader sr = new StreamReader(fs)) // делаем читабелным через СтримРидер
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                            }

                        }
                        break;
                    case ConsoleKey.Backspace: // через кнопку назад уходим на вверх
                        if (curMode == FSIMode.DirectoryInfo)
                        {
                            if (history.Count > 1)
                                history.Pop();
                        }
                        else
                        {
                            curMode = FSIMode.DirectoryInfo;
                            Console.ForegroundColor = ConsoleColor.White; //красим в тот же цвет 
                        }
                        break;
                    case ConsoleKey.Escape:
                        esc = true; //выходим из программы через буленувую функцию
                        break;
                    case ConsoleKey.Delete: // удаляет указанный файл или папку 
                        if (curMode != FSIMode.DirectoryInfo || (history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length) == 0)
                            break;
                        index = history.Peek().SelectedIndex;
                        int ind = index;
                        if (index < history.Peek().DirectoryContent.Length)
                            history.Peek().DirectoryContent[index].Delete(true); // папка удалится в любом случае
                        else
                            history.Peek().FileContent[index - history.Peek().DirectoryContent.Length].Delete();
                        int numofcontent = history.Peek().DirectoryContent.Length + history.Peek().FileContent.Length - 2;
                        history.Pop(); // история обнавляется 
                        if (history.Count == 0) // в случае когда истоиия == 0 
                        {
                            Layer nl = new Layer // новый слой с другими парметрами 
                            {
                                DirectoryContent = dir.GetDirectories(),
                                FileContent = dir.GetFiles(),
                                SelectedIndex = Math.Min(Math.Max(numofcontent, 0), ind)
                            };
                            history.Push(nl); // история обнавляется 
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
                    case ConsoleKey.F2: // переиминовка файла или папки
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
                        fullname = fullname.Remove(fullname.Length - name.Length); // прозьюа переиминовать после нажании F2
                        Console.WriteLine("Please enter the new name, to rename {0}:", name);
                        Console.WriteLine(fullname);
                        string newname = Console.ReadLine();
                        while (newname.Length == 0 || pathExists(fullname + newname, selectedMode))  // если названия reapit 
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
                            history.Push(nl); // обнавляется история
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
                    default: // в любом не понятном случае 
                        break;
                }

            }
        }
    }
}
