using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mynamespace
{
    public class FixedStack<T>
    {
        private T[] items; // stack elements
        private int count; // amount of elements
        const int n = 10; // number of elements in an array by default
        public FixedStack()
        {
            items = new T[n];
        }
        public FixedStack(int length)
        {
            items = new T[length];
        }
        // is the stack empty
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        // stack size
        public int Count
        {
            get { return count; }
        }
        // adding an element
        public void Push(T item)
        {
            // if the stack is full, throw an exception 
            if (count == items.Length)
                throw new InvalidOperationException("Stack Overflow");
            items[count++] = item;
        }
        // element extraction
        public T Pop()
        {
            // if the stack is empty, throw an exception
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T item = items[--count];
            items[count] = default(T); // сбрасываем ссылку 
            return item;
        }
        // return the element from the top of the stack
        public T Peek()
        {
            // if the stack is empty, throw an exception
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return items[count - 1];
        }
    }
}