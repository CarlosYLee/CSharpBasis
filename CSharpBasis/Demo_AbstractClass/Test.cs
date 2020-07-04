using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasis.Demo_AbstractClass
{
    class Test
    {
        // Test Program
        public static void Demo_AbstractClass_Test()
        {
            // 1. Passerby_A
            Console.WriteLine("**************Passerby_A**************");
            Passerby_A passerby_A = new Passerby_A();
            passerby_A.Eat();
            passerby_A.Drink();
            passerby_A.Prostitute(1000);
            passerby_A.Gamble();
            Console.WriteLine(passerby_A.IsGentleman);
            passerby_A.IsGentleman = true;
            Console.WriteLine(passerby_A.IsGentleman);

            // 2. Passerby_AA
            Console.WriteLine("**************Passerby_AA*************");
            Passerby_AA passerby_AA = new Passerby_AA(true);
            Console.WriteLine(passerby_AA.IsGentleman);
            passerby_AA.IsGentleman = false;
            Console.WriteLine(passerby_AA.IsGentleman);
            BaseClass_Compare.Smoke();    // static方法直接调用，不能创建实例调用

            // 3. Passerby_B_Son
            Console.WriteLine("************Passerby_B_Son************");
            Passerby_B_Son passerby_B_Son = new Passerby_B_Son();
            passerby_B_Son.Eat();
            passerby_B_Son.Drink();
            passerby_B_Son.Prostitute(1000);
            passerby_B_Son.Gamble();
            Console.WriteLine(passerby_B_Son.IsGentleman);
            passerby_B_Son.IsGentleman = true;
            Console.WriteLine(passerby_B_Son.IsGentleman);

            // 4. Two Passerby_A Compare
            Console.WriteLine("************Two Passerby_A************");
            Passerby_A passerby_A_1 = new Passerby_A();
            Passerby_A passerby_A_2 = new Passerby_A();
            passerby_A_1.IsGentleman = true;
            passerby_A_2.IsGentleman = false;
            Console.WriteLine(passerby_A_1.IsGentleman);
            Console.WriteLine(passerby_A_2.IsGentleman);
        }
    }
}
