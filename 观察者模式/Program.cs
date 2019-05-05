using System;
using 观察者模式.Observer;
using 观察者模式.Subject;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {

                Cat cat = new Cat();

                cat.AddObserver(new Baby());
                cat.AddObserver(new Dog());
                cat.AddObserver(new Father());
                cat.AddObserver(new Mother());
                cat.AddObserver(new Mouse());
                cat.AddObserver(new Neighbor());

                cat.MiaoObserver();


                /***************************************/

                cat.CatMiaoEvent += new Mouse().Run;
                cat.CatMiaoEvent += new Baby().Cry;
                cat.CatMiaoEvent += new Dog().Wang;
                cat.CatMiaoEvent += new Father().Road;
                cat.CatMiaoEvent += new Mother().Whisper;
                cat.CatMiaoEvent += new Neighbor().Awake;
                cat.MiaoEvent();
            }
            catch (Exception ex)
            {

            }
            Console.ReadKey();
        }
    }
}
