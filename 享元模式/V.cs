using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace 享元模式
{
    public class V : BaseWord
    {
        public V()
        {
            Thread.Sleep(1000);
            Console.WriteLine("字符V被构造");
        }
        public override string Display()
        {
            return "V";
        }
    }
}
