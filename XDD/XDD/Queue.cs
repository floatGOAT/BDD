using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class Queue
    {
        public Queue()
        {
            Tail = new queue();
        }

        // -
        public void Push(string Data)
        {
            if (Tail == null)
            {
                Tail.data = Data;
                Tail.head = this.Tail;
            }
            else
            {
                queue newTail = new queue();
                newTail.data = Data;
                newTail.head = Tail.head;
                newTail.prev = Tail;
                Tail = newTail;
            }
        }

        //+
        public queue Pop()
        {
            queue ret = Tail.head;
            queue newHead = new queue();
            newHead.data = Tail.head.prev.data;
            newHead.prev = Tail.head.prev.prev;
            newHead.head = Tail.head;
            Tail.head = newHead;
            return Tail.head.head;
        }

        private queue Tail;
    }
}