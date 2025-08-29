using System;

namespace ColaNodo
{
    public class Cola
    {
        private Nodo root; // Inicio de la lista

        public Cola()
        {
            root = null;
        }

        // Insertar al final
        public void Enqueue(string valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (IsEmpty())
            {
                root = nuevo;
            }
            else
            {
                Nodo actual = root;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }

            Console.WriteLine($"Se insertó: {valor}");
        }

        // Eliminar del inicio
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.WriteLine($"Se eliminó: {root.Dato}");
            root = root.Siguiente;
        }

        // Eliminar en una posición específica
        public void EliminarEnPosicion(int posicion)
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicion < 0)
            {
                Console.WriteLine("La posición no puede ser negativa.");
                return;
            }

            if (posicion == 0)
            {
                Console.WriteLine($"Se eliminó: {root.Dato} en posición {posicion}");
                root = root.Siguiente;
                return;
            }

            Nodo actual = root;
            Nodo anterior = null;
            int indice = 0;

            while (actual != null && indice < posicion)
            {
                anterior = actual;
                actual = actual.Siguiente;
                indice++;
            }

            if (actual == null)
            {
                Console.WriteLine("La posición excede el tamaño de la lista.");
            }
            else
            {
                Console.WriteLine($"Se eliminó: {actual.Dato} en posición {posicion}");
                anterior.Siguiente = actual.Siguiente;
            }
        }

        // Mostrar lista
        public void View()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = root;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // Ver si está vacía
        public bool IsEmpty()
        {
            return root == null;
        }

        // Ver primer elemento
        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("La lista está vacía.");
            else
                Console.WriteLine($"Primer elemento: {root.Dato}");
        }

        // Insertar al principio
        public void InsertarAlPrincipio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.Siguiente = root;
            root = nuevo;

            Console.WriteLine($"Se insertó al principio: {valor}");
        }

        // Contar elementos
        public void Count()
        {
            int contador = 0;
            Nodo actual = root;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            Console.WriteLine($"Cantidad de elementos: {contador}");
        }

        // Buscar un elemento
        public void Buscar(string valor)
        {
            Nodo actual = root;
            int posicion = 0;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    Console.WriteLine($"El elemento '{valor}' está en la posición {posicion}.");
                    encontrado = true;
                    break;
                }
                actual = actual.Siguiente;
                posicion++;
            }

            if (!encontrado)
                Console.WriteLine($"El elemento '{valor}' no está en la lista.");
        }
    }
}
