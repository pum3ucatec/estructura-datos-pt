# practica 4  - Implementación de una Pila en C#

## 📌 Descripción
Este programa en C# implementa una **pila** utilizando la clase genérica `Stack<int>`.  
Permite al usuario realizar varias operaciones sobre la pila, como insertar, eliminar, ver la cima, mostrar el contenido y vaciar la pila, a través de un **menú interactivo**.

---

## 💻 Código

```csharp
using System;
using System.Collections.Generic;

class Pila
{
    private Stack<int> stack = new Stack<int>();

    public void Push(int valor)
    {
        stack.Push(valor);
        Console.WriteLine($"{valor} insertado en la pila.");
    }

    public void Pop()
    {
        if (!IsEmpty())
        {
            int eliminado = stack.Pop();
            Console.WriteLine($"{eliminado} eliminado de la pila.");
        }
        else
        {
            Console.WriteLine("La pila está vacía. No se puede eliminar.");
        }
    }

    public int Peek()
    {
        if (!IsEmpty())
            return stack.Peek();
        else
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Contenido de la pila:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }

    public void Clear()
    {
        stack.Clear();
    }
}

class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("6. Insertar varios elementos (Push N)");
            Console.WriteLine("7. Vaciar pila (Clear)");
            Co

📖 Explicación

La clase Pila encapsula la estructura de pila usando Stack<int> y proporciona métodos:

Push: insertar un elemento.

Pop: eliminar el elemento de la cima.

Peek: ver el elemento de la cima sin eliminarlo.

IsEmpty: verificar si la pila está vacía.

Mostrar: mostrar todos los elementos de la pila.

Clear: vaciar la pila.

La clase Principal contiene un menú interactivo que permite al usuario seleccionar la operación deseada.

Se manejan validaciones para entradas incorrectas y se muestra información clara en cada acción.

▶️ Ejemplo de ejecución

===== MENÚ PILA =====
1. Mostrar pila
2. Insertar (Push)
3. Eliminar (Pop)
4. Ver cima (Peek)
5. Verificar si está vacía
6. Insertar varios elementos (Push N)
7. Vaciar pila (Clear)
0. Salir
Seleccione una opción: 2
Ingrese el número a insertar: 10
10 insertado en la pila.

Seleccione una opción: 1
Contenido de la pila: 10