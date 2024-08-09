using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class ListDemo<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if(items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public void showData()
        {
            Console.WriteLine($"so item trong list la : {items.Count}");
        }

    }
}
