using System;

namespace XDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue mainQueue = new Queue();
            mainQueue.Push("Первая запись");
            mainQueue.Push("Вторая запись");
            mainQueue.Push("Третяя запись");
            Console.WriteLine(mainQueue.Pop().data);
            Console.WriteLine(mainQueue.Pop().data);
            Console.ReadKey();
        }
    }
}
