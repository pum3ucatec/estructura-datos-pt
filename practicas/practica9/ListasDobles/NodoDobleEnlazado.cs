using System;

public class NodoDobleEnlazado
{
    public int Valor { get; set; }
    public NodoDobleEnlazado? Siguiente { get; set; }
    public NodoDobleEnlazado? Anterior { get; set; }

    public NodoDobleEnlazado(int valor)
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }
}
