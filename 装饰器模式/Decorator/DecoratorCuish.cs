using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 腿甲装饰器
    /// </summary>
    public class DecoratorCuish : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorCuish(BaseCharacter character):base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
            Console.WriteLine("腿甲装饰器...获得腿甲");
        }
    }
}
