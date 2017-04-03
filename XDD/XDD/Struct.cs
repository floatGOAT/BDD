using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    public class queue
    {
        public queue()
        {
            data = String.Empty;
            head = this;
            prev = this;
        }

        internal queue head;
        internal string data { get; set; }
        internal queue prev;
    }
}
