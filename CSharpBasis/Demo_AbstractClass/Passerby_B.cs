using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasis.Demo_AbstractClass
{
    /*
     * 如果一个类继承于一个抽象类，则子类必须实现父类的抽象方法；
     * 如果子类没有实现父类的抽象方法，则必须将子类也定义为abstract类；
     */
    public abstract class Passerby_B : BaseClass
    {
        public override bool Prostitute(int _money)      // 嫖（参数名称无所谓）
        {
            Console.WriteLine("Passerby_B can Prostitute!");
            return true;
        }
    }


    public class Passerby_B_Son : Passerby_B
    {
        public override bool Prostitute(int _money)      // 嫖（Passerby_B_Son不嫖了，继续重写）
        {
            Console.WriteLine("Passerby_B_Son can NOT Prostitute!");
            return false;
        }

        public override void Gamble()                    // 赌（BaseClass的子类的子类中具体实现）
        {
            Console.WriteLine("Passerby_B_Son can NOT Gamble!");
        }
    }
}
