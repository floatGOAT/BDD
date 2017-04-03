using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace XDD
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue.Values = new List<object>();
            Tests_MyQueue.Once1000elements(new Queue());
            Tests_MyQueue.OneElement1000times(new Queue());
            
            Console.WriteLine("Завершение работы..."); // Epic story - epic string!
            Console.ReadKey();
        }
    }
}
