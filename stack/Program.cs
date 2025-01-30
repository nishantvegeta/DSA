using System;
using System.Collections.Generic;

interface IStack
{
    void Push(int data);
    int Pop();
    int Peek();
    void Display();
}

class Stack : IStack
{
    private List<int> stacklist;

    public Stack()
    {
        stacklist = new List<int>();
    }

    public void Push(int data)
    {
        stacklist.Add(data);
    }

    public int Pop()
    {
        if (stacklist.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            int data = stacklist[stacklist.Count - 1];
            stacklist.RemoveAt(stacklist.Count - 1);
            return data;
        }
    }

    public int Peek()
    {
        if (stacklist.Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return stacklist[stacklist.Count - 1];
        }
    }

    public void Display()
    {
        for (int i = stacklist.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(stacklist[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(19);
        stack.Push(31);
        stack.Push(24);
        stack.Push(44);
        stack.Push(90);
        stack.Display();
        Console.WriteLine("Peek: " + stack.Peek());
        Console.WriteLine("Pop: " + stack.Pop());
        stack.Display();
    }
}