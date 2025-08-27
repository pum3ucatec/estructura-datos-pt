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
            if (IsFull())
            {
                Console.WriteLine(" La cola está llena, no se puede insertar.");
                return;
            }

            Rear = (Rear + 1) % Size;
            Elements[Rear] = value;
            Count++;
            Console.WriteLine($"Insertado {value} en la cola.");
        }

        // Es para eliminar un elemento del frente
        public char Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía, no se puede eliminar.");
                return '\0';
            }

            char value = Elements[Front];
            Front = (Front + 1) % Size;
            Count--;
            Console.WriteLine($"Eliminado {value} de la cola.");
            return value;
        }

        
        // Funcion peek es para Ver el frente sin eliminarlo
        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return '\0';
            }
            return Elements[Front];
        }

        // Función Count es para ver la cantidad de elementos actuales

        public int GetCount()
        {
            return Count;
        }

        // Funcion length es para determinar la capacidad maxima de la cola

        public int GetLength()
        {
            return Size;
        }

        // Funcion contains es para ver si un elemento existe en la cola

        public bool Contains(char value)
        {
            for (int i = 0; i < Count; i++)
            {
                int index = (Front + i) % Size;
                if (Elements[index] == value)
                    return true;
            }
            return false;
        }

        // Funcion isEmpty es para ver si la cola esta vacia
        public bool IsEmpty()
        {
            return Count == 0;
        }

        // Funcion is Full es para ver si la cola esta llena

        public bool IsFull()
        {
            return Count == Size;
        }
        // Mostrar cola
        public void Mostrar()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
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
