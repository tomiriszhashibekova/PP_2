﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //converting string line written by keyboard to integer
            string parts = Console.ReadLine();// creating  string 

            string[] parts1 = new string[n]; // creating array of string 
            parts1 = parts.Split(); // divide array by space
            int[] arr = new int[n]; // creating array of integer with n elements
            int[] arr2 = new int[n * 2]; // creating array of integer with doudle n elements
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(parts1[i]);//converting string line written by keyboard to integer

            }


            for (int i = 0; i < n; i++)
            {
                arr2[i * 2] = arr[i];
                arr2[i * 2 + 1] = arr[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
