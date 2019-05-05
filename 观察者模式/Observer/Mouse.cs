using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Observer
{
    public class Mouse : IObserver
    {
        public void Action()
        {
            this.Run();
        }

        public void Run()
        {
            Console.WriteLine("{0} run", this.GetType().Name);
        }
    }
}
