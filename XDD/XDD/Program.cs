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

            // Тест 1: Добавление трёх элементов, поиск трёх элементов
            if (Tests_HashTable.TestIn3(new HashTable()) == 0)
                Console.WriteLine("Тест на трёх элементах пройден.");
            else
                Console.WriteLine("Тест на трёх элементах не пройден.");
            
            // Тест 2: Добавление одного и того же ключа дважды с разными значениями сохраняет последнее добавленное значение
            if (Tests_HashTable.TestRepeatedKeys(new HashTable()) == 0)
                    Console.WriteLine("Тест с одинаковыми ключами пройден.");
            else
                Console.WriteLine("Тест с одинаковыми ключами не пройден.");

            // Тест 3: Добавление 10000 элементов в структуру и поиск одного из них
            if (Tests_HashTable.TestIn10000(new HashTable()) == 0)
                    Console.WriteLine("Тест на 10000 элементов пройден.");
            else
                Console.WriteLine("Тест на 10000 элементов не пройден.");

            // Тест 4: Добавление 10000 элементов в структуру и поиск 1000 недобавленных ключей, поиск которых должен вернуть null
            if (Tests_HashTable.TestAdd_unexisted(new HashTable()) == 0)
                    Console.WriteLine("Тест на 10000 элементов и поиске 1000 несуществующих пройден.");
            else
                Console.WriteLine("Тест на 10000 элементов и поиске 1000 несуществующих не пройден.");

            Console.ReadKey();
        }
    }
}
