using System;
using System.Collections.Generic;

interface ILinkedList 
{
    void Add(int data);
    void DisplayForward();
    void DisplayBackward();
}

class Node 
{
    public int Data { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }

    public Node(int data) 
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

class DoublyLinkedList : ILinkedList
{
    private Node Head;
    private Node Tail;

    public DoublyLinkedList() 
    {
        Head = null;
        Tail = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
    }

    public void DisplayForward()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write( current.Data );
            if (current.Next != null)
            {
                Console.Write(" <-> ");
            }
            current = current.Next;
        }
        Console.WriteLine(" -> null");
    }

    public void DisplayBackward()
    {
        Node current = Tail;
        while (current != null)
        {
            Console.Write( current.Data );
            if (current.Previous != null)
            {
                Console.Write(" <-> ");
            }
            current = current.Previous;
        }
        Console.WriteLine(" -> null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList list = new DoublyLinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.DisplayForward();
        list.DisplayBackward();
    }
}