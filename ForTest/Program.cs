﻿using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{random.Next(0, 200)}");
            }
        }
    }
}
