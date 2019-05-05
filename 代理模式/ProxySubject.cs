using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace 代理模式
{
    public class ProxySubject : ISubject
    {
        private ISubject proxySubject = new RealSubject();

        private static int GetSomethingResult = 0;

        public bool GetSomething()
        {
           
            if (GetSomethingResult.Equals(0))
            {
                bool result = proxySubject.GetSomething();
                GetSomethingResult = result ? 1 : -1;
            }
            //代理模式 增加日志 。。。。。。。。。。
            return GetSomethingResult == 1;
        }

        public void DoSomething()
        {
            proxySubject.DoSomething();
        }
    }
}
