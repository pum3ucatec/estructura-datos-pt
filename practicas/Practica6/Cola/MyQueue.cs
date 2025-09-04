using System;

public class Cola
{
    private int[] elementos;
    private int tamaño;
    private int frente;
    private int final;
    private int cantidad;

    public Cola(int N)
    {
        this.elementos = new int[N];
        this.tamaño = N;
        this.frente = 0;
        this.final = -1;
        this.cantidad = 0;
    }

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

    public int Peek()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return -1;
        }
        return elementos[frente];
    }

    public bool EstaVacia()
    {
        return cantidad == 0;
    }
    
    public bool EstaLlena()
    {
        return cantidad == tamaño;
    }

    public int Conteo()
    {
        return cantidad;
    }
}