using System;

namespace Pregunta1
{
    public class Lista
    {
        private Nodo inicio;

        public Lista()
        {
            inicio = null;

            // Valores iniciales
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
    }
}
