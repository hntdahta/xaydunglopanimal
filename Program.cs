﻿using System;

namespace xaydunglopanimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Animal a = new Animal();
            while (n >= 0)
            {
                n++;
                Console.WriteLine("Nhap ten dong vat: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap tieng keu dong vat: ");
                string sound = Console.ReadLine();
                Console.WriteLine(a.idNum);
                Console.WriteLine(name + " keu " + sound);
            }
        }
    }
}
