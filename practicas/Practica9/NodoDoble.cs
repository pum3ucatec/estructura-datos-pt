using System;

/// Clase NodoDoble que representa un nodo en la lista doblemente enlazada.
/// Contiene un dato entero, un puntero al nodo anterior y al siguiente.
public class NodoDoble
{
    public int Dato { get; set; }
    public NodoDoble Anterior { get; set; }
    public NodoDoble Siguiente { get; set; }

    public NodoDoble(int dato)
    {
        Dato = dato;
        Anterior = null;
        Siguiente = null;
    }
}