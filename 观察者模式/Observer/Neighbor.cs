using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Observer
{
    public class Neighbor : IObserver
    {
        public void Action()
        {
            this.Awake();
        }

        public void Awake()
        {
            Console.WriteLine("{0} Awake", this.GetType().Name);
        }
    }
}
