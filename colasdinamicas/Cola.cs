using System;

public class Cola<T>
{
    private Nodo<T> frente;
    private Nodo<T> final;
    private int cantidad;

    public Cola()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Enqueue
    public void Enqueue(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);
        if (IsEmpty())
        {
            frente = nuevo;
            final = nuevo;
        }
        else
        {
            final.Siguiente = nuevo;
            final = nuevo;
        }
        cantidad++;
    }

    // Dequeue
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return default(T);
        }

        T valor = frente.Dato;
        frente = frente.Siguiente;
        if (frente == null)
            final = null;

        cantidad--;
        return valor;
    }

    // Dequeue por posición
    public T DequeueAtPosition(int posicion)
    {
        if (IsEmpty())
        {
            Console.WriteLine(" La cola está vacía.");
            return default(T);
        }

        if (posicion < 1 || posicion > cantidad)
        {
            Console.WriteLine(" Posición inválida.");
            return default(T);
        }

        T valorEliminado;
        
        // Caso especial: eliminar el primer elemento
        if (posicion == 1)
        {
            valorEliminado = frente.Dato;
            frente = frente.Siguiente;
            if (frente == null)
                final = null;
        }
        else
        {
            Nodo<T> actual = frente;
            Nodo<T> anterior = null;
            int contador = 1;

            // Buscar el nodo en la posición especificada
            while (contador < posicion && actual != null)
            {
                anterior = actual;
                actual = actual.Siguiente;
                contador++;
            }

            if (actual != null)
            {
                valorEliminado = actual.Dato;
                anterior.Siguiente = actual.Siguiente;

                // Si eliminamos el último elemento, actualizamos el final
                if (actual == final)
                    final = anterior;
            }
            else
            {
                Console.WriteLine("⚠️ Posición no encontrada.");
                return default(T);
            }
        }

        cantidad--;
        return valorEliminado;
    }

    // Peek
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return default(T);
        }
        return frente.Dato;
    }

    // Count
    public int Count()
    {
        return cantidad;
    }

    // View
    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("⚠️ La cola está vacía.");
            return;
        }

        Nodo<T> actual = frente;
        int pos = 1;
        while (actual != null)
        {
            Console.WriteLine($"{pos}. {actual.Dato}");
            actual = actual.Siguiente;
            pos++;
        }
    }

    // IsEmpty
    public bool IsEmpty()
    {
        return cantidad == 0;
    }

    // Clear
    public void Clear()
    {
        frente = null;
        final = null;
        cantidad = 0;
    }

    // Contains por dato
    public bool Contains(T dato)
    {
        Nodo<T> actual = frente;
        while (actual != null)
        {
            if (actual.Dato.Equals(dato))
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    // Buscar por posición
    public T GetElementAtPosition(int posicion)
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return default(T);
        }

        if (posicion < 1 || posicion > cantidad)
        {
            Console.WriteLine("Posición inválida.");
            return default(T);
        }

        Nodo<T> actual = frente;
        int contador = 1;

        while (contador < posicion && actual != null)
        {
            actual = actual.Siguiente;
            contador++;
        }

        if (actual != null)
        {
            return actual.Dato;
        }
        else
        {
            Console.WriteLine(" Posición no encontrada.");
            return default(T);
        }
    }

    // Buscar posición de un elemento
    public int FindPosition(T dato)
    {
        if (IsEmpty())
        {
            return -1;
        }

        Nodo<T> actual = frente;
        int posicion = 1;

        while (actual != null)
        {
            if (actual.Dato.Equals(dato))
                return posicion;
            
            actual = actual.Siguiente;
            posicion++;
        }

        return -1; // No encontrado
    }
}
