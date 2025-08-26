using System;

public class ColaCaracteres
{
    private char[] arreglo;
    private int capacidad;
    private int inicio;
    private int fin;
    private int total;

    public ColaCaracteres(int limite)
    {
        capacidad = limite;
        arreglo = new char[capacidad];
        inicio = 0;
        fin = -1;
        total = 0;
    }

    public void Insertar(char elemento)
    {
        if (EstaLlena())
        {
            Console.WriteLine("No se puede insertar: la cola alcanzó su límite.");
            return;
        }

        fin = (fin + 1) % capacidad;
        arreglo[fin] = elemento;
        total++;
        Console.WriteLine($"Elemento '{elemento}' añadido con éxito.");
    }

    public void Eliminar()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola está vacía, no hay nada que eliminar.");
            return;
        }

        char eliminado = arreglo[inicio];
        inicio = (inicio + 1) % capacidad;
        total--;
        Console.WriteLine($"Se eliminó el elemento: '{eliminado}'");
    }

    public char Frente()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola no contiene elementos.");
            return '\0';
        }

        return arreglo[inicio];
    }

    public bool EstaVacia()
    {
        return total == 0;
    }

    public bool EstaLlena()
    {
        return total == capacidad;
    }

    public int Cantidad()
    {
        return total;
    }

    public int Capacidad()
    {
        return capacidad;
    }

    public bool Buscar(char objetivo)
    {
        for (int i = 0; i < total; i++)
        {
            int indice = (inicio + i) % capacidad;
            if (arreglo[indice] == objetivo)
                return true;
        }
        return false;
    }

    public void VerCola()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("Elementos actuales en la cola:");
        for (int i = 0; i < total; i++)
        {
            int pos = (inicio + i) % capacidad;
            Console.Write($"{arreglo[pos]} ");
        }
        Console.WriteLine();
    }
}
