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
            /*HashTable MyTable = new HashTable();
            for (int i = 0; i < 3; i++)
            {
                MyTable.Add(new DTO(String.Format("{0}", i), String.Format("Запись номер {0}", i)));
            }
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine(MyTable.GetByKey(String.Format("{0}", i)));
            }*/
            switch (Tests_HashTable.TestIn3(new HashTable()))
            {
                case 0:
                    Console.WriteLine("Тест на трёх элементах пройден.");
                    break;
                case 1:
                    Console.WriteLine("Тест на трёх элементах не пройден.");
                    break;
                    break;
                default:
                    Console.WriteLine("WASTED!");
                    break;
            }
            switch (Tests_HashTable.TestRepeatedKeys(new HashTable()))
            {
                case 0:
                    Console.WriteLine("Тест с одинаковыми ключами пройден.");
                    break;
                case 1:
                    Console.WriteLine("Тест с одинаковыми ключами не пройден.");
                    break;
                default:
                    Console.WriteLine("WASTED!");
                    break;
            }
            switch (Tests_HashTable.TestIn10000(new HashTable()))
            {
                case 0:
                    Console.WriteLine("Тест на 10000 элементов пройден.");
                    break;
                case 1:
                    Console.WriteLine("Тест на 10000 элементов не пройден.");
                    break;
                default:
                    Console.WriteLine("WASTED!");
                    break;
            }
            switch (Tests_HashTable.TestAdd_unexisted(new HashTable()))
            {
                case 0:
                    Console.WriteLine("Тест на 10000 элементов и поиске 1000 несуществующих пройден.");
                    break;
                case 1:
                    Console.WriteLine("Тест на 10000 элементов и поиске 1000 несуществующих не пройден.");
                    break;
                default:
                    Console.WriteLine("WASTED!");
                    break;
            }

            System.Console.ReadKey();
        }
    }
}
