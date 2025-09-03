using System;
public class ListasDobles
{
    public NodoDoble? cabeza;
    public NodoDoble? cola;

    public ListasDobles()
    {
        cabeza = null;
        cola = null;

    }

    //Metodo para mostar las listas hacia adelante
    public void MostrarHaciaAdelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista se encuentra vacia");
            return;
        }

        NodoDoble? actual = cabeza;
        Console.Write("Lista hacia adelante:");
        while (actual != null)
        {
            Console.Write(actual.Dato + "<->");
            actual = actual.Siguiente;

        }
        Console.WriteLine("null");
    }

    //Metodo para mostrar lista hacia atras
    public void MostrarHaciaAtras()
    {
        if (cola == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cola;
        Console.Write("Lista hacia atras:");
        while (actual != null)
        {
            Console.Write(actual.Dato + "<->");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }

    // Funcion para insertar al inicio
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

    // Funcion para insertar al final
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

    // funacion para eliminar al inicio
    public void EliminarAlInicio()
    {
        if (cabeza == null)
        {
            Console.WriteLine("la lista esta vacia");
            return;
        }
        if (cabeza == cola)
        {
            cabeza = cola = null;
        }
        else
        {
            cabeza = cabeza.Siguiente;
            cabeza!.Anterior = null;
        }
        Console.WriteLine("Nodo al inicio eliminado");

    }

    // Función para eliminar al final
    public void EliminarAlFinal()
    {
        if (cola == null)
        {
            Console.WriteLine("la lista esta vacia");
            return;
        }
        if (cabeza == cola)
        {
            cabeza = cola = null;
        }
        else
        {
            cola = cola.Anterior;
            cola!.Siguiente = null;
        }
        Console.WriteLine("Nodo al final eliminado");

    }

    //Funcion para eliminar en una posicion especifica
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

        NodoDoble? actual = cabeza;
        int indice = 0;

        while (actual != null && indice < posicion)
        {
            actual = actual.Siguiente;
            indice++;
        }

        if (actual == null)
        {
            Console.WriteLine("Posición fuera de rango.");
            return;
        }

        if (actual == cola)
        {
            EliminarAlFinal();
            return;
        }

        actual.Anterior!.Siguiente = actual.Siguiente;
        actual.Siguiente!.Anterior = actual.Anterior;

        Console.WriteLine($"Nodo en la posición {posicion} eliminado.");
    }

    // Función para buscar un elemento
    public void Buscar(int dato)
    {
        NodoDoble? actual = cabeza;
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

    // Funcion para contar los elementos de la lista
    public int Contar()
    {
        int contador = 0;
        NodoDoble? actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    // Función para verificar si esta vacia
    public bool EstaVacia()
    {
        return cabeza == null;
    }
    // Fución para veciar lista
    public void Vaciar()
    {
        cabeza = cola = null;
        Console.WriteLine("La lista ha sido vaciada");
    }
}