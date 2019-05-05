using System;
using 装饰器模式.Decorator;

namespace 装饰器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                //BaseCharacter mage = new Mage();
                //BaseDecorator decorator = new BaseDecorator(mage);
                //decorator.Show();


                /****************基础装饰器**************************/
                //BaseCharacter character = new Mage();
                //character = new BaseDecorator(character);
                //character.Show();


                /***********头盔装饰器************/
                //BaseCharacter character = new Mage();
                ///*////////BaseDecorator decorator = new BaseDecorator(character);
                //////////decorator = new DecoratorHelmet(character);
                //////////character.Show();*/

                //character = new BaseDecorator(character);
                //character = new DecoratorHelmet(character);
                //character.Show();

                /**********肩甲装饰器******************/

                BaseCharacter character = new Mage();
                character = new BaseDecorator(character);
                character = new DecoratorHelmet(character);
                character = new DecoratorShoulder(character);
                character = new DecoratorCuish(character);
                character = new DecoratorGlove(character);
                character = new DecoratorBreastplate(character);
                character.Show();

            }
            catch (Exception ex)
            {

            }
            Console.ReadKey();


        }
    }
}
