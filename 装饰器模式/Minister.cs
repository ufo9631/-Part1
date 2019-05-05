using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    public class Minister : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("Minister....");
        }
    }

    public class MinisterWithHelmet : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("MinisterWithHelmet....");
        }
    }

    public class MinisterWithShoulder : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("MinisterWithShoulder....");
        }
    }
}
