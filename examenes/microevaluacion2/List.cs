using System;

public class SimpleList
{
    public Nodo? Head { get; private set; }
    public Nodo? Tail { get; private set; }
    private int count;

    public SimpleList()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    public void AddFirst(string name)
    {
        Nodo nodo = new Nodo(name);
        if (Head == null)
        {
            Head = nodo;
            Tail = nodo;
        }
        else
        {
            nodo.Next = Head;
            Head = nodo;
        }
        count++;
    }

    public void Mostrar()
    {
        Nodo? actual = Head;
        while (actual != null)
        {
            Console.WriteLine(actual.Name);
            actual = actual.Next;
        }
    }


    public void RemoveAround(string name)
    {
        if (Head == null || Head == Tail)
            return;

        Nodo? beforePrev = null;
        Nodo? prev = null;
        Nodo? current = Head;

        
        while (current != null && current.Name != name)
        {
            beforePrev = prev;
            prev = current;
            current = current.Next;
        }

        if (current == null)
            return;

    
        if (prev != null)
        {
            if (beforePrev == null)
            {
               
                Head = current;
            }
            else
            {
                beforePrev.Next = current;
            }
            count--;
        }
        if (current.Next != null)
        {
            Nodo? nextNode = current.Next;
            current.Next = nextNode.Next;
            if (nextNode == Tail)
            {
                Tail = current;
            }
            count--;
        }
    }
}