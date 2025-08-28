public class Cola<T>
{
    private Nodo<T>? frente;  // Nullable
    private Nodo<T>? fin;     // Nullable
    private int count;

    public Cola()
    {
        frente = null;
        fin = null;
        count = 0;
    }

    public void Enqueue(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);

        if (fin == null) // Cola vacía
        {
            frente = nuevo;
            fin = nuevo;
        }
        else
        {
            fin.Siguiente = nuevo;
            fin = nuevo;
        }
        count++;
    }

    public T Dequeue()
    {
        if (EstaVacia())
            throw new InvalidOperationException("La cola está vacía.");

        T dato = frente!.Dato; // "!" porque sabemos que no es null
        frente = frente.Siguiente;

        if (frente == null)
            fin = null;

        count--;
        return dato;
    }

    public T Peek()
    {
        if (EstaVacia())
            throw new InvalidOperationException("La cola está vacía.");

        return frente!.Dato;
    }

    public bool EstaVacia()
    {
        return frente == null;
    }

    public int Count()
    {
        return count;
    }

    public void Clear()
    {
        frente = null;
        fin = null;
        count = 0;
    }

    public bool Contains(T dato)
    {
        Nodo<T>? actual = frente;
        while (actual != null)
        {
            if (actual.Dato!.Equals(dato))
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    public void Mostrar()
    {
        Nodo<T>? actual = frente;
        Console.Write("Cola: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}
