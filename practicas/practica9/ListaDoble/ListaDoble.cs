using System;
public class ListaDoble
{
    private Nodo cabeza;
    private Nodo cola;

    public ListaDoble()
    {
        cabeza = null;
        cola = null;
    }

    // 1. Mostrar lista hacia adelante
    public void MostrarAdelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo temp = cabeza;
        Console.Write("Lista (adelante): ");
        while (temp != null)
        {
            Console.Write(temp.nombre + " <-> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }

    // 2. Mostrar lista hacia atrás
    public void MostrarAtras()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo temp = cola;
        Console.Write("Lista (atrás): ");
        while (temp != null)
        {
            Console.Write(temp.nombre + " <-> ");
            temp = temp.prev;
        }
        Console.WriteLine("null");
    }

    // 3. Insertar al inicio
    public void InsertarAlInicio(string nombre)
    {
        Nodo nuevo = new Nodo(nombre);
        if (cabeza == null)
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            nuevo.next = cabeza;
            cabeza.prev = nuevo;
            cabeza = nuevo;
        }
    }

    // 4. Insertar al final
    public void InsertarAlFinal(string nombre)
    {
        Nodo nuevo = new Nodo(nombre);
        if (cola == null)
        {
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            cola.next = nuevo;
            nuevo.prev = cola;
            cola = nuevo;
        }
    }

    // 5. Eliminar elemento
    public void Eliminar(string nombre)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo temp = cabeza;
        while (temp != null && temp.nombre != nombre)
        {
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine($"Elemento {nombre} no encontrado.");
            return;
        }

        if (temp == cabeza) // eliminar cabeza
        {
            cabeza = cabeza.next;
            if (cabeza != null) cabeza.prev = null;
            else cola = null;
        }
        else if (temp == cola) // eliminar cola
        {
            cola = cola.prev;
            if (cola != null) cola.next = null;
            else cabeza = null;
        }
        else // eliminar intermedio
        {
            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;
        }

        Console.WriteLine($"Elemento {nombre} eliminado.");
    }

    // 6. Buscar elemento
    public bool Buscar(string nombre)
    {
        Nodo temp = cabeza;
        int posicion = 0;
        while (temp != null)
        {
            if (temp.nombre == nombre)
            {
                Console.WriteLine($"Elemento {nombre} encontrado en posición {posicion}.");
                return true;
            }
            temp = temp.next;
            posicion++;
        }
        Console.WriteLine($"Elemento {nombre} no encontrado.");
        return false;
    }

    // 7. Cantidad de elementos
    public int Cantidad()
    {
        int count = 0;
        Nodo temp = cabeza;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }

    // 8. Verificar si está vacía
    public bool EstaVacia()
    {
        return cabeza == null;
    }
}
