class ListaSimple
{
    public Nodo cabeza;

    public ListaSimple()
    {
        cabeza = null;
    }

    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
    public void Insertar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (IsEmpty())
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        Console.WriteLine($"Elemento {valor} insertado en la lista.");
    }

    public void Eliminar(int valor)
    {
        if (IsEmpty())
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine($"Elemento {valor} eliminado de la lista.");
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente == null)
        {
            Console.WriteLine($"Elemento {valor} no encontrado en la lista.");
        }
        else
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine($"Elemento {valor} eliminado de la lista.");
        }
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Elementos en la lista: ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La lista está vacía.");
            return -1;
        }
        return cabeza.Valor;
    }
    public bool IsEmpty()
    {
        return cabeza == null;
    }

}