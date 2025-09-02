# Practica 7
# Implementación de Colas 

Este proyecto contiene **dos implementaciones de colas** en C#:
1. Cola dinámica usando **nodos enlazados**.
2. Cola circular usando un **arreglo**.

Incluye todas las operaciones básicas de una cola y un menú interactivo para probarlas.

---

## 1. Cola Dinámica con Nodos

### Descripción
Se implementa una cola utilizando **nodos enlazados**, donde cada nodo contiene un valor (`Name`) y un puntero al siguiente nodo (`Next`). Se manejan los punteros `Front` (frente) y `Rear` (final) para controlar la cola.

### Código
```csharp
public class Nodo
{
    public string Name { get; set; }
    public Nodo Next { get; set; }

    public Nodo(string name)
    {
        this.Name = name;
        this.Next = null;
    }
}

public class Cola
{
    public Nodo Front { get; private set; }
    public Nodo Rear { get; private set; }
    private int CountElements;

    public Cola()
    {
        this.Front = null;
        this.Rear = null;
        this.CountElements = 0;
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
        CountElements++;
    }

    public string Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");

        string value = Front.Name;
        Front = Front.Next;
        if (Front == null) Rear = null;
        CountElements--;
        return value;
    }

    public string Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("La cola está vacía.");
        return Front.Name;
    }

    public bool IsEmpty() => Front == null;

    public int Count() => CountElements;

    public void Clear()
    {
        Front = null;
        Rear = null;
        CountElements = 0;
    }

    public bool Contains(string name)
    {
        Nodo current = Front;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void View()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Nodo current = Front;
        Console.Write("Elementos en la cola: ");
        while (current != null)
        {
            Console.Write($"{current.Name} | ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
```

### Explicación

Enqueue: Inserta un nodo al final de la cola.

Dequeue: Elimina el nodo del frente y retorna su valor.

Peek: Muestra el valor del frente sin eliminarlo.

IsEmpty: Indica si la cola está vacía.

Count: Devuelve la cantidad de elementos actuales.

Clear: Vacía la cola.

Contains: Busca un valor dentro de la cola.

View: Muestra todos los elementos de la cola en orden.

## 2. Cola Circular con Arreglo
### Descripción

Se implementa una cola circular usando un arreglo. La cola tiene un tamaño fijo, y los índices Front y Rear permiten controlar los elementos de manera circular.

### Código
```csharp
public class MyQueue
{
    private char[] Elements;
    private int Size;
    private int Front;
    private int Rear;
    private int Count;

    public MyQueue(int tamaño)
    {
        Elements = new char[tamaño];
        Size = tamaño;
        Front = 0;
        Rear = -1;
        Count = 0;
    }

    public void Enqueue(char c)
    {
        if (IsFull()) { Console.WriteLine("La cola está llena."); return; }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = c;
        Count++;
    }

    public char Dequeue()
    {
        if (IsEmpty()) { Console.WriteLine("La cola está vacía."); return '\0'; }
        char value = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        return value;
    }

    public char Peek()
    {
        if (IsEmpty()) { Console.WriteLine("La cola está vacía."); return '\0'; }
        return Elements[Front];
    }

    public void Mostrar()
    {
        if (IsEmpty()) { Console.WriteLine("La cola está vacía."); return; }
        Console.Write("Cola: ");
        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write(Elements[index] + " ");
        }
        Console.WriteLine();
    }

    public int GetCount() => Count;

    public int GetSize() => Size;

    public bool Contains(char c)
    {
        for (int i = 0; i < Count; i++)
            if (Elements[(Front + i) % Size] == c) return true;
        return false;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;
}
```
### Explicación

Enqueue: Inserta un elemento al final. Usa módulo para mantener la circularidad.

Dequeue: Elimina el elemento del frente y lo retorna.

Peek: Retorna el elemento del frente sin eliminarlo.

Mostrar: Muestra todos los elementos de la cola en orden.

GetCount y GetSize: Retornan cantidad actual y capacidad máxima.

Contains: Verifica si un elemento existe en la cola.

IsEmpty / IsFull: Comprueba si la cola está vacía o llena.

## 3. Programa Principal Interactivo
### Código
```csharp
class Principal
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño de la cola: ");
        int tamaño;
        while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
            Console.Write("Tamaño inválido. Ingrese un número entero positivo: ");

        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("[     MENÚ COLA     ]");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Enqueue = Insertar");
            Console.WriteLine("3. Dequeue = Eliminar");
            Console.WriteLine("4. Peek = Ver primer elemento");
            Console.WriteLine("5. Count = Ver cantidad actual");
            Console.WriteLine("6. Size = Ver capacidad máxima");
            Console.WriteLine("7. Contains = Buscar elemento");
            Console.WriteLine("8. IsEmpty = Verificar si está vacía");
            Console.WriteLine("9. IsFull = Verificar si está llena");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione la opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) { Console.WriteLine("Ingrese un número válido."); continue; }

            switch (opcion)
            {
                case 1: cola.Mostrar(); break;
                case 2:
                    Console.Write("Ingrese un carácter: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada)) cola.Enqueue(entrada[0]);
                    else Console.WriteLine("Entrada no válida.");
                    break;
                case 3:
                    char eliminado = cola.Dequeue();
                    if (eliminado != '\0') Console.WriteLine("Se eliminó: " + eliminado);
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0') Console.WriteLine("Frente: " + frente);
                    break;
                case 5: Console.WriteLine("Cantidad actual: " + cola.GetCount()); break;
                case 6: Console.WriteLine("Capacidad máxima: " + cola.GetSize()); break;
                case 7:
                    Console.Write("Elemento a buscar: ");
                    string busqueda = Console.ReadLine();
                    if (!string.IsNullOrEmpty(busqueda)) 
                        Console.WriteLine("¿Contiene '{0}'?: {1}", busqueda[0], cola.Contains(busqueda[0]));
                    else Console.WriteLine("Entrada no válida."); 
                    break;
                case 8: Console.WriteLine("¿Está vacía?: " + cola.IsEmpty()); break;
                case 9: Console.WriteLine("¿Está llena?: " + cola.IsFull()); break;
                case 0: Console.WriteLine("Saliendo del programa..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 0);
    }
}
```

### Explicación

Permite al usuario interactuar con la cola circular mediante un menú.

Valida la entrada para evitar errores.

Cada opción llama a un método de la clase MyQueue.

Permite probar todas las operaciones básicas: insertar, eliminar, mostrar, verificar estado y buscar elementos.


## Cami