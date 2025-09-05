using System;
using System.Collections.Generic;

public class MyQueue
{
    private Queue<int> cola = new Queue<int>();
    private int capacidad;

    public MyQueue(int capacidad = int.MaxValue) // capacidad opcional
    {
        this.capacidad = capacidad;
    }

    public void Insertar(int elemento)
    {
        if (cola.Count < capacidad)
        {
            cola.Enqueue(elemento);
            Console.WriteLine($"Se insertó {elemento} en la cola.");
        }
        else
        {
            Console.WriteLine("⚠️ La cola está llena.");
        }
    }

    public int Eliminar()
    {
        if (cola.Count > 0)
        {
            return cola.Dequeue();
        }
        Console.WriteLine("⚠️ La cola está vacía.");
        return -1;
    }

    public int VerFrente()
    {
        if (cola.Count > 0)
        {
            return cola.Peek();
        }
        Console.WriteLine("⚠️ La cola está vacía.");
        return -1;
    }

    public int Tamaño()
    {
        return cola.Count;
    }

    public bool EstaVacia()
    {
        return cola.Count == 0;
    }

    public bool EstaLlena()
    {
        return cola.Count >= capacidad;
    }

    public void Vaciar()
    {
        cola.Clear();
        Console.WriteLine("La cola ha sido vaciada.");
    }

    public bool Buscar(int elemento)
    {
        return cola.Contains(elemento);
    }

    public void Mostrar()
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("Elementos en la cola:");
        foreach (var item in cola)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
