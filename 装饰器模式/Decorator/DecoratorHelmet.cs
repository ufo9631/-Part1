using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 头盔装饰器
    /// </summary>
    public class DecoratorHelmet : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorHelmet(BaseCharacter character):base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
            Console.WriteLine("头盔装饰器...获得头盔");
        }
    }
}
