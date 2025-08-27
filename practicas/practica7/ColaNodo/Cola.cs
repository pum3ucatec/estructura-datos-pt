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

        public void Size()
        {
            Console.WriteLine($"Tamaño actual de la cola: {tamaño}");
        }
    }
}
