using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasis.Demo_AbstractClass
{
    /*
     * 抽象类功能：被其它类继承，代表一类对象所具有的公共属性或方法；
     *            我是老子（抽象类），你要是跟了（继承）老子，你就必须得会干老子的活，具体怎么干你说的算（具体实现）；
     * 抽象类特征：抽象类不能实例化，一个类中包含有抽象方法，那么这个类一定要声明为抽象类；
     *            抽象类可以包含抽象方法和抽象访问器，凡是包含抽象方法的类都是抽象类，此时，必须加abstract关键字；
     *            不能用sealed修饰符修饰，因为这两个修饰符的含义是相反的，sealed修饰符的类无法继承，而abstract修饰符要求对类进行继承；
     *            从抽象类派生的非抽象类必须包括继承的所有抽象方法和抽象访问器的实际实现；
     *            抽象类不能使用new关键字，不能被密封；
     */
    public abstract class BaseClass
    {
        public bool IsGentleman;

        /*
         * 普通方法；
         *     抽象类可以包含普通方法；
         *     普通方法只能在派生类的对象中去调用，不能直接实例化抽象类。抽象类不能被密封；
         */
        public void Eat()                       // 吃（都会，普通方法）
        {
            Console.WriteLine("Everybody can Eat!");
        }

        public void Drink()                     // 喝（都会，普通方法）
        {
            Console.WriteLine("Everybody can Drink!");
        }

        /*
         * 抽象方法：
         *     一定需要在子类中重写；
         *     必须为public或者protected（因为如果为private，则不能被子类继承，子类便无法实现该方法），缺省情况下默认为public；
         *     抽象方法也是虚拟的，但是不需要提供关键字virtual；在抽象方法声明中不能使用static或virtual修饰符；
         */
        public abstract bool Prostitute(int money);      // 嫖（因人而异，子类中实现）

        public abstract void Gamble();          // 赌（因人而异，子类中实现）
    }


    /*
     * 抽象类中不必非得包含抽象方法，此时向抽象类中添加的方法只能是静态方法
     */
    public abstract class BaseClass_Compare
    {
        public bool IsGentleman;

        /*
         * 抽象类不能实例化，但仍然可以具有构造方法
         */
        public BaseClass_Compare(bool _isGentleman)
        {
            IsGentleman = _isGentleman;
        }

        public static void Smoke()              // 抽
        {
            Console.WriteLine("Not Everybody can Smoke!");
        }
    }
}
