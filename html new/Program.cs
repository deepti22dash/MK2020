﻿using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square of number is: " + square);
            Console.ReadKey();
        }
    }
}
