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

    // Enqueue (Agregar a la cola)
    public void Enqueue(int valor)
    {
        if (cantidad == tamaño)
        {
            Console.WriteLine("La cola está llena.");
            return;
        }
        final = (final + 1) % tamaño;
        elementos[final] = valor;
        cantidad++;
        Console.WriteLine("Elemento agregado: " + valor);
    }

    // Dequeue (Quitar de la cola)
    public int Dequeue()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return -1;
        }
        int valor = elementos[frente];
        frente = (frente + 1) % tamaño;
        cantidad--;
        Console.WriteLine("Elemento atendido: " + valor);
        return valor;
    }

    // Peek (Ver el primero sin sacarlo)
    public int Peek()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return -1;
        }
        return elementos[frente];
    }

    // Mostrar la cola
    public void Mostrar()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.Write("Elementos en la cola: ");
        for (int i = 0; i < cantidad; i++)
        {
            int indice = (frente + i) % tamaño;
            Console.Write(elementos[indice] + " ");
        }
        Console.WriteLine();
    }
}
