using System;

namespace ColaNodo
{
    public class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        // Agregar al final
        public void Enqueue(string valor)
        {
            Nodo nuevo = new Nodo(valor);

            if (IsEmpty())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }

            Console.WriteLine($"Se insertó: {valor}");
        }

        // Quitar del principio
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista está vacía, no se puede eliminar.");
                return;
            }

            Console.WriteLine($"Se eliminó: {primero.Dato}");
            primero = primero.Siguiente;

            if (primero == null)
            {
                ultimo = null;
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

            Nodo actual = primero;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // Ver primer elemento
        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("La lista está vacía.");
            else
                Console.WriteLine($"Primer elemento: {primero.Dato}");
        }

        // Verificar si está vacía
        public bool IsEmpty()
        {
            return primero == null;
        }

        // Insertar al principio
        public void InsertarAlPrincipio(string valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (IsEmpty())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }

            Console.WriteLine($"Se insertó al principio: {valor}");
        }

        // Contar elementos
        public void Count()
        {
            int contador = 0;
            Nodo actual = primero;

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
            Nodo actual = primero;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    encontrado = true;
                    break;
                }
                actual = actual.Siguiente;
            }

            Console.WriteLine(encontrado
                ? $"El elemento '{valor}' SÍ está en la lista."
                : $"El elemento '{valor}' NO está en la lista.");
        }

        // Sacar un elemento (último)
        public void SacarElemento()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La lista está vacía, no se puede sacar.");
                return;
            }

            if (primero == ultimo)
            {
                Console.WriteLine($"Se sacó: {primero.Dato}");
                primero = null;
                ultimo = null;
                return;
            }

            Nodo actual = primero;
            while (actual.Siguiente != ultimo)
            {
                actual = actual.Siguiente;
            }

            Console.WriteLine($"Se sacó: {ultimo.Dato}");
            actual.Siguiente = null;
            ultimo = actual;
        }
    }
}

