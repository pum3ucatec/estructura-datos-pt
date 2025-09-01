using System;

namespace ListaSimpleApp
{
    class Nodo
    {
        public int dato;
        public Nodo? siguiente; // puede ser null

        public Nodo(int valor)
        {
            dato = valor;
            siguiente = null;
        }
    }
}
