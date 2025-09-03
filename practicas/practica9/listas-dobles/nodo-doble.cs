using System;

public class NodoDoble
{
    public int Dato;
    public NodoDoble? Siguiente;
    public NodoDoble? Anterior;

    public NodoDoble(int dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;

    }

}