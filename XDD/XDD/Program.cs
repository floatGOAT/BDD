using System;
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
            BinarySearch.SimpleTest();
            BinarySearch.TestNegativeNumbers();
            BinarySearch.TestNonExistentElement();
            BinarySearch.TestRepeatingNumbers();
            BinarySearch.TestEmptyArray();
            // BinarySearch.StressTest();

            Console.ReadKey();
        }
    }
}
