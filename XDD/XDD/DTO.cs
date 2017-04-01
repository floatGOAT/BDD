using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class DTO
    {
        public DTO(string Key, string Data)
        {
            key = Key;
            data = Data;
        }

        internal string key { get; set; }
        internal string data { get; set; }
    }
}
