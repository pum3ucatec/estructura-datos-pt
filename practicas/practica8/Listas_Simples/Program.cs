// Lista Simple
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas_Simples
{
    class Nodo
    {
        public int dato;
        public Nodo siguiente;
    }

    class Lista
    {
        private Nodo primero;

        public Lista()
        {
            primero = null;
        }

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = valor;
            nuevo.siguiente = primero;
            primero = nuevo;
        }

        public void Mostrar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.siguiente;
            }
        }

        public bool Buscar(int valor)
        {
            Nodo actual = primero;
            while (actual != null)
            {
                if (actual.dato == valor)
                    return true;
                actual = actual.siguiente;
            }
            return false;
        }

        public void Eliminar(int valor)
        {
            if (primero == null) return;

            if (primero.dato == valor)
            {
                primero = primero.siguiente;
                return;
            }

            Nodo actual = primero;
            while (actual.siguiente != null && actual.siguiente.dato != valor)
            {
                actual = actual.siguiente;
            }

            if (actual.siguiente != null)
            {
                actual.siguiente = actual.siguiente.siguiente;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(30);

            Console.WriteLine("Elementos en la lista:");
            lista.Mostrar();

            Console.WriteLine("Buscar 20: " + lista.Buscar(20));
            Console.WriteLine("Buscar 40: " + lista.Buscar(40));

            lista.Eliminar(20);
            Console.WriteLine("Elementos en la lista después de eliminar 20:");
            lista.Mostrar();
        }
    }
}