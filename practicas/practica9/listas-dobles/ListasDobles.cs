public class ListasDobles
{
    private NodoDoble cabeza;
    private NodoDoble cola;

    public ListasDobles()
    {
        cabeza = null;
        cola = null;
    }

    // Mostrar lista
    public void MostrarHaciaAdelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void MostrarHaciaAtras()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cola;
        while (actual != null)
        {
            Console.Write(actual.Dato + " <-> ");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }

    // Inserciones
    public void InsertarAlInicio(int dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);
        if (cabeza == null)
        {
            cabeza = cola = nuevo;
        }
        else
        {
            nuevo.Siguiente = cabeza;
            cabeza.Anterior = nuevo;
            cabeza = nuevo;
        }
    }

    public void InsertarAlFinal(int dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);
        if (cola == null)
        {
            cabeza = cola = nuevo;
        }
        else
        {
            cola.Siguiente = nuevo;
            nuevo.Anterior = cola;
            cola = nuevo;
        }
    }

    // Eliminaciones
    public void EliminarAlInicio()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza == cola)
        {
            cabeza = cola = null;
        }
        else
        {
            cabeza = cabeza.Siguiente;
            cabeza.Anterior = null;
        }
    }

    public void EliminarAlFinal()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza == cola)
        {
            cabeza = cola = null;
        }
        else
        {
            cola = cola.Anterior;
            cola.Siguiente = null;
        }
    }

    public void EliminarEnPosicion(int posicion)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (posicion == 1)
        {
            EliminarAlInicio();
            return;
        }

        NodoDoble actual = cabeza;
        int contador = 1;

        while (actual != null && contador < posicion)
        {
            actual = actual.Siguiente;
            contador++;
        }

        if (actual == null)
        {
            Console.WriteLine("Posición fuera de rango.");
        }
        else if (actual == cola)
        {
            EliminarAlFinal();
        }
        else
        {
            actual.Anterior.Siguiente = actual.Siguiente;
            actual.Siguiente.Anterior = actual.Anterior;
            Console.WriteLine($"Nodo en la posición {posicion} eliminado.");
        }
    }

    // Operaciones adicionales
    public void Buscar(int dato)
    {
        NodoDoble actual = cabeza;
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
        NodoDoble actual = cabeza;

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
        cabeza = cola = null;
    }
}
