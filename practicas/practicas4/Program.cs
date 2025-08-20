using System;
using System.Collections.Generic;

// Clase que implementa la estructura de Pila
class Pila
{
    private List<int> elementos = new List<int>();

    public Pila()
    {
        elementos = new List<int>();
    }

    // Insertar un elemento en la pila
    public void Push(int valor)
    {
        elementos.Add(valor);
        Console.WriteLine($"Se insertó {valor} en la pila.");
    }

    // Insertar "n" elementos en la pila
    public void PushN(List<int> valores)
    {
        foreach (int valor in valores)
        {
            Push(valor); // Reutilizamos el método Push
        }
    }

    // Eliminar el último elemento (cima)
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía, no se puede eliminar.");
            return -1;
        }

        int valor = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        Console.WriteLine($"Se eliminó {valor} de la pila.");
        return valor;
    }

    // Ver el último elemento sin eliminarlo
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
        return elementos[elementos.Count - 1];
    }

    // Mostrar todos los elementos de la pila
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("\nElementos en la pila:");
        for (int i = elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(elementos[i]);
        }
    }

    // Verificar si la pila está vacía
    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    // Contar los elementos en la pila
    public int Count()
    {
        return elementos.Count;
    }

    // Vaciar la pila
    public void Clear()
    {
        elementos.Clear();
        Console.WriteLine("La pila ha sido vaciada.");
    }
}

// Programa de prueba
class Program
{
    static void Main()
    {
        Pila pila = new Pila();

        // Insertar elementos individualmente
        pila.Push(10);
        pila.Push(20);

        // Insertar múltiples elementos con PushN
        pila.PushN(new List<int> { 30, 40, 50 });

        // Mostrar pila
        pila.Mostrar();

        // Contar elementos
        Console.WriteLine($"\nNúmero de elementos en la pila: {pila.Count()}");

        // Ver último elemento
        Console.WriteLine($"Último elemento (Peek): {pila.Peek()}");

        // Eliminar un elemento
        pila.Pop();

        // Mostrar pila después de eliminar
        pila.Mostrar();

        // Vaciar la pila
        pila.Clear();

        // Mostrar pila después de vaciar
        pila.Mostrar();
    }
}

