using System;

 public class ListasSimples
{
    private Nodo? cabeza;
    public ListasSimples()
    {
        cabeza = null;
    }


    // Funcion para mostrar la lista

    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("la lista se encuentra vacia");
            return;
        }

        Nodo actual = cabeza;
        Console.Write("Lista:");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ->");
            actual = actual.Siguiente;

        }
        Console.WriteLine("null");
    }

    // Funcion para insertar al inicio
    public void InsertarAlInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = cabeza;
        cabeza = nuevo;
    }

    // Funcion para insertar al final
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

    // Funcion para eliminar de una posicion especifica
    public void EliminarDeUnaPosicion(int posicion)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista se encuentra vacia");
            return;
        }

        if (posicion == 1)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("El nodo en la posicion 1 eliminado");
            return;

        }

        Nodo actual = cabeza;
        Nodo? anterior = null;
        int indice = 1;

        while (actual != null && indice < posicion)
        {
            anterior = actual;
            actual = actual.Siguiente;
            indice++;

        }

        if (actual == null)
        {
            Console.WriteLine("La posicion esta fuera de rango");
            return;
        }

        anterior!.Siguiente = actual.Siguiente;
        Console.WriteLine($"El Nodo en la posicion {posicion} fue eliminado");

    }

    // Funcion para buscar un elemento
    public void Buscar(int dato)
    {
        Nodo? actual = cabeza;
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

    //Funcion para contar los elementos de la cola
    public int Contar()
    {
        int contador = 0;
        Nodo? actual = cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Funcion para verificar si esta vacia
    public bool EstaVacia()
    {
        return cabeza == null;

    }

    // Funcion para vaciar lista
    public void Vaciar()
    {
        cabeza = null;
        Console.WriteLine("La lista ha sido vaciada con exito ehhh");
    }
}
