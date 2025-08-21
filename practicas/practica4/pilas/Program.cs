using System;
using System.Collections.Generic;

class Pila
{
    private Stack<int> stack = new Stack<int>();

    // Insertar un elemento
    public void Push(int valor)
    {
        stack.Push(valor);
        Console.WriteLine($"Se insertó: {valor}");
    }

    // Insertar n elementos
    public void PushN(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese el elemento {i}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                stack.Push(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido, se omitirá.");
            }
        }
        Console.WriteLine($"Se insertaron {n} elementos.");
    }

    // Eliminar un elemento
    public void Pop()
    {
        if (stack.Count > 0)
            Console.WriteLine($"Se eliminó: {stack.Pop()}");
        else
            Console.WriteLine("La pila está vacía.");
    }

    // Ver la cima
    public int Peek()
    {
        if (stack.Count > 0)
            return stack.Peek();
        Console.WriteLine("La pila está vacía.");
        return -1;
    }

    // Mostrar todos los elementos
    public void Mostrar()
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Elementos en la pila:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }

    // Verificar si está vacía
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    // Contar elementos
    public int Count()
    {
        return stack.Count;
    }

    // Limpiar pila
    public void Clear()
    {
        stack.Clear();
        Console.WriteLine("La pila fue vaciada.");
    }
} 

