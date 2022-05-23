using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mynamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            // добавление элементов
            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.Add("Tom");
            linkedList.AddFirst("Kate");
            Console.WriteLine("Текущий лист:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // удаление
            linkedList.Remove("Bill");

            // перебор с последнего элемента
            Console.WriteLine("После изменения:");
            foreach (var t in linkedList.BackEnumerator())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();

            try
            {
                FixedStack<string> stack = new FixedStack<string>(8);
                // add four elements
                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                // extract one element
                var head = stack.Pop();
                Console.WriteLine(head); // Tom 

                // just get the top of the stack without popping
                head = stack.Peek();
                Console.WriteLine(head); // Alice 
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }
}