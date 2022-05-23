using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Mynamespace;

namespace UnitTester;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestRemove()
    {
        string a = "";
        DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
        linkedList.Add("Bob");
        linkedList.Add("Bill");
        linkedList.Remove("Bill");
        foreach (var t in linkedList.BackEnumerator())
        {
            a = t;
        }
        Assert.AreEqual(a, "Bob");
    }

    [Test]
    public void TestAdd()
    {
        string a = "";
        DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
        linkedList.Add("Bob");
        foreach (var item in linkedList)
        {
            a = item;
        }
        Assert.AreEqual(a, "Bob");
    }

    [Test]
    public void TestAddFirst()
    {
        string a = "";
        DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
        linkedList.Add("Bob");
        linkedList.AddFirst("Kate");
        foreach (var item in linkedList)
        {
            a = item;
        }
        Assert.AreEqual(a, "Bob");
    }

    [Test]
    public void TestClear()
    {
        DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
        linkedList.Clear();
        Assert.AreEqual(0, linkedList.Count);
    }
    [Test]
    public void TestPush()
    {
        FixedStack<string> stack = new FixedStack<string>(8);
        stack.Push("Kate");
        Assert.AreEqual(false, stack.IsEmpty);
    }
    [Test]
    public void TestTPop()
    {
        FixedStack<string> stack = new FixedStack<string>(8);
        stack.Push("Kate");
        stack.Push("Sam");
        string head = stack.Pop().ToString();
        Assert.AreEqual(head, "Sam");
    }
    [Test]
    public void TestTPeek()
    {
        FixedStack<string> stack = new FixedStack<string>(8);
        stack.Push("Kate");
        stack.Push("Sam");
        string head = stack.Peek().ToString();
        Assert.AreEqual(head, "Sam");
    }
}