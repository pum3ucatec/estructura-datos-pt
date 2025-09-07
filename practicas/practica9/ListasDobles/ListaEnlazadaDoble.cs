using System;

public class ListaEnlazadaDoble
{
    private NodoDobleEnlazado? inicio;
    private NodoDobleEnlazado? fin;

    public ListaEnlazadaDoble()
    {
        inicio = null;
        fin = null;
    }

    public void RecorrerAdelante()
    {
        if (inicio == null)
        {
            Console.WriteLine("Lista vacía.");
            return;
        }

        NodoDobleEnlazado? actual = inicio;
        Console.Write("Inicio -> ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " <-> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    public void RecorrerAtras()
    {
        if (fin == null)
        {
            Console.WriteLine("Lista vacía.");
            return;
        }

        NodoDobleEnlazado? actual = fin;
        Console.Write("Fin -> ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " <-> ");
            actual = actual.Anterior;
        }
        Console.WriteLine("null");
    }

    public void InsertarInicio(int valor)
    {
        NodoDobleEnlazado nuevo = new NodoDobleEnlazado(valor);
        if (inicio == null)
        {
            inicio = fin = nuevo;
        }
        else
        {
            nuevo.Siguiente = inicio;
            inicio.Anterior = nuevo;
            inicio = nuevo;
        }
    }

    public void InsertarFinal(int valor)
    {
        NodoDobleEnlazado nuevo = new NodoDobleEnlazado(valor);
        if (fin == null)
        {
            inicio = fin = nuevo;
        }
        else
        {
            fin.Siguiente = nuevo;
            nuevo.Anterior = fin;
            fin = nuevo;
        }
    }

    public void EliminarInicio()
    {
        if (inicio == null)
        {
            Console.WriteLine("No hay nodos para eliminar.");
            return;
        }
        if (inicio == fin)
        {
            inicio = fin = null;
        }
        else
        {
            inicio = inicio.Siguiente;
            inicio!.Anterior = null;
        }
        Console.WriteLine("Nodo del inicio eliminado.");
    }

    public void EliminarFinal()
    {
        if (fin == null)
        {
            Console.WriteLine("No hay nodos para eliminar.");
            return;
        }
        if (inicio == fin)
        {
            inicio = fin = null;
        }
        else
        {
            fin = fin.Anterior;
            fin!.Siguiente = null;
        }
        Console.WriteLine("Nodo del final eliminado.");
    }

    public void EliminarEn(int posicion)
    {
        if (inicio == null)
        {
            Console.WriteLine("Lista vacía.");
            return;
        }

        if (posicion == 1)
        {
            EliminarInicio();
            return;
        }

        NodoDobleEnlazado? actual = inicio;
        int indice = 1;

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

        if (actual == fin)
        {
            EliminarFinal();
            return;
        }

        actual.Anterior!.Siguiente = actual.Siguiente;
        actual.Siguiente!.Anterior = actual.Anterior;

        Console.WriteLine($"Nodo en la posición {posicion} eliminado.");
    }

    public void BuscarElemento(int valor)
    {
        NodoDobleEnlazado? actual = inicio;
        int pos = 1;

        while (actual != null)
        {
            if (actual.Valor == valor)
            {
                Console.WriteLine($"Elemento {valor} encontrado en la posición {pos}.");
                return;
            }
            actual = actual.Siguiente;
            pos++;
        }

        Console.WriteLine($"Elemento {valor} no encontrado.");
    }

    public int Tamaño()
    {
        int contador = 0;
        NodoDobleEnlazado? actual = inicio;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public bool Vacia()
    {
        return inicio == null;
    }

    public void Limpiar()
    {
        inicio = fin = null;
        Console.WriteLine("Lista reiniciada.");
    }
}
