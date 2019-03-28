﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace color2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.CursorVisible = false;
                Thread green = new Thread(Green);
                green.Start();
                Thread.Sleep(500);
                Thread red = new Thread(Red);
                red.Start();
                Thread.Sleep(500);
                Thread blue = new Thread(Blue);
                blue.Start();
                Thread.Sleep(500);
                Thread yellow = new Thread(Yellow);
                yellow.Start();
                Thread.Sleep(500);
                Thread cyan = new Thread(Cyan);
                cyan.Start();
                Thread.Sleep(500);
                Thread magenta = new Thread(Magenta);
                magenta.Start();
                Thread.Sleep(500);
            }
        }
        public static void Magenta()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("Magenta!");

        }
        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("GREEN!");

        }
        public static void Red()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("RED!!");
        }
        public static void Blue()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("BLUE!");
        }
        public static void Yellow()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("YELLOW!");
        }
        public static void Cyan()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.SetCursorPosition(35, 11);
            Console.WriteLine("CYAN!");
        }
    }
}

