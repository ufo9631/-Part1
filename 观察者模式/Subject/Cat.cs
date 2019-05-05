using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式.Subject
{
    public class Cat
    {
        /// <summary>
        /// 事件起源
        /// baby   cry
        /// dog     wang
        /// father road
        /// </summary>
        public void Miao()
        {
            Console.WriteLine("{0} Miao 一声", this.GetType().Name);
        }

        private List<IObserver> _ObserversList = new List<IObserver>();


        public void AddObserver(IObserver observer)
        {
            this._ObserversList.Add(observer);
        }

        public void MiaoObserver()
        {
            Console.WriteLine("{0} Miao 一声", this.GetType().Name);
            //执行一些列操作
            foreach (IObserver item in _ObserversList)
            {
                item.Action();
            }
        }

        public event Action CatMiaoEvent;
        public void MiaoEvent()
        {
            Console.WriteLine("{0} MiaoEvent 一声", this.GetType().Name);
            //执行一些列操作
            if (CatMiaoEvent != null)
            {
                CatMiaoEvent();
            }
        }
    }
}
