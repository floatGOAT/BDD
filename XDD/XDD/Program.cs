﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook Book = new Phonebook();
            Book.CommandLoop();
            Console.WriteLine("Завершение работы...");
            Console.ReadKey();
        }
    }
}
