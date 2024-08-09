using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class MyClass
    {
        //truong du lieu cua lop (fied)
        private string myProperty;

        //constructor mac dinh khong co tham so
        public MyClass() { }
        //constructor duoc tao ra co tham so
        public MyClass(string property)
        {
            this.myProperty = property;
        }
        //property cua truong du lieu
        public string MyProperty { set; get; }
    }
}
