using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class Phonebook
    {
        public Phonebook()
        {
            book = new List<DTO>();
        }

        public void CommandLoop()
        {
            while (true)
            {
                Console.WriteLine("Введите команду:");
                string [] commands = Console.ReadLine().Split(' ');
                switch (commands[0])
                {
                    case "Добавить":
                        Add(commands[1], commands[2]);
                        break;
                    case "Найти":
                        Find(commands[1]);
                        break;
                    case "Удалить":
                        Delete(commands[1]);
                        break;
                    case "Выход":
                        return;
                    default:
                        throw new Exception("Неопознанная команда");
                }
            }
        }

        private void Add(string number, string fio)
        {
            book.Add(new DTO(number, fio));
        }

        private void Find(string arg)
        {
            foreach (var entry in book)
            {
                if (entry.GetFIO().Contains(arg) || entry.GetNumber().Contains(arg))
                    Console.WriteLine(entry.GetNumber() + " " + entry.GetFIO());
            }
        }

        private void Delete(string arg)
        {
            foreach (var entry in book)
            {
                if (entry.GetNumber() == arg || entry.GetFIO() == arg)
                {
                    book.Remove(entry);
                    break;
                }

            }
        }

        private List<DTO> book;
    }
}
