using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
     abstract class Abstraction
    {
        public abstract void Draw();
        public void Display()
        {
            Console.WriteLine("Abstraction");
        }
    }
    class Circle : Abstraction { 
        public override void Draw()
        {
            Console.WriteLine("a circle");
        }
    }
}
