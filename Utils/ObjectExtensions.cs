using System;

namespace Utils
{
    public static class ObjectExtensions
    {
        public static void WriteLine(this object obj)
        {
            Console.WriteLine(obj);
        }

        public static void Write(this object obj)
        {
            Console.Write(obj);
        }
    }
}
