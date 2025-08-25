using System;
using System.Collections.Generic;

public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int N)
    {
        this.Elements = new char[2] { 'D', 'V'};
        this.Size = 2;
    }

    public void Mostrar()
    {
        Console.WriteLine("\nElementos en la cola:");
        for (int i = 0; i < this.Size; i++)
        {
            Console.Write($"{this.Elements[i]} ");
        }
    }
}
