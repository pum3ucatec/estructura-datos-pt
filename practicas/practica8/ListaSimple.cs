using System;

namespace ListaSimpleApp
{
    public class ListaSimple
    {
        private Nodo? primero;

        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (primero == null)
            {
                primero = nuevo;
                return;
            }

            Nodo actual = primero;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }

        public void Mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo? actual = primero;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        public void Eliminar(int dato)
        {
            if (primero == null) return;

            if (primero.Dato == dato)
            {
                primero = primero.Siguiente;
                return;
            }

            Nodo? actual = primero;
            while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
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
