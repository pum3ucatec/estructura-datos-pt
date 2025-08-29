class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int d)
    {
        dato = d;
        siguiente = null;
    }
}

class ListaSimple
{
    public Nodo cabeza;

    // Insertar al principio
    public void InsertarAlPrincipio(int d)
    {
        Nodo nuevo = new Nodo(d);
        nuevo.siguiente = cabeza;
        cabeza = nuevo;
    }

    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.dato + " -> ");
            actual = actual.siguiente;
        }
        Console.WriteLine("null");
    }
}

