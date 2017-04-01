using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    static class Tests_HashTable
    {
        public static int TestIn3(HashTable localTable)
        {
            for (int i = 0; i < 3; i++)
            {
                localTable.Add(new DTO(String.Format("{0}", i), String.Format("Запись номер {0}", i)));
            }
            bool ret = true;
            for (int i = 0; i < 3; i++)
            {
               ret = localTable.GetByKey(String.Format("{0}", i)) != null;
            }
            return ret ? 0 : 1;
        }
        public static int TestRepeatedKeys(HashTable localTable)
        {
            localTable.Add(new DTO("Ключ","Это первая запись"));
            localTable.Add(new DTO("Ключ", "Это вторая запись"));
            return localTable.GetByKey("Ключ") == "Это вторая запись" ? 0 : 1;
        }
        public static int TestIn10000(HashTable localTable)
        {
            for (int i = 0; i < 10000; i++)
            {
                localTable.Add(new DTO(String.Format("{0}", i), String.Format("Запись номер {0}", i)));
            }
            int randomIndex = new Random().Next(1, 9999);
            return localTable.GetByKey(String.Format("{0}", randomIndex)) == String.Format("Запись номер {0}", randomIndex) ? 0 : 1;
        }
        public static int TestAdd_unexisted(HashTable localTable)
        {
            for (int i = 0; i < 10000; i++)
            {
                localTable.Add(new DTO(String.Format("{0}", i), String.Format("Запись номер {0}", i)));
            }
            bool ret = true;
            for (int i = 10000; i < 11000; i++)
            {
                if (localTable.GetByKey(String.Format("{0}", i)) != null)
                {
                    ret = false;
                    break;
                }
            }
            return ret ? 0 : 1;
        }
    }
}
