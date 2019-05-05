using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式
{
    /// <summary>
    /// 享元工厂
    /// </summary>
    public class FlyweightFactory
    {
        //private static BaseWord e1 = new E();
        //private static BaseWord l = new L();
        //private static BaseWord v = new V();
        //private static BaseWord n = new N();

        private static Dictionary<WordType, BaseWord> _baseWordDictionary = new Dictionary<WordType, BaseWord>();
        public static BaseWord GetWord(WordType wordType)
        {


            BaseWord baseWord = null;
            if (_baseWordDictionary.ContainsKey(wordType))
            {
                baseWord = _baseWordDictionary[wordType];
            }
            else
            {
                switch (wordType)
                {
                    case WordType.E:
                        baseWord = new E();
                        break;
                    case WordType.L:
                        baseWord = new L();
                        break;
                    case WordType.N:
                        baseWord = new N();
                        break;
                    case WordType.V:
                        baseWord = new V();
                        break;
                    default:
                        throw new Exception("类型错误");
                      
                }
                _baseWordDictionary.Add(wordType, baseWord);
            }

            return baseWord;
        }
    }

    public enum WordType
    {
        E,
        L,
        V,
        N
    }
}
