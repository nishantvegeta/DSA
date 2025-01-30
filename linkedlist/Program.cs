using System;
using System.Collections.Generic;

interface ILinkedList 
{
    void Add(int data);
    void Display();
}

class Node 
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data) 
    {
        Data = data;
        Next = null;
    }
}

class LinkedList : ILinkedList
{
    private Node Head;

    public LinkedList() 
    {
        Head = null;
    }

    public void Add(int data) 
    {
        Node newNode = new Node(data);
        if (Head == null) 
        {
            Head = newNode;
        } 
        else 
        {
            Node current = Head;
            while (current.Next != null) 
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display() 
    {
        Node current = Head;
        while (current != null) 
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        LinkedList list = new LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Display();
    }
}