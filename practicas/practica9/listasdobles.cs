public class ListaDoble
{
    public NodoDoble Inicio;   // Primer nodo
    public NodoDoble Fin;      // Último nodo

    public ListaDoble()
    {
        Inicio = null;
        Fin = null;
    }

    // 1. Insertar al inicio
    public void InsertarInicio(string dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);

        if (Inicio == null)  // lista vacía
        {
            Inicio = nuevo;
            Fin = nuevo;
        }
        else
        {
            nuevo.Siguiente = Inicio;
            Inicio.Anterior = nuevo;
            Inicio = nuevo;
        }
    }

    // 2. Insertar al final
    public void InsertarFinal(string dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);

        if (Fin == null)  // lista vacía
        {
            Inicio = nuevo;
            Fin = nuevo;
        }
        else
        {
            Fin.Siguiente = nuevo;
            nuevo.Anterior = Fin;
            Fin = nuevo;
        }
    }

    // 3. Eliminar al inicio
    public string EliminarInicio()
    {
        if (Inicio == null) return null;

        string eliminado = Inicio.Dato;
        Inicio = Inicio.Siguiente;

        if (Inicio != null)
            Inicio.Anterior = null;
        else
            Fin = null;

        return eliminado;
    }

    // 4. Eliminar al final
    public string EliminarFinal()
    {
        if (Fin == null) return null;

        string eliminado = Fin.Dato;
        Fin = Fin.Anterior;

        if (Fin != null)
            Fin.Siguiente = null;
        else
            Inicio = null;

        return eliminado;
    }

    // 5. Mostrar desde el inicio
    public void MostrarAdelante()
    {
        if (Inicio == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = Inicio;
        Console.Write("Lista adelante: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // 6. Mostrar desde el final
    public void MostrarAtras()
    {
        if (Fin == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = Fin;
        Console.Write("Lista atrás: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }

    // 7. Buscar un dato
    public bool Buscar(string dato)
    {
        NodoDoble actual = Inicio;

        while (actual != null)
        {
            if (actual.Dato.ToLower() == dato.ToLower())
            {
                return true;
            }
            actual = actual.Siguiente;
        }
        return false;
    }
}

