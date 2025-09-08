using System;

public class lista_doble
{
    private nodo_doble cabeza;
    private nodo_doble cola;
    private int cantidad;

    public lista_doble()
    {
        cabeza = null;
        cola = null;
        cantidad = 0;
    }

    public void insertar_inicio(string dato)
    {
        nodo_doble nuevo = new nodo_doble(dato);
        if (cabeza == null)
        {
            cabeza = cola = nuevo;
        }
        else
        {
            nuevo.siguiente = cabeza;
            cabeza.anterior = nuevo;
            cabeza = nuevo;
        }
        cantidad++;
    }

    public void insertar_final(string dato)
    {
        nodo_doble nuevo = new nodo_doble(dato);
        if (cola == null)
        {
            cabeza = cola = nuevo;
        }
        else
        {
            cola.siguiente = nuevo;
            nuevo.anterior = cola;
            cola = nuevo;
        }
        cantidad++;
    }

    public void eliminar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista esta vacia.");
            return;
        }

        nodo_doble actual = cabeza;
        while (actual != null && actual.nombre != dato)
            actual = actual.siguiente;

        if (actual == null)
        {
            Console.WriteLine($"El elemento '{dato}' no se encontro.");
            return;
        }

        if (actual == cabeza)
            cabeza = cabeza.siguiente;
        if (actual == cola)
            cola = cola.anterior;

        if (actual.anterior != null)
            actual.anterior.siguiente = actual.siguiente;
        if (actual.siguiente != null)
            actual.siguiente.anterior = actual.anterior;

        cantidad--;
        Console.WriteLine($"Elemento '{dato}' eliminado.");
    }

    public void mostrar_adelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista esta vacia.");
            return;
        }

        nodo_doble actual = cabeza;
        Console.Write("Lista adelante: ");
        while (actual != null)
        {
            Console.Write($"{actual.nombre} -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("null");
    }

    public void mostrar_atras()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista esta vacia.");
            return;
        }

        nodo_doble actual = cola;
        Console.Write("Lista atras: ");
        while (actual != null)
        {
            Console.Write($"{actual.nombre} -> ");
            actual = actual.anterior;
        }
        Console.WriteLine("null");
    }

    public bool contiene(string dato)
    {
        nodo_doble actual = cabeza;
        while (actual != null)
        {
            if (actual.nombre == dato) return true;
            actual = actual.siguiente;
        }
        return false;
    }

    public int contar() => cantidad;

    public bool esta_vacia() => cabeza == null;
}