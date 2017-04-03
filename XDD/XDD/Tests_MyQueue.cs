using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XDD
{
    class Tests_MyQueue
    {
        public static void Once1000elements(System.Collections.Queue localQueue)
        {
            bool correctResult = true;
            for (int i = 999; i >= 0; i--)
            {
                localQueue.MyEnqueue(i);
                if (!localQueue.CurrentMinimum().Equals(i))
                    correctResult = false;
            }
            for (int i = 999; i >= 0; i--)
            {
                if (!localQueue.CurrentMinimum().Equals(0)) // 0, because LI element is 0 and it should be LO
                    correctResult = false;
                localQueue.MyDequeue();
            }
            if (correctResult)
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine("Тест на добавление и удаление 1000 элементов не пройден");
        }

        public static void OneElement1000times(System.Collections.Queue localQueue)
        {
            bool correctResult = true;
            for (int i = 0; i < 1000; i++)
            {
                int RandomEnqueueMember = new Random().Next();
                localQueue.MyEnqueue(RandomEnqueueMember);
                if (!localQueue.CurrentMinimum().Equals(RandomEnqueueMember))
                    correctResult = false;
                localQueue.MyDequeue();
            }
            if (correctResult)
                Console.WriteLine("Тест на добавление и удаление элемента 1000 раз пройден");
            else
                Console.WriteLine("Тест на добавление и удаление элемента 1000 раз не пройден");
        }
    }
}
