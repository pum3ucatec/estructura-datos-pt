using System;

public class MyQueue
{
    private char[] _elements; // almacenamiento circular
    private int _capacity;    // tamaño fijo de la cola
    private int _front;       // índice del frente
    private int _rear;        // índice del final
    private int _count;       // número de elementos

    public MyQueue(int capacity)
    {
        if (capacity <= 0)
        {
            Console.WriteLine("Capacidad inválida. Usando 5 por defecto.");
            capacity = 5;
        }

        _elements = new char[capacity];
        _capacity = capacity;
        _front = 0;
        _rear = 0;
        _count = 0;
    }

    // Insertar al final
    public void Enqueue(char item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena, no se puede insertar.");
            return;
        }
        _elements[_rear] = item;
        _rear = (_rear + 1) % _capacity;
        _count++;
    }

    // Eliminar del frente
    public char Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía, no se puede eliminar.");
            return '\0';
        }
        char value = _elements[_front];
        _front = (_front + 1) % _capacity;
        _count--;
        return value;
    }

    // Ver frente
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return _elements[_front];
    }

    // Cantidad de elementos
    public int Count()
    {
        return _count;
    }

    // ¿Vacía?
    public bool IsEmpty()
    {
        return _count == 0;
    }

    // ¿Llena?
    public bool IsFull()
    {
        return _count == _capacity;
    }

    // (Opcional) Mostrar elementos para depurar
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        Console.Write("Elementos (frente → atrás): ");
        for (int i = 0; i < _count; i++)
        {
            int idx = (_front + i) % _capacity;
            Console.Write(_elements[idx] + " ");
        }
        Console.WriteLine();
    }
}
