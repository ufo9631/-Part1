using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try {
                ISubject realSubject = new RealSubject();
                realSubject.GetSomething();
                realSubject.DoSomething();

                /**************************************/
                ISubject proxySubject = new ProxySubject();
                proxySubject.GetSomething();
                proxySubject.DoSomething();

            }
            catch (Exception ex)
            { }
        }
    }
}
