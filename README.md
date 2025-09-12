# 📘 Implementación de una Pila en C#

Este programa implementa una **pila (Stack)** usando **listas enlazadas** en C#.  
La pila es una estructura de datos **LIFO (Last In, First Out)**, es decir, el último elemento en entrar es el primero en salir.  

---

## 🧩 Clase `Nodo`
Representa cada elemento de la pila.

```csharp
class Nodo
{
    public int Valor { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}
Valor: guarda el número del nodo.

Siguiente: referencia al siguiente nodo en la pila.

El constructor inicializa el nodo con el valor y deja Siguiente en null.
```
🧩 Clase Pila
Contiene toda la lógica de la pila.

```csharp
class Pila
{
    private Nodo cima;   // Apunta al último elemento insertado
    private int tamaño;  // Cantidad de elementos

🔹 Constructor
Inicializa la pila vacía:

public Pila()
{
    cima = null;
    tamaño = 0;
}

🔹 Push(int valor)
Agrega un elemento en la cima de la pila.
El nuevo nodo se enlaza con la pila existente.

public void Push(int valor)
{
    Nodo nuevoNodo = new Nodo(valor);
    nuevoNodo.Siguiente = cima;
    cima = nuevoNodo;
    tamaño++;
}

🔹 Pop()
Elimina y devuelve el elemento en la cima.
Si la pila está vacía, devuelve -1.

public int Pop()
{
    if (IsEmpty())
    {
        Console.WriteLine("La pila está vacía.");
        return -1;
    }

    int valorEliminado = cima.Valor;
    cima = cima.Siguiente;
    tamaño--;
    return valorEliminado;
}

🔹 Peek()
Muestra el valor de la cima sin eliminarlo.

public int Peek()
{
    if (IsEmpty()) return -1;
    return cima.Valor;
}
🔹 IsEmpty()
Verifica si la pila no contiene elementos.

public bool IsEmpty()
{
    return cima == null;
}

🔹 Mostrar()
Recorre la pila desde la cima hasta el fondo e imprime sus valores.

public void Mostrar()
{
    if (IsEmpty())
    {
        Console.WriteLine("La pila está vacía.");
        return;
    }

    Nodo actual = cima;
    while (actual != null)
    {
        Console.WriteLine(actual.Valor);
        actual = actual.Siguiente;
    }
}

🔹 Propiedad Tamaño
Devuelve la cantidad de elementos de la pila.

public int Tamaño
{
    get { return tamaño; }
}
```
🧩 Clase Principal
Contiene el método Main con un menú interactivo para probar la pila.

+ Opciones disponibles:

+ Mostrar pila

+ Insertar elemento (Push)

+ Eliminar elemento (Pop)

+ Ver cima (Peek)

+ Verificar si está vacía

+ Salir del programa

```csharp
class Principal
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();
        int opcion;
        
        do
        {
            Console.WriteLine("===== MENÚ PILA =====");
            Console.WriteLine("1. Mostrar pila");
            Console.WriteLine("2. Insertar (Push)");
            Console.WriteLine("3. Eliminar (Pop)");
            Console.WriteLine("4. Ver cima (Peek)");
            Console.WriteLine("5. Verificar si está vacía");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            // Manejo de opciones aquí...
        } while (opcion != 0);
    }
}
```
⚙️ Funcionamiento General
La pila comienza vacía.

Cada Push agrega un nuevo nodo en la cima.

Cada Pop elimina el nodo superior.

Peek permite ver el último insertado sin borrarlo.

El menú facilita la interacción paso a paso con la pila.
