﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter last number: ");
            int length = Int32.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= length; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine("{0:F3}", sum);
        }
    }
}
