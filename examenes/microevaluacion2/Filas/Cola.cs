public class Cola
{
    private Nodo? Head { get; set; }

    public Fila()
    {
        Head = null;
    }

    public void Insert(string valor)
    {
        Nodo nuevoNodo = new Nodo(valor);

        if (Head == null)
        {
            Head = nuevoNodo;
        }
        else
        {
            Nodo actual = Head;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevoNodo;
        }
    }

    /*public string? Eliminar()
    {
        if (Head == null)
        {
            Console.WriteLine("La cola está vacía.");
            return null;
        }

        string dato = Head.Data;
        Head = Head.Next;

        if (Head == null)
            /*Rear = null;

        return dato;
    }
*/
    public void View()
    {
        Nodo? actual = Head;

        if (actual == null)
        {
            Console.WriteLine("La fila está vacía.");
            return;
        }

        Console.Write("Contenido de la fila: ");

        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Next;
        }

        Console.WriteLine("null");
    }


    /*public bool Contains(string valor)
    {
        Nodo? actual = Front;
        while (actual != null)
        {
            if (actual.Data == valor)
                return true;
            actual = actual.Next;
        }
        return false;
    }

    public bool delete_p(int posicion)
    {
        if (posicion == 1)
        {
            Front = Front.Next;
            if (Front == null) // si se eliminó el único nodo
                Rear = null;
            return true;
        }

        // Recorremos hasta el nodo anterior al que queremos eliminar
        Nodo? actual = Front;
        int index = 1;
        while (actual != null && index < posicion - 1)
        {
            actual = actual.Next;
            index++;
        }

        // Si llegamos al final sin encontrar la posición
        if (actual == null || actual.Next == null)
        {
            Console.WriteLine("La posición no existe en la cola.");
            return false;
        }

        // Eliminamos el nodo apuntando al siguiente
        actual.Next = actual.Next.Next;

        // Si eliminamos el último nodo, actualizar Rear
        if (actual.Next == null)
            Rear = actual;

        return true;
    }*/
}
