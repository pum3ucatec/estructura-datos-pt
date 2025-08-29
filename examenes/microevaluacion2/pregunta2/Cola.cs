using System;

namespace Pregunta1
{
    public class Lista
    {
        private Nodo inicio;

        public Lista()
        {
            inicio = null;
            string[] iniciales = { "A", "P", "Q", "R", "Y", "E" };
            foreach (string val in iniciales)
                InsertarInicio(val);
        }

        // Insertar al inicio
        public void InsertarInicio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = inicio;
            inicio = nuevo;
        }

        // Mostrar lista
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.Write("Elementos en la lista: ");
            Nodo actual = inicio;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        // Eliminar alrededor de un nodo con cierto valor
        public void EliminarAlrededor(string valor)
        {
            if (inicio == null || inicio.Siguiente == null)
            {
                Console.WriteLine("La lista no tiene suficientes elementos.");
                return;
            }

            Nodo actual = inicio;
            Nodo anterior = null;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    // Eliminar nodo anterior (si existe)
                    if (anterior != null)
                    {
                        // buscamos nodo antes del anterior
                        Nodo antesDeAnterior = inicio;
                        if (antesDeAnterior == anterior)
                        {
                            inicio = actual; // borramos al inicio
                        }
                        else
                        {
                            while (antesDeAnterior != null && antesDeAnterior.Siguiente != anterior)
                                antesDeAnterior = antesDeAnterior.Siguiente;

                            if (antesDeAnterior != null)
                                antesDeAnterior.Siguiente = actual;
                        }
                        Console.WriteLine($"Se eliminó el nodo anterior a '{valor}'.");
                    }

                    // Eliminar nodo siguiente (si existe)
                    if (actual.Siguiente != null)
                    {
                        Nodo aEliminar = actual.Siguiente;
                        actual.Siguiente = aEliminar.Siguiente;
                        Console.WriteLine($"Se eliminó el nodo siguiente a '{valor}'.");
                    }

                    return;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            Console.WriteLine($"El valor '{valor}' no se encontró en la lista.");
        }
    }
}
