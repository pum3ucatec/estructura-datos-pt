using System;

namespace ListaSimpleApp
{
    public class ListaSimple
    {
        private Nodo? inicio;

        public void Agregar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (inicio == null)
            {
                inicio = nuevo;
                return;
            }

            Nodo actual = inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }

        public void Imprimir()
        {
            if (inicio == null)
            {
                Console.WriteLine(" La lista no contiene elementos.");
                return;
            }

            Nodo? temporal = inicio;
            while (temporal != null)
            {
                Console.Write(temporal.Dato + " -> ");
                temporal = temporal.Siguiente;
            }
            Console.WriteLine("NULL");
        }

        public void Quitar(int valor)
        {
            if (inicio == null) return;

            if (inicio.Dato == valor)
            {
                inicio = inicio.Siguiente;
                return;
            }

            Nodo? actual = inicio;
            while (actual.Siguiente != null && actual.Siguiente.Dato != valor)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }
    }
}
