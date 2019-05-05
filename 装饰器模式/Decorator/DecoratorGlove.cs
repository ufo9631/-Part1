using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 手甲装饰器
    /// </summary>
    public class DecoratorGlove : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorGlove(BaseCharacter character):base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
            Console.WriteLine("手甲装饰器...获得手甲");
        }
    }
}
