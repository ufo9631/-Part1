using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 胸甲装饰器
    /// </summary>
    public class DecoratorBreastplate : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorBreastplate(BaseCharacter character):base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
            Console.WriteLine("胸甲装饰器...获得胸甲");
        }
    }
}
