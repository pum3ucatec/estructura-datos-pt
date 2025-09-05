# 📚 Proyecto: Implementación de una Pila en C#

Este proyecto implementa la **estructura de datos Pila (Stack)** en C#, junto con un **menú interactivo** que permite al usuario realizar operaciones básicas sobre la pila.

---

## 📌 ¿Qué es una pila?
Una **pila** es una estructura de datos lineal que sigue el principio **LIFO (Last In, First Out)**:  
- El **último** elemento en entrar es el **primero** en salir.  
- Ejemplo: una pila de platos, donde el último que se coloca arriba es el primero en retirarse.  

---

## ⚙️ Operaciones implementadas
El programa incluye las siguientes operaciones sobre la pila:  

- **`Push`** → Insertar un elemento en la cima de la pila.  
- **`Pop`** → Eliminar el elemento en la cima de la pila.  
- **`Peek`** → Ver el elemento en la cima sin eliminarlo.  
- **`IsEmpty`** → Verificar si la pila está vacía.  
- **`Mostrar`** → Mostrar todos los elementos de la pila.  

Además, se incluye un **menú interactivo en consola** para que el usuario pueda ejecutar estas operaciones.

---

## 📂 Estructura del código
El proyecto está compuesto por **dos clases** dentro de un mismo archivo `Program.cs`:

1. **Clase `Pila`** → Implementa la lógica de la estructura de datos.  
2. **Clase `Principal` (con `Main`)** → Permite al usuario interactuar mediante un menú en consola.  

---

## 💻 Código completo
```csharp
using System;
using System.Collections.Generic;

// Clase que implementa la estructura de Pila
class Pila
{
    private List<int> elementos = new List<int>();

    public Pila()
    {
        elementos = new List<int>();
    }

    // Insertar un elemento en la pila
    public void Push(int valor)
    {
        elementos.Add(valor);
        Console.WriteLine($"Se insertó {valor} en la pila.");
    }

    // Eliminar el último elemento (cima)
    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía, no se puede eliminar.");
            return -1;
        }

        int valor = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        Console.WriteLine($"Se eliminó {valor} de la pila.");
        return valor;
    }

    // Ver el último elemento sin eliminarlo
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return -1;
        }
        return elementos[elementos.Count - 1];
    }

    // Mostrar todos los elementos de la pila
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("\nElementos en la pila:");
        for (int i = elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(elementos[i]);
        }
    }

    // Verificar si la pila está vacía
    public bool IsEmpty()
    {
        return elementos.Count == 0;
    }
}

// Clase principal con menú interactivo
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
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    pila.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        pila.Push(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    pila.Pop();
                    break;
                case 4:
                    int cima = pila.Peek();
                    if (cima != -1)
                        Console.WriteLine($"Elemento en la cima: {cima}");
                    break;
                case 5:
                    Console.WriteLine(pila.IsEmpty() ? "La pila está vacía." : "La pila NO está vacía.");
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }
}
``` 
===== MENÚ PILA =====
1. Mostrar pila
2. Insertar (Push)
3. Eliminar (Pop)
4. Ver cima (Peek)
5. Verificar si está vacía
0. Salir
Seleccione una opción: 2
Ingrese el número a insertar: 10
Se insertó 10 en la pila.

===== MENÚ PILA =====
Seleccione una opción: 2
Ingrese el número a insertar: 20
Se insertó 20 en la pila.

===== MENÚ PILA =====
Seleccione una opción: 1

Elementos en la pila:
20
10

===== MENÚ PILA =====
Seleccione una opción: 4
Elemento en la cima: 20

===== MENÚ PILA =====
Seleccione una opción: 3
Se eliminó 20 de la pila.

===== MENÚ PILA =====
Seleccione una opción: 5
La pila NO está vacía.

===== MENÚ PILA =====
Seleccione una opción: 0
Saliendo del programa...
--- 