public class ListasSimples
{
    public Nodo? cabeza = null;

    public void InsertarAlPrincipio(string dato)
    {
        var nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    public void Mostrar()
    {
        Nodo? actual = cabeza;
        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
    
    // 2. Eliminar alrededor de un valor (nodo anterior y siguiente al nombre dado)
    public void EliminarAlrededor(string dato)
    {
        if (cabeza == null || cabeza.Siguiente == null)
        {
            Console.WriteLine("La lista no tiene suficientes elementos.");
            return;
        }

        Nodo actual = cabeza;
        Nodo anterior = null;

        // Buscar el nodo con el nombre
        while (actual != null && actual.Dato != dato)
        {
            anterior = actual;
            actual = actual.Siguiente;
        }

        if (actual == null)
        {
            Console.WriteLine($"El nombre '{dato}' no está en la lista.");
            return;
        }

        // Eliminar el anterior
        if (anterior != null)
        {
            Console.WriteLine($"Eliminado el nodo anterior con nombre '{anterior.Nombre}'");
            if (anterior == cabeza)
                cabeza = actual;
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != anterior)
                    temp = temp.Siguiente;
                temp.Siguiente = actual;
            }
        }

        // Eliminar el siguiente
        if (actual.Siguiente != null)
        {
            Console.WriteLine($"Eliminado el nodo siguiente con nombre '{actual.Siguiente.Dato}'");
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }
}