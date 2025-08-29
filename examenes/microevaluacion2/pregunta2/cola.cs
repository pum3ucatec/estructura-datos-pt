using System;
using System.Collections.Generic;

namespace Pregunta2
{
    public class Cola
    {
        private Nodo? frente;

        public Cola()
        {
            frente = null;
        }

        public void InsertarAlFinal(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (frente == null)
            {
                frente = nuevoNodo;
            }
            else
            {
                Nodo actual = frente;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo actual = frente;
            int pos = 1;
            Console.Write("Elementos en la lista: ");
            while (actual != null)
            {
                Console.Write($"[{pos}:{actual.Dato}] ");
                pos++;
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        public void CargarInicial(string[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                InsertarAlFinal(valores[i]);
            }
        }

        // ✅ Método corregido
        public void EliminarAlrededor(string valor)
        {
            if (frente == null) return;

            Nodo? actual = frente;
            int pos = 1;
            int? posEncontrada = null;

            // Buscar la posición del valor
            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    posEncontrada = pos;
                    break;
                }
                actual = actual.Siguiente;
                pos++;
            }

            if (posEncontrada == null)
            {
                Console.WriteLine($"El valor '{valor}' no existe en la lista.");
                return;
            }

            // Guardar posiciones a eliminar (alrededor)
            List<int> posicionesEliminar = new List<int>();

            if (posEncontrada.Value - 1 >= 1)
                posicionesEliminar.Add(posEncontrada.Value - 1); // anterior

            if (posEncontrada.Value + 1 <= ContarNodos())
                posicionesEliminar.Add(posEncontrada.Value + 1); // siguiente

            // Eliminar de atrás hacia adelante
            posicionesEliminar.Sort();
            posicionesEliminar.Reverse();

            foreach (int p in posicionesEliminar)
            {
                EliminarEnPosicion(p);
            }
        }

        private int ContarNodos()
        {
            int count = 0;
            Nodo? actual = frente;
            while (actual != null)
            {
                count++;
                actual = actual.Siguiente;
            }
            return count;
        }

        private void EliminarEnPosicion(int posicion)
        {
            if (frente == null) return;

            if (posicion == 1)
            {
                Console.WriteLine($"Se eliminó '{frente.Dato}' en la posición {posicion}");
                frente = frente.Siguiente;
                return;
            }

            Nodo? actual = frente;
            int pos = 1;
            while (actual != null && pos < posicion - 1)
            {
                actual = actual.Siguiente;
                pos++;
            }

            if (actual != null && actual.Siguiente != null)
            {
                Console.WriteLine($"Se eliminó '{actual.Siguiente.Dato}' en la posición {posicion}");
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }
    }
}
