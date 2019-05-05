using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    public abstract class BaseWord
    {
        public int Id { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public abstract string Display();
    }
}
