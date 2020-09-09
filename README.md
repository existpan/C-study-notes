# OOP中对象的创建-Construction method（构造方法）

- 方法-对象的行为即方法

- 构造方法在对象创建的时候被调用

1. 一个类中，如果没有显式写出任何构造方法（包括带参数的）时，编译器会默认生成一个无参数的构造方法，通过使用IL DASM工具查看中间语言。

2. 构造方法有什么作用？

因为构造方法在对象创建的时候才被调用，所以使用构造方法我们可以使用构造方法完成一些初始化。
初始化举例：对象属性赋值，或从其他对象、文本等获取。

3. 构造方法类型：
- 无参数的构造方法：通常用来直接初始化对象的属性或不发生变化的数据。
```csharp
public void Test()
{
//使用构造方法初始化创建对象；
  Water water=new Water();
}
```
- 有参数的构造方法：让对象创建者，自己传递要初始化的数据。
