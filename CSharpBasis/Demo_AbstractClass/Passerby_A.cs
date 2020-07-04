using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasis.Demo_AbstractClass
{
    /*
     * 抽象方法在子类中重写
     */
    public class Passerby_A : BaseClass
    {
        public override bool Prostitute(int _money)      // 嫖（参数名称无所谓）
        {
            Console.WriteLine("Passerby_A can Prostitute!");
            return true;
        }

        public override void Gamble()                    // 赌
        {
            Console.WriteLine("Passerby_A can Gamble!");
        }
    }

    /*
     * 抽象类不能实例化，但仍然可以具有构造方法
     */
    public class Passerby_AA : BaseClass_Compare
    {
        /*
         * 先调用父类的构造函数，再走子类的构造函数
         */
        public Passerby_AA(bool value) : base(value)
        {
            // this.value = value;
        }
    }
}
