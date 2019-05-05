using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 肩甲装饰器
    /// </summary>
    public class DecoratorShoulder : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorShoulder(BaseCharacter character):base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
            Console.WriteLine("肩甲装饰器...获得肩甲");
        }
    }
}
