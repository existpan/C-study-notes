# OOP中对象的创建-Construction method（构造方法）

- 方法-对象的行为即方法

- 构造方法在对象创建的时候被调用

1. 一个类中，当我们不显式写出任何构造方法时，编译器会默认生成一个无参数的构造方法，通过使用IL DASM工具查看中间语言。

2. 通过无参数的构造方法我们对属性进行初始化。

3. 使用构造方法的场景：
```c-sharp
public void Test()
{
//使用构造方法初始化创建对象；
  Water water=new Water();
}
```
