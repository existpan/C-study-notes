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

4. 实例：

```csharp
namespace ClassCourse
{
    public class Course
    {
        public int Courseid;
        public string CourseName;
        public string showinfo()
        {
            string info = string.Format($"{Courseid}+{CourseName}");
            return info;
        }
        //public Course() {
        //此处声明发生在整个对象中没有显式声明任何一个构造函数时 
        //系统会默认生成 由于在下面显式声明了构造函数故注释掉此段代码
        //}

        //这里是一段带参数的构造方法，使用这个构造方法进行参数传递
        public Course(int courseid, string coursename)
        {
            this.Courseid = courseid;
            this.CourseName = coursename;
            //此处的this关键字指向对象Course
        }

        //由于在上面显式声明了构造函数 所以这里也要显式声明不带参数的构造函数
        public Course()
        {
            //构造函数功能体现 使用无参构造对属性进行初始化
            Courseid = 10;
            CourseName = "量子力学";
        }
    }
    class ShowCourse
    {
        public string showcourseinfo()
        {
            Course course = new Course();
            course.CourseName = "1111";
            return course.showinfo();
        }
    }
}
```
5. 关于对象初始化器
- C#3.0时代引入
作用：更加灵活的初始化对象的“属性”。

# 对象封装容器之泛型集合list和Dictionary的使用
1. 泛型List元素添加、删除、遍历和快速查询的常用方法
- 声明对象
```csharp
    public class Course
    {
        public Course() { }
        public Course(int courseid,string coursename, int classhour,string teachername)
        {
            //this关键字指向Course对象本身
            this.CourseId = courseid;
            this.CourseName = coursename;
            this.ClassHour = classhour;
            this.TeacherName = teachername;
        }
        public int CourseId { get; set; }//课程编号
        public string CourseName { get; set; }//课程名称
        public int ClassHour { get; set; }//课程课时
        public string TeacherName { get; set; }//教师姓名
    }
```
