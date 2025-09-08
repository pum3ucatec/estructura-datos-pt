using System;

namespace ColaNodo
{
    public class Cola
    {
        public Nodo Front { get; private set; }
        public Nodo Rear { get; private set; }
        private int tamaño;

        public Cola()
        {
            Front = null;
            Rear = null;
            tamaño = 0;
        }

        public void Enqueue(string name)
        {
            Nodo nodo = new Nodo(name);

            if (Front == null)
            {
                Front = nodo;
                Rear = nodo;
            }
            else
            {
                Rear.Next = nodo;
                Rear = nodo;
            }

            tamaño++;
            Console.WriteLine($"'{name}' insertado en la cola.");
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía. No se puede eliminar.");
                return;
            }

            Console.WriteLine($"'{Front.Name}' eliminado de la cola.");
            Front = Front.Next;
            tamaño--;

            if (Front == null)
            {
                Rear = null;
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
            }
            else
            {
                Console.WriteLine($"Elemento en el frente: '{Front.Name}'");
            }
        }

        public bool IsEmpty()
        {
            return Front == null;
        }

        public void View()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.WriteLine("Elementos en la cola:");
            Nodo current = Front;

            while (current != null)
            {
                Console.Write($"{current.Name} | ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void Clear()
        {
            Front = null;
            Rear = null;
            tamaño = 0;
            Console.WriteLine("La cola ha sido vaciada.");
        }

        public void Count()
        {
            Console.WriteLine($"Tamaño actual de la cola: {tamaño}");
        }

        public void Buscar(string name)
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Nodo current = Front;
            int posicion = 0;
            bool encontrado = false;

            while (current != null)
            {
                if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Elemento '{name}' encontrado en la posición {posicion}.");
                    encontrado = true;
                    break;
                }
                current = current.Next;
                posicion++;
            }

            if (!encontrado)
            {
                Console.WriteLine($"Elemento '{name}' no se encontró en la cola.");
            }
        }

        public void SacarElemento()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            Console.Write("Ingrese el nombre del elemento a eliminar: ");
            string name = Console.ReadLine();

            Nodo actual = Front;
            Nodo anterior = null;

            while (actual != null)
            {
                if (actual.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (anterior == null)
                    {
                        // Eliminar el primero
                        Front = actual.Next;
                        if (Front == null)
                            Rear = null;
                    }
                    else
                    {
                        anterior.Next = actual.Next;
                        if (actual == Rear)
                            Rear = anterior;
                    }

                    tamaño--;
                    Console.WriteLine($"Elemento '{name}' eliminado de la cola.");
                    return;
                }

                anterior = actual;
                actual = actual.Next;
            }

            Console.WriteLine($"Elemento '{name}' no se encontró en la cola.");
        }
    }
}