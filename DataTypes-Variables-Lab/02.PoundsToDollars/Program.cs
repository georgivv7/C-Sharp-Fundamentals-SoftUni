﻿using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal pounds = dollars * 1.31M;
            Console.WriteLine($"{pounds:f3}");
        }
    }
}
