using System;

public class MyQueue
{
    private int[] elementos;  // arreglo de la cola
    private int frente;       // índice del primer elemento
    private int final;        // índice del último elemento
    private int count;        // cantidad de elementos actuales

    public MyQueue(int size)
    {
        elementos = new int[size];
        frente = 0;
        final = -1;
        count = 0;
    }

    // ==== PROPIEDADES ====
    public int Count => count;               // número de elementos actuales
    public int Length => elementos.Length;   // capacidad máxima
    public int Size => elementos.Length;     // alias de Length (por si piden ambos)

    // ==== MÉTODOS DE VERIFICACIÓN ====
    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == elementos.Length;
    }

    // ==== OPERACIONES DE LA COLA ====
    public void Enqueue(int valor)
    {
        if (IsFull())
        {
            Console.WriteLine("⚠️ La cola está llena. No se puede insertar.");
            return;
        }

        final = (final + 1) % elementos.Length;
        elementos[final] = valor;
        count++;
        Console.WriteLine($"✅ {valor} insertado en la cola.");
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía. No se puede eliminar.");
            return;
        }

        int eliminado = elementos[frente];
        frente = (frente + 1) % elementos.Length;
        count--;
        Console.WriteLine($"❌ {eliminado} eliminado de la cola.");
    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
        }
        else
        {
            Console.WriteLine($"👀 Frente de la cola: {elementos[frente]}");
        }
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return;
        }

        Console.Write("📌 Cola: ");
        for (int i = 0; i < count; i++)
        {
            int index = (frente + i) % elementos.Length;
            Console.Write(elementos[index] + " ");
        }
        Console.WriteLine();
    }
}