using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace XDD
{
    class Tests_qsort
    {
        public static string TestIn3()
        {
            int[] array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = new Random().Next(0, 1000);
            }
            Program.qsort(ref array, 0, array.Length - 1);
            bool ret = array[0] <= array[1] && array[1] <= array[2];
            Console.WriteLine(array[0] + " " + array[1] + " "+ array[2]);
            return ret ? "Тест на 3 числах пройден." : "Тест на 3 числах не пройден.";
        }

        public static string TestInSameNumbers()
        {
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = 42;
            }
            Program.qsort(ref array, 0, array.Length - 1);
            return AreWeRight(ref array) ? "Тест на одинаковых числах пройден." : "Тест на одинаковых числах не пройден.";
        }

        public static string TestIn1000()
        {
            bool Flag = true;
            int[] array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = new Random().Next(0, 10000);
            }
            for (int i = 0; i < 10; i++)
            {
                int A = new Random().Next(0, 999);
                int B = new Random().Next(0, 999);
                if (array[Math.Min(A, B)] > array[Math.Max(A, B)])
                    Flag = false;
            }
            Program.qsort(ref array, 0, array.Length - 1);
            return Flag ? "Тест на одинаковых числах пройден." : "Тест на одинаковых числах не пройден.";
        }

        public static string TestInEmptyArray()
        {
            int[] array = new int[0];
            Program.qsort(ref array, 0, array.Length - 1);
            return AreWeRight(ref array) ? "Тест в пустом массиве пройден." : "Тест в пустом массиве не пройден.";
        }

        public static string StressTest()
        {
            int SIZE = 1500000000;
            int[] array = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = new Random().Next();
            }
            Program.qsort(ref array, 0, array.Length - 1);
            return AreWeRight(ref array) ? "Стресс-тест пройден." : "Стресс-тест не пройден.";
        }

        private static bool AreWeRight(ref int[] array)
        {
            bool flag = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    flag = false;
            }
            return flag;
        }
    }
}
