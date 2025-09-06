
public class ListaSimple
{
    // Cabeza de la lista
    public Nodo Head { get; private set; }

    public ListaSimple()
    {
        this.Head = null;
    }

    // 1) Insertar al inicio
    public void InsertarAlInicio(string valor)
    {
        Nodo nodo = new Nodo(valor);
        nodo.Siguiente = this.Head;
        this.Head = nodo;
        Console.WriteLine(valor + " insertado al inicio.");
    }

    // 2) Insertar al final
    public void InsertarAlFinal(string valor)
    {
        Nodo nodo = new Nodo(valor);
        if (this.Head == null)
        {
            this.Head = nodo;
        }
        else
        {
            Nodo actual = this.Head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nodo;
        }
        Console.WriteLine(valor + " insertado al final.");
    }

    // 3) Eliminar primera ocurrencia por valor
    public string Eliminar(string valor)
    {
        if (this.Head == null) return null;

        // Si el primer nodo es el que hay que eliminar
        if (string.Equals(this.Head.Valor, valor, StringComparison.OrdinalIgnoreCase))
        {
            this.Head = this.Head.Siguiente;
            return valor;
        }

        Nodo anterior = this.Head;
        Nodo actual = this.Head.Siguiente;

        while (actual != null)
        {
            if (string.Equals(actual.Valor, valor, StringComparison.OrdinalIgnoreCase))
            {
                anterior.Siguiente = actual.Siguiente;
                return valor;
            }
            anterior = actual;
            actual = actual.Siguiente;
        }

        return null; // no encontrado
    }

    // 4) Buscar (Contains)
    public bool Contiene(string valor)
    {
        Nodo actual = this.Head;
        while (actual != null)
        {
            if (string.Equals(actual.Valor, valor, StringComparison.OrdinalIgnoreCase))
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    // 5) Verificar si está vacía
    public bool EstaVacia()
    {
        return this.Head == null;
    }

    // 6) Contar elementos
    public int Count()
    {
        int contador = 0;
        Nodo actual = this.Head;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // 7) Vaciar lista
    public void Vaciar()
    {
        this.Head = null;
        Console.WriteLine("Lista vaciada.");
    }

    // 8) Mostrar lista
    public void Ver()
    {
        if (this.Head == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = this.Head;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Valor);
            if (actual.Siguiente != null) Console.Write(" -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}