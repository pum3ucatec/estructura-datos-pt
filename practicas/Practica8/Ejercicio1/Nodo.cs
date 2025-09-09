
using System;

/// Clase Nodo que representa cada elemento de la lista enlazada.
/// Contiene un dato entero y una referencia al siguiente nodo.
public class Nodo
{
    public int Dato { get; set; }
    public Nodo? Siguiente { get; set; }

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}