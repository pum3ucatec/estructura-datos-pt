using System;
using System.Collections.Generic;

class Pila
{
    private List<int> elementos;

    public Pila()
    {
        elementos = new List<int>();
    }

    // Inserta un elemento en la cima
    public void Push(int valor)
    {
        elementos.Add(valor);
        Console.WriteLine($"Elemento {valor} insertado correctamente.");
    }

    // Elimina y retorna el elemento de la cima
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía, no se puede eliminar.");
            return -1;
        }
        int valor = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        Console.WriteLine($"Elemento {valor} eliminado.");
        return valor;
    }

    // Consulta el elemento en la cima sin eliminarlo
    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
        }
        else
        {
            int valor = elementos[elementos.Count - 1];
            Console.WriteLine($"Elemento en la cima: {valor}");
        }
    }

    // Verifica si la pila está vacía
    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    // Muestra el contenido de la pila de forma visual
    public void Mostrar()
    {
        Console.WriteLine("Contenido de la pila (de arriba a abajo):");
        for (int i = elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine($"│ {elementos[i]} │");
            if (i > 0) Console.WriteLine("├───┤");
            else Console.WriteLine("└───┘");
        }
        if (IsEmpty())
            Console.WriteLine("La pila está vacía.");
    }

    // Limpia todos los elementos
    public void Clear()
    {
        elementos.Clear();
        Console.WriteLine("La pila ha sido limpiada.");
    }
}
