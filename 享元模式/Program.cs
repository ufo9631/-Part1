using System;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void Show()
        {
            BaseWord e1 = new E();
            BaseWord l = new L();
            BaseWord e2 = new E();
            BaseWord v = new V();
            BaseWord e3 = new E();
            BaseWord n = new N();
            Console.WriteLine("{0}{1}{2}{3}{4}{5}",
                e1.Display(),
                l.Display(),
                e2.Display(),
                v.Display(),
                e3.Display(),
                n.Display());
        }
    }
}
