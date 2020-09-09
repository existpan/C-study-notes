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
