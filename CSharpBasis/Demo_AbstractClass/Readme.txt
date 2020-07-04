
抽象类与一般类、接口的异同：

1.  抽象类和一般类
    相同点：都可以继承其他的类或者接口，也可以派生子类，并且都有具体的方法；
    不同点：抽象类中有抽象方法，一般类中没有；抽象类不可以实例化，一般类却可以；

2.  抽象类和接口
    相同点：都不能实例化，继承抽象类的子类必须实现抽象类中的抽象方法，实现接口的子类必须实现接口中的全部方法和属性；
    不同点：抽象类中除了具有抽象方法之外，还有具体的方法；
           派生类只能继承一个基类，即只能继承一个抽象类，但是可以继承多个接口；
           抽象类可以定义成员的实现，包含字段、构造函数、析构函数、静态成员或常量，接口中不可以；
           抽象类中的成员可以私有的(只要不是抽象的)、受保护的、内部的或受保护的内部成员，但接口中的成员必须是公共的
           
3.  抽象类与一般类、接口代码表示
    抽象类：abstract class class_abstract_name；
    一般类：class class_name;
    接口：interface interface_name;
    抽象方法：abstract public void test();或者public abstract void test();            // 抽象方法中必须使用public修饰符
    一般方法：public/private/protected/.. void/string/int/... method_name();
    父类中的虚拟方法：public virtual void test_1();或者virtual public void test_1();   // 虚拟方法必须使用public修饰符
    子类中实现父类的虚拟方法或抽象方法：public override void test_1();或者override public void test_1();

4. 密封类
    密封类是指用sealed关键字定义的类，密封方法是指用sealed关键字定义的方法，如果比希望类被继承或者方法被再重写，则将类或方法定义为密封的即可