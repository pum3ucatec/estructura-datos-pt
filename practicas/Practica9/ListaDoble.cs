using System;

/// Clase ListaDoble que gestiona la lista doblemente enlazada.
/// Permite insertar, eliminar y recorrer en ambas direcciones.
public class ListaDoble
{
    private NodoDoble Cabeza;

    public ListaDoble()
    {
        Cabeza = null;
    }

    /// Inserta un nodo al inicio de la lista
    public void InsertarAlInicio(int dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);
        if (Cabeza != null)
        {
            nuevo.Siguiente = Cabeza;
            Cabeza.Anterior = nuevo;
        }
        Cabeza = nuevo;
    }

    /// Inserta un nodo al final de la lista
    public void InsertarAlFinal(int dato)
    {
        NodoDoble nuevo = new NodoDoble(dato);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
            return;
        }

        NodoDoble actual = Cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevo;
        nuevo.Anterior = actual;
    }

    /// Elimina el primer nodo que contenga el valor especificado
    public void Eliminar(int dato)
    {
        NodoDoble actual = Cabeza;

        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                if (actual.Anterior != null)
                    actual.Anterior.Siguiente = actual.Siguiente;
                else
                    Cabeza = actual.Siguiente;

                if (actual.Siguiente != null)
                    actual.Siguiente.Anterior = actual.Anterior;

                return;
            }
            actual = actual.Siguiente;
        }
    }

    /// Recorre la lista de inicio a fin
    public void MostrarAdelante()
    {
        NodoDoble actual = Cabeza;
        Console.Write("Null - ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " - ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("Null");
    }

    /// Recorre la lista de fin a inicio
    public void MostrarAtras()
    {
        if (Cabeza == null) return;

        NodoDoble actual = Cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }

        Console.Write("Null - ");
        while (actual != null)
        {
            Console.Write(actual.Dato + " - ");
            actual = actual.Anterior;
        }
        Console.WriteLine("Null");
    }
}
