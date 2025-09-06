using System;

namespace ListaSimpleApp
{
    class ListaSimple
    {
        private Nodo? cabeza;

        public ListaSimple()
        {
            cabeza = null;
        }

        public void InsertarInicio(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.siguiente = cabeza;
            cabeza = nuevo;
        }

        public void InsertarFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo aux = cabeza;
                while (aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                aux.siguiente = nuevo;
            }
        }

        public void Eliminar(int valor)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (cabeza.dato == valor)
            {
                cabeza = cabeza.siguiente;
                return;
            }

            Nodo aux = cabeza;
            while (aux.siguiente != null && aux.siguiente.dato != valor)
            {
                aux = aux.siguiente;
            }

            if (aux.siguiente != null)
            {
                aux.siguiente = aux.siguiente.siguiente;
            }
            else
            {
                Console.WriteLine("El valor no se encontró en la lista.");
            }
        }

        public bool Buscar(int valor)
        {
            Nodo? aux = cabeza;
            while (aux != null)
            {
                if (aux.dato == valor) return true;
                aux = aux.siguiente;
            }
            return false;
        }

        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo? aux = cabeza;
            Console.Write("Lista: ");
            while (aux != null)
            {
                Console.Write(aux.dato + " -> ");
                aux = aux.siguiente;
            }
            Console.WriteLine("null");
        }
    }
}
