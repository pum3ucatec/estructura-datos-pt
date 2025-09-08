using System;
using System.Collections.Generic;
using System.Text;

namespace ListasSimplesConMenu
{

    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }


    public class SinglyLinkedList
    {
        private Node? _head;

        public bool IsEmpty => _head == null;

        public void InsertAtBeginning(int value)
        {
            var node = new Node(value) { Next = _head };
            _head = node;
        }

        public void InsertAtEnd(int value)
        {
            var node = new Node(value);
            if (_head == null)
            {
                _head = node;
                return;
            }

            var current = _head;
            while (current!.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        }

 
        public bool InsertAfter(int targetValue, int newValue)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Data == targetValue)
                {
                    var node = new Node(newValue) { Next = current.Next };
                    current.Next = node;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }


        public bool DeleteFirst()
        {
            if (_head == null) return false;
            _head = _head.Next;
            return true;
        }

       
        public bool DeleteByValue(int value)
        {
            if (_head == null) return false;

            if (_head.Data == value)
            {
                _head = _head.Next;
                return true;
            }

            var prev = _head;
            var current = _head.Next;

            while (current != null)
            {
                if (current.Data == value)
                {
                    prev.Next = current.Next;
                    return true;
                }
                prev = current;
                current = current.Next;
            }
            return false;
        }

      
        public bool DeleteAtPosition(int index)
        {
            if (index < 0 || _head == null) return false;

            if (index == 0)
            {
                _head = _head.Next;
                return true;
            }

            var prev = _head;
            var current = _head.Next;
            int i = 1;

            while (current != null)
            {
                if (i == index)
                {
                    prev.Next = current.Next;
                    return true;
                }
                prev = current;
                current = current.Next;
                i++;
            }
            return false;
        }

       
        public int IndexOf(int value)
        {
            int index = 0;
            var current = _head;
            while (current != null)
            {
                if (current.Data == value) return index;
                current = current.Next;
                index++;
            }
            return -1;
        }

        public int Count()
        {
            int count = 0;
            var current = _head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void Clear() => _head = null;

        public void Reverse()
        {
            Node? prev = null;
            var current = _head;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            _head = prev;
        }

        public IEnumerable<int> ToEnumerable()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            if (_head == null) return "[ vacía ]";

            var sb = new StringBuilder();
            var current = _head;
            while (current != null)
            {
                sb.Append(current.Data);
                if (current.Next != null) sb.Append(" -> ");
                current = current.Next;
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var list = new SinglyLinkedList();

            while (true)
            {
                ShowMenu();
                Console.Write("Elige una opción: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;

                Console.WriteLine();
                switch (input.Trim())
                {
                    case "1":
                        int vIni = ReadInt("Valor a insertar al INICIO: ");
                        list.InsertAtBeginning(vIni);
                        Console.WriteLine("OK. Lista: " + list);
                        break;

                    case "2":
                        int vEnd = ReadInt("Valor a insertar al FINAL: ");
                        list.InsertAtEnd(vEnd);
                        Console.WriteLine("OK. Lista: " + list);
                        break;

                    case "3":
                        int objetivo = ReadInt("Insertar DESPUÉS de la primera ocurrencia del valor: ");
                        int nuevo = ReadInt("Nuevo valor: ");
                        bool ins = list.InsertAfter(objetivo, nuevo);
                        Console.WriteLine(ins ? "Insertado." : "No se encontró el valor objetivo.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "4":
                        bool delFirst = list.DeleteFirst();
                        Console.WriteLine(delFirst ? "Primer nodo eliminado." : "La lista está vacía.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "5":
                        int delVal = ReadInt("Eliminar por VALOR (primera coincidencia): ");
                        bool delByVal = list.DeleteByValue(delVal);
                        Console.WriteLine(delByVal ? "Eliminado." : "Valor no encontrado.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "6":
                        int pos = ReadInt("Eliminar por POSICIÓN (0-based): ");
                        bool delByPos = list.DeleteAtPosition(pos);
                        Console.WriteLine(delByPos ? "Eliminado." : "Posición inválida.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "7":
                        int search = ReadInt("Buscar valor: ");
                        int idx = list.IndexOf(search);
                        Console.WriteLine(idx >= 0 ? $"Encontrado en índice {idx}." : "No encontrado.");
                        break;

                    case "8":
                        Console.WriteLine("Elementos: " + list);
                        break;

                    case "9":
                        Console.WriteLine("Cantidad de nodos: " + list.Count());
                        break;

                    case "10":
                        list.Reverse();
                        Console.WriteLine("Lista invertida.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "11":
                        list.Clear();
                        Console.WriteLine("Lista vaciada.");
                        Console.WriteLine("Lista: " + list);
                        break;

                    case "0":
                        Console.WriteLine("¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("***** MENÚ *****");
            Console.WriteLine("1) Insertar al inicio");
            Console.WriteLine("2) Insertar al final");
            Console.WriteLine("3) Insertar después de un valor");
            Console.WriteLine("4) Eliminar primero");
            Console.WriteLine("5) Eliminar por valor");
            Console.WriteLine("6) Eliminar por posición (0-based)");
            Console.WriteLine("7) Buscar valor (devuelve índice)");
            Console.WriteLine("8) Mostrar lista");
            Console.WriteLine("9) Contar nodos");
            Console.WriteLine("10) Invertir lista");
            Console.WriteLine("11) Vaciar lista");
            Console.WriteLine("0) Salir");
            Console.WriteLine();
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (int.TryParse(s, out int value)) return value;
                Console.WriteLine("Entrada inválida. Intenta de nuevo.");
            }
        }
    }
}

