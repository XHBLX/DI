using System;
using DI.Properties;

namespace DI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Engineer e = new Engineer();
            Console.WriteLine((e.getName() == null));
        }
    }
}
