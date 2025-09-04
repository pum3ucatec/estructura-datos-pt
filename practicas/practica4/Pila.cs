class Pila
{
    private List<int> elementos;

    public Pila()
    {
        elementos = new List<int>();
    }

    // Insertar un elemento en la pila
    public void Push(int valor)
    {
        elementos.Add(valor);
        Console.WriteLine($"Se insertó {valor} en la pila.");
    }

    // Eliminar el último elemento (cima)
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía, no se puede eliminar.");
            return -1;
        }

        int valor = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        Console.WriteLine($"Se eliminó {valor} de la pila.");
        return valor;
    }

    // Ver el último elemento sin eliminarlo
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
        return elementos[elementos.Count - 1];
    }

    // Mostrar todos los elementos de la pila
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("\nElementos en la pila:");
        for (int i = elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(elementos[i]);
        }
    }

    // Verificar si la pila está vacía
    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }

    // Eliminar todos los elementos de la pila (sin usar Clear)
    public void Clear()
    {
        // Opción 1: Reasignar la lista (más rápido y limpio)
        elementos = new List<int>();

        // Opción 2: Eliminar uno por uno (más manual)
        /*
        while (elementos.Count > 0)
        {
            elementos.RemoveAt(elementos.Count - 1);
        }
        */
        
        Console.WriteLine("Se eliminaron todos los elementos de la pila.");
    }
}
