using System;

public class Cola
{
    private Nodo cabeza;

    public Cola()
    {
        cabeza = null;
    }

    public void AgregarAlInicio(string dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        nuevoNodo.Siguiente = cabeza;
        cabeza = nuevoNodo;
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Elementos: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}