using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    interface InterfaceDemo
    {
        string Carname { get; set; }
    }
    class Car : InterfaceDemo
    {
        public string Carname { get; set; }
    }
}
