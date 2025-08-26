using System;

namespace Practica6
{
    public class MyQueue
    {
        private char[] items;
        private int front;
        private int rear;
        private int count;

        public MyQueue(int size)
        {
            items = new char[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(char value)
        {
            if (IsFull())
            {
                Console.WriteLine("La cola está llena.");
                return;
            }
            rear = (rear + 1) % items.Length;
            items[rear] = value;
            count++;
            Console.WriteLine($"'{value}' agregado a la cola.");
        }

        public char Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return '\0';
            }
            char value = items[front];
            front = (front + 1) % items.Length;
            count--;
            Console.WriteLine($"'{value}' eliminado de la cola.");
            return value;
        }

        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return '\0';
            }
            return items[front];
        }

        public int Count()
        {
            return count;
        }

        public int Length()
        {
            return items.Length;
        }

        public bool Contains(char value)
        {
            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % items.Length;
                if (items[index] == value)
                    return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == items.Length;
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }
            Console.Write("Cola: ");
            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % items.Length;
                Console.Write(items[index] + " ");
            }
            Console.WriteLine();
        }
    }
}