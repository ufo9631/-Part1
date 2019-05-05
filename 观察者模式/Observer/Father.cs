using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Observer
{
 public   class Father : IObserver
    {
        public void Action()
        {
            this.Road();
        }

        public void Road()
        {
            Console.WriteLine("{0} Road", this.GetType().Name);
        }
    }
}
