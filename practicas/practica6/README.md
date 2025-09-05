# Practica 6
#  Implementación de Cola en C#

Este repositorio contiene la implementación de una **cola circular** en C# usando un arreglo (`array`). Se incluyen todas las operaciones básicas de la cola, con un menú interactivo para probarlas.

---

## 1. Clase `MyQueue`
### Descripción:
Implementa una cola circular con las siguientes operaciones:
- Insertar (Enqueue)  
- Eliminar (Dequeue)  
- Ver el frente (Peek)  
- Contar elementos (Count)  
- Verificar capacidad (Size)  
- Buscar elemento (Contains)  
- Verificar si está vacía (IsEmpty)  
- Verificar si está llena (IsFull)  
- Mostrar elementos  

### Código:
```csharp
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

    public void Enqueue(char item)
    {
        if (IsFull()) { Console.WriteLine("La cola está llena."); return; }
        Rear = (Rear + 1) % Size;
        Elements[Rear] = item;
        Count++;
    }

    public char Dequeue()
    {
        if (IsEmpty()) { Console.WriteLine("La cola está vacía."); return '\0'; }
        char item = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        return item;
    }

    public char Peek()
    {
        if (IsEmpty()) { Console.WriteLine("La cola está vacía."); return '\0'; }
        return Elements[Front];
    }

    public int GetCount() => Count;

    public int GetSize() => Size;

    public bool Contains(char item)
    {
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            if (Elements[i] == item) return true;
            i = (i + 1) % Size;
        }
        return false;
    }

    public bool IsEmpty() => Count == 0;

    public bool IsFull() => Count == Size;

    public void Mostrar()
    {
        Console.WriteLine("\nElementos en la cola:");
        int i = Front;
        for (int c = 0; c < Count; c++)
        {
            Console.Write($"{Elements[i]} ");
            i = (i + 1) % Size;
        }
        Console.WriteLine();
    }
}
```
### Explicación:

Enqueue: Inserta un elemento al final de la cola. Usa aritmética modular para mantener la circularidad.

Dequeue: Elimina y retorna el elemento del frente. Ajusta el índice Front.

Peek: Devuelve el elemento del frente sin eliminarlo.

GetCount: Retorna la cantidad de elementos en la cola.

GetSize: Retorna la capacidad máxima de la cola.

Contains: Verifica si un elemento existe recorriendo la cola circular.

IsEmpty / IsFull: Verifica si la cola está vacía o llena.

Mostrar: Imprime todos los elementos en orden, respetando la circularidad.

## 2. Programa Principal Principal

### Descripción:
Programa interactivo con menú que permite al usuario probar todas las operaciones de la cola.

### Código:
```csharp
class Principal
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la cola: ");
        int tamaño;
        while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño <= 0)
            Console.Write("Tamaño inválido. Ingrese un número entero positivo: ");

        MyQueue cola = new MyQueue(tamaño);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
            Console.WriteLine("5. Ver cantidad de elementos (Count)");
            Console.WriteLine("6. Ver capacidad de la cola (Size)");
            Console.WriteLine("7. Buscar elemento (Contains)");
            Console.WriteLine("8. Verificar si está vacía (IsEmpty)");
            Console.WriteLine("9. Verificar si está llena (IsFull)");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine(" Ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1: cola.Mostrar(); break;
                case 2:
                    Console.Write("Ingrese un carácter a insertar: ");
                    string entrada = Console.ReadLine();
                    if (!string.IsNullOrEmpty(entrada))
                        cola.Enqueue(entrada[0]);
                    else
                        Console.WriteLine(" Entrada no válida.");
                    break;
                case 3:
                    char eliminado = cola.Dequeue();
                    if (eliminado != '\0') Console.WriteLine(" Se eliminó: " + eliminado);
                    break;
                case 4:
                    char frente = cola.Peek();
                    if (frente != '\0') Console.WriteLine(" Frente: " + frente);
                    break;
                case 5: Console.WriteLine(" Cantidad: " + cola.GetCount()); break;
                case 6: Console.WriteLine(" Capacidad: " + cola.GetSize()); break;
                case 7:
                    Console.Write("Ingrese el carácter a buscar: ");
                    string busqueda = Console.ReadLine();
                    if (!string.IsNullOrEmpty(busqueda))
                        Console.WriteLine(" Contiene '{0}'?: {1}", busqueda[0], cola.Contains(busqueda[0]));
                    else
                        Console.WriteLine(" Entrada no válida.");
                    break;
                case 8: Console.WriteLine(" ¿Cola vacía?: " + cola.IsEmpty()); break;
                case 9: Console.WriteLine(" ¿Cola llena?: " + cola.IsFull()); break;
                case 0: Console.WriteLine(" Saliendo..."); break;
                default: Console.WriteLine(" Opción no válida."); break;
            }

        } while (opcion != 0);
    }
}
```

### Explicación:

Solicita al usuario la capacidad de la cola y crea un objeto MyQueue.

Muestra un menú interactivo con todas las operaciones disponibles.

Se valida la entrada del usuario para evitar errores.

Cada opción del menú llama a los métodos correspondientes de la clase MyQueue.

Permite probar la inserción, eliminación, búsqueda, y verificación del estado de la cola de manera interactiva.