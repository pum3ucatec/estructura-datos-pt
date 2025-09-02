# 📘 Lista Enlazada Simple en C# - Eliminar el anterior y el siguiente de un nodo

Este ejemplo muestra cómo trabajar con una **lista enlazada simple** en C#,  
implementando la función de **eliminar el nodo anterior y el siguiente** a un nodo con un valor específico.

---

## 🔹 Estructura del Nodo
Cada nodo de la lista contiene:
- Un **valor** (`data`)
- Una **referencia al siguiente nodo** (`next`)

```csharp
class Node
{
    public int data;      // Dato del nodo
    public Node next;     // Apuntador al siguiente nodo

    public Node(int value)
    {
        data = value;
        next = null;
    }
}
```

## 🔹 Clase Lista
La lista contiene la referencia al primer nodo (head) y métodos para:

Insertar al final

Mostrar la lista

Eliminar el anterior y el siguiente de un nodo dado

```csharp

class LinkedList
{
    private Node head;

    // Insertar un nodo al final
    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }

    // Mostrar la lista
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("null");
    }

    // Eliminar anterior y siguiente de un nodo con cierto valor
    public void DeletePrevAndNext(int value)
    {
        if (head == null || head.next == null) return;

        Node prev = null;
        Node current = head;

        while (current != null && current.data != value)
        {
            prev = current;
            current = current.next;
        }

        if (current == null) return; // No encontrado

        // Eliminar anterior
        if (prev != null && prev != head)
        {
            Node temp = head;
            while (temp.next != prev)
            {
                temp = temp.next;
            }
            temp.next = current;
        }
        else if (prev == head)
        {
            head = current;
        }

        // Eliminar siguiente
        if (current.next != null)
        {
            current.next = current.next.next;
        }
    }
}
```
## 🔹 Programa Principal
El usuario inserta algunos nodos, los muestra y luego elimina el anterior y el siguiente de un valor específico.

```csharp

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Insertar valores
        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);
        list.Insert(50);

        Console.WriteLine("Lista original:");
        list.Display();

        // Eliminar anterior y siguiente de 30
        list.DeletePrevAndNext(30);

        Console.WriteLine("Lista después de eliminar anterior y siguiente de 30:");
        list.Display();
    }
}
```
## ✅ Ejemplo de Ejecución

Lista original:
10 -> 20 -> 30 -> 40 -> 50 -> null

Lista después de eliminar anterior y siguiente de 30:
10 -> 30 -> 50 -> null
```