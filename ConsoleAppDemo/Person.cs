using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Person
    {
        //property cua field
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }

        public Person() { }
        public Person(int id, string? name, int? age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        //hàm có từ khóa virtual có thể bị ghi đè bởi lớp con
        public virtual void Action()
        {
            Console.WriteLine("a person action");
        }
    }

    class Student : Person {
        //hàm có từ khóa override ghi đè phương thức trên
        public override void Action() {
            Console.WriteLine("coding");
        }
    }
}
