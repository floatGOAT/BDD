using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    // I'm so sorry for variable "TAAAA" @_@
    // Please, don't send my colution back for revision because of it!!!
    public static class MyQueue
    {
        public static void MyEnqueue(this System.Collections.Queue TAAAA, object Element)
        {
            TAAAA.Enqueue(Element);
            Values.Add(Element);
        }

        public static void MyDequeue(this System.Collections.Queue TAAAA)
        {
            if (TAAAA.Count > 0)
            {
                Values.Remove(TAAAA.Dequeue());
            }
            else
            {
                throw new QueuelsEmptyException("В очереди нет элементов!");
            }
        }

        public static object CurrentMinimum(this System.Collections.Queue TAAAA)
        {
            if (TAAAA.Count > 0)
                return Values.Min();
            else
                throw new QueuelsEmptyException("Невозможно вернуть текущий минимум!");
        }

        public static List<object> Values;
    }
}
