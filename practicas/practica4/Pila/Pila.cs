using System;
using System.Collections.Generic;

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

    // Insertar varios elementos
    public void PushN(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el valor #{i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                elementos.Add(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido, intente de nuevo.");
                i--; 
            }
        }
        Console.WriteLine($"Se insertaron {cantidad} elementos en la pila.");
    }

    // Contar los elementos
    public int Count()
    {
        return elementos.Count;
    }

    // Vaciar la pila
    public void Clear()
    {
        elementos.Clear();
        Console.WriteLine("La pila fue vaciada.");
    }
}