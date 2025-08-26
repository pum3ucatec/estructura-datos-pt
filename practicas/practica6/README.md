# Documentación: 
# **COLAS**

Este proyecto implementa una **estructura de datos Cola (Queue)** con **8 operaciones principales**, y un programa principal que permite **probarlas desde un menú interactivo** en consola.

---

##  1. Clase `MyQueue`

Archivo: `MyQueue.cs`

###  Descripción

La clase `MyQueue` implementa una **cola circular** usando un **arreglo de caracteres** (`char[]`).
Se incluye toda la lógica necesaria para insertar, eliminar y consultar elementos.

### Código con explicación

```csharp
using System;

public class MyQueue
{
    private char[] Elements; // Arreglo donde se almacenan los elementos
    private int Size;        // Capacidad máxima de la cola
    private int Front;       // Índice del frente de la cola
    private int Rear;        // Índice del final de la cola
    private int Count;       // Número actual de elementos en la cola
```

---

###  **Constructor**

```csharp
    public MyQueue(int N)
    {
        this.Elements = new char[N]; // Crea un arreglo de tamaño N
        this.Size = N;               // Guarda la capacidad máxima
        this.Front = 0;              // El frente comienza en posición 0
        this.Rear = -1;              // El final empieza vacío
        this.Count = 0;              // No hay elementos al inicio
    }
```

---

###  **Operaciones de la Cola**

1. **Enqueue (Insertar al final)**

```csharp
    public void Enqueue(char item)
    {
        if (IsFull()) // Verifica si la cola está llena
        {
            Console.WriteLine("La cola está llena, no se puede insertar.");
            return;
        }
        Rear = (Rear + 1) % Size; // Movimiento circular
        Elements[Rear] = item;    // Insertar elemento
        Count++;                  // Aumentar cantidad
    }
```

2. **Dequeue (Eliminar del frente)**

```csharp
    public char Dequeue()
    {
        if (IsEmpty()) // Verifica si está vacía
        {
            Console.WriteLine("La cola está vacía, no se puede eliminar.");
            return '\0'; // Retorna vacío
        }
        char item = Elements[Front]; // Guarda el primer elemento
        Front = (Front + 1) % Size;  // Avanza el frente circular
        Count--;                     // Disminuye cantidad
        return item;
    }
```

3. **Peek (Ver el frente sin eliminar)**

```csharp
    public char Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return '\0';
        }
        return Elements[Front];
    }
```

4. **GetCount (Cantidad de elementos actuales)**

```csharp
    public int GetCount()
    {
        return Count;
    }
```

5. **GetSize (Capacidad máxima)**

```csharp
    public int GetSize()
    {
        return Size;
    }
```

6. **Contains (Buscar un elemento)**

```csharp
    public bool Contains(char item)
    {
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            if (Elements[i] == item)
                return true;
            i = (i + 1) % Size; // Recorrido circular
        }
        return false;
    }
```

7. **IsEmpty (Verificar si está vacía)**

```csharp
    public bool IsEmpty()
    {
        return Count == 0;
    }
```

8. **IsFull (Verificar si está llena)**

```csharp
    public bool IsFull()
    {
        return Count == Size;
    }
```

9. **Mostrar elementos de la cola**

```csharp
    public void Mostrar()
    {
        Console.WriteLine("\nElementos en la cola:");
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            Console.Write($"{Elements[i]} ");
            i = (i + 1) % Size; // Avanzar de forma circular
        }
        Console.WriteLine();
    }
}
```

---

##  2. Clase `Principal` (Programa con Menú)

Archivo: `Principal.cs`

###  Descripción

Es el **programa principal**, donde el usuario puede interactuar con la cola mediante un **menú de opciones**.

---

###  Flujo del Programa

```csharp
class Principal
{
    static void Main(string[] args)
    {
        // 1️⃣ Se pide el tamaño de la cola
        Console.Write("Ingrese el tamaño de la cola: ");
        int tamaño;
        while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
        {
            Console.Write("Tamaño inválido. Ingrese un número entero positivo: ");
        }

        // 2️⃣ Se crea la cola
        MyQueue cola = new MyQueue(tamaño);
        int opcion;
```

---

###  Menú Principal

El usuario puede seleccionar entre 9 operaciones:

```csharp
        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Equeue = Insertar");
            Console.WriteLine("3. Dequeue = Eliminar");
            Console.WriteLine("4. Peek = Ver primer elemento");
            Console.WriteLine("5. Count = Ver cantidad actual");
            Console.WriteLine("6. Size = Ver capacidad máxima");
            Console.WriteLine("7. Contains = Buscar elemento");
            Console.WriteLine("8. IsEmpty = Verificar si está vacía");
            Console.WriteLine("9. IsFull = Verificar si está llena");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción que desea: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }
```

---

###  Ejecución de Opciones

Ejemplo de casos del menú:

* **Insertar (Enqueue)**

```csharp
case 2:
    Console.Write("Ingrese un carácter para insertar: ");
    string entrada = Console.ReadLine();
    if (!string.IsNullOrEmpty(entrada))
        cola.Enqueue(entrada[0]);
    else
        Console.WriteLine("Entrada no válida.");
    break;
```

* **Eliminar (Dequeue)**

```csharp
case 3:
    char eliminado = cola.Dequeue();
    if (eliminado != '\0')
        Console.WriteLine("Se eliminó el carácter: " + eliminado);
    break;
```

* **Buscar elemento (Contains)**

```csharp
case 7:
    Console.Write("Ingrese el carácter que desea buscar en la cola: ");
    string busqueda = Console.ReadLine();
    if (!string.IsNullOrEmpty(busqueda))
        Console.WriteLine("¿La cola contiene '{0}'?: {1}", busqueda[0], cola.Contains(busqueda[0]));
    else
        Console.WriteLine("Entrada no válida.");
    break;
```

* **Salir**

```csharp
case 0:
    Console.WriteLine("Estas saliendo del programa de colas...");
    break;
```

---

##  3. Ejemplo de Ejecución

```
Ingrese el tamaño de la cola: 3

===== MENÚ COLA =====
1. Mostrar COLA
2. Equeue = Insertar
3. Dequeue = Eliminar
...
Seleccione la opción que desea: 2
Ingrese un carácter para insertar: A

===== MENÚ COLA =====
1. Mostrar COLA
...
Seleccione la opción que desea: 1
Elementos en la cola:
A
```

---

