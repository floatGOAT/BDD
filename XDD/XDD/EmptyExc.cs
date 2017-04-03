using System;

namespace XDD
{
    public class QueuelsEmptyException : System.Exception
    {
        public QueuelsEmptyException(string msg)
        {
            Console.WriteLine(msg);
            throw new Exception(msg);
        }
    }
}