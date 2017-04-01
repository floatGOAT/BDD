using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class DTO
    {
        internal DTO(string Number, string fio)
        {
            number = Number;
            FIO = fio;
        }

        public string GetNumber()
        {
            return number;
        }
        public string GetFIO()
        {
            return FIO;
        }

        private string number { get; set; }
        private string FIO { get; set; }
    }
}
