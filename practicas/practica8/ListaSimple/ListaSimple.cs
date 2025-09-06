using System;
public class ListaSimple
{
    private Nodo cabeza;

    public ListaSimple()
    {
        cabeza = null;
    }

    public void Mostrar() // 1. Mostrar lista
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo temp = cabeza;
        Console.Write("Lista: ");
        while (temp != null)
        {
            Console.Write(temp.nombre + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }

    public void InsertarAlInicio(string nombre) // 2. Insertar al inicio
    {
        Nodo nuevo = new Nodo(nombre);
        nuevo.next = cabeza;
        cabeza = nuevo;
    }

    public void InsertarAlFinal(string nombre)   // 3. Insertar al final
    {
        Nodo nuevo = new Nodo(nombre);

        if (cabeza == null)
        {
            cabeza = nuevo;
            return;
        }

        Nodo temp = cabeza;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = nuevo;
    }

    public void Eliminar(string nombre)    // 4. Eliminar elemento
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.nombre == nombre)
        {
            Console.WriteLine($"Elemento {nombre} eliminado.");
            cabeza = cabeza.next;
            return;
        }

        Nodo temp = cabeza;
        while (temp.next != null && temp.next.nombre != nombre)
        {
            temp = temp.next;
        }

        if (temp.next == null)
        {
            Console.WriteLine($"Elemento {nombre} no encontrado.");
        }
        else
        {
            Console.WriteLine($"Elemento {nombre} eliminado.");
            temp.next = temp.next.next;
        }
    }

    public bool Buscar(string nombre)    // 5. Buscar elemento
    {
        Nodo temp = cabeza;
        int posicion = 0;

        while (temp != null)
        {
            if (temp.nombre == nombre)
            {
                Console.WriteLine($"Elemento {nombre} encontrado en la posición {posicion}.");
                return true;
            }
            temp = temp.next;
            posicion++;
        }

        Console.WriteLine($"Elemento {nombre} no encontrado.");
        return false;
    }

    public int Cantidad()    // 6. Cantidad de elementos
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

    public bool EstaVacia()    // 7. Verificar si está vacía
    {
        return cabeza == null;
    }
}
