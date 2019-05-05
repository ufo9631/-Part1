using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式.Decorator
{
    /// <summary>
    /// 基础的装饰器
    /// </summary>
    public class BaseDecorator : BaseCharacter
    {
        private BaseCharacter _BaseCharacter = null;
        public BaseDecorator(BaseCharacter character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
        }
    }
}
