using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace 代理模式
{
    public class RealSubject: ISubject
    {
        public RealSubject()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("RealSubject被构造...");
        }

        public bool GetSomething()
        {
            Console.WriteLine("坐火车去火车站看看余票信息");
            Thread.Sleep(2000);
            Console.WriteLine("到火车站，看到有票");
            return true;
        }

        public void DoSomething()
        {
            Console.WriteLine("开始排队....");
            Thread.Sleep(2000);
            Console.WriteLine("终于买到票....");
        }
    }
}
