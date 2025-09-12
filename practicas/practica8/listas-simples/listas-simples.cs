public class ListasSimples
{
    private Nodo cabeza;

    public ListasSimples()
    {
        cabeza = null;
    }

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void InsertarAlInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void InsertarAlFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevo;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevo;
    }

    public void EliminarDeUnaPosicion(int posicion)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (posicion == 1)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        Nodo anterior = null;
        int contador = 1;

        while (actual != null && contador < posicion)
        {
            anterior = actual;
            actual = actual.Siguiente;
            contador++;
        }

        if (actual == null)
        {
            Console.WriteLine("Posición fuera de rango.");
        }
        else
        {
            anterior.Siguiente = actual.Siguiente;
        }
    }

    public void Buscar(int dato)
    {
        Nodo actual = cabeza;
        int posicion = 1;

        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                Console.WriteLine($"Elemento {dato} encontrado en la posición {posicion}.");
                return;
            }
            actual = actual.Siguiente;
            posicion++;
        }

        Console.WriteLine($"Elemento {dato} no encontrado en la lista.");
    }

    public int Contar()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }

    public void Vaciar()
    {
        cabeza = null;
    }
}
