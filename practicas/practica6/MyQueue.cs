using System;

namespace Cola
{
    public class MyQueue
    {
        private char[] Elements;
        private int Size;
        private int Front;
        private int Rear;
        private int Count;

        public MyQueue(int N)
        {
            this.Elements = new char[N];
            this.Size = N;
            this.Front = 0;
            this.Rear = -1;
            this.Count = 0;
        }

        // Insertar un elemento
        public void Enqueue(char value)
        {
            if (Count == Size)
            {
                Console.WriteLine(" La cola está llena, no se puede insertar.");
                return;
            }

            Rear = (Rear + 1) % Size;
            Elements[Rear] = value;
            Count++;
            Console.WriteLine($" Insertado {value} en la cola.");
        }

        // Insertar varios elementos
        public void EnqueueMultiple(char[] values)
        {
            foreach (var value in values)
            {
                if (Count == Size)
                {
                    Console.WriteLine(" La cola está llena, no se pueden insertar más elementos.");
                    break;
                }
                Enqueue(value);
            }
        }

        // Eliminar elemento
        public char Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" La cola está vacía, no se puede eliminar.");
                return '\0';
            }

            char value = Elements[Front];
            Front = (Front + 1) % Size;
            Count--;
            Console.WriteLine($" Eliminado {value} de la cola.");
            return value;
        }

        // Ver frente
        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" La cola está vacía.");
                return '\0';
            }
            return Elements[Front];
        }

        // Verificar si está vacía
        public bool IsEmpty()
        {
            return Count == 0;
        }

        // Mostrar cola
        public void Mostrar()
        {
            if (IsEmpty())
            {
                Console.WriteLine(" La cola está vacía.");
                return;
            }

            Console.WriteLine("\nElementos en la cola:");
            for (int i = 0; i < Count; i++)
            {
                int index = (Front + i) % Size;
                Console.Write($"{Elements[index]} ");
            }
            Console.WriteLine();
        }
    }
}