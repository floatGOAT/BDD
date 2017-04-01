using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class HashTable
    {
        public HashTable()
        {
            table = new List<DTO>();
        }

        public void Add(DTO Entry)
        {
            foreach (var dto in table)
            {
                if (dto.key == Entry.key)
                {
                    dto.data = Entry.data;
                    return;
                }
            }
            table.Add(Entry);    
        }

        public string GetByKey(string Key)
        {
            foreach (var dto in table)
            {
                if (dto.key == Key)
                    return dto.data;
            }
            return null;
        }

        private List<DTO> table;
    }
}
