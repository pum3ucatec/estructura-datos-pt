using System;

/// <summary>
/// Clase que implementa una Cola Circular (FIFO) usando un arreglo.
/// FIFO significa: First In, First Out (el primero en entrar es el primero en salir).
/// </summary>
public class MyQueue
{
    private int[] Elements;  // Arreglo para almacenar los elementos
    private int Size;        // Capacidad máxima de la cola
    private int Front;       // Índice del primer elemento
    private int Rear;        // Índice del último elemento
    private int Count;       // Número actual de elementos en la cola

    /// <summary>
    /// Constructor que inicializa la cola con una capacidad específica.
    /// </summary>
    /// <param name="N">Capacidad máxima de la cola</param>
    public MyQueue(int N)
    {
        this.Elements = new int[N];
        this.Size = N;
        this.Front = 0;
        this.Rear = -1;
        this.Count = 0;
    }

    /// <summary>
    /// Inserta un nuevo elemento al final de la cola.
    /// </summary>
    /// <param name="valor">Valor a insertar en la cola</param>
    public void Enqueue(int valor)
    {
        if (Count == Size)
        {
            Console.WriteLine("Error: La cola está llena. No se puede insertar.");
            return;
        }

        Rear = (Rear + 1) % Size;
        Elements[Rear] = valor;
        Count++;
        Console.WriteLine($"Elemento {valor} insertado correctamente.");
    }

    /// <summary>
    /// Elimina el primer elemento de la cola.
    /// </summary>
    /// <returns>Valor eliminado o -1 si la cola está vacía</returns>
    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Error: La cola está vacía. No se puede eliminar.");
            return -1;
        }

        int valorEliminado = Elements[Front];
        Front = (Front + 1) % Size;
        Count--;
        Console.WriteLine($"Elemento {valorEliminado} eliminado correctamente.");
        return valorEliminado;
    }

    /// <summary>
    /// Retorna el primer elemento de la cola sin eliminarlo.
    /// </summary>
    /// <returns>Valor del frente o -1 si la cola está vacía</returns>
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return -1;
        }
        return Elements[Front];
    }

    /// <summary>
    /// Verifica si la cola está vacía.
    /// </summary>
    /// <returns>True si está vacía, False en caso contrario</returns>
    public bool IsEmpty()
    {
        return Count == 0;
    }

    /// <summary>
    /// Muestra el contenido actual de la cola en orden FIFO.
    /// </summary>
    public void Mostrar()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("\n=== CONTENIDO DE LA COLA ===");
        Console.WriteLine($"Tamaño actual: {Count}");
        Console.WriteLine("Elementos (de frente a final):");

        for (int i = 0; i < Count; i++)
        {
            int index = (Front + i) % Size;
            Console.Write($"{Elements[index]} ");
        }
        Console.WriteLine("\n============================");
    }
}

/// <summary>
/// Clase principal que contiene el menú interactivo para manipular la cola.
/// </summary>
class Principal
{
    /// <summary>
    /// Punto de entrada del programa.
    /// </summary>
    static void Main(string[] args)
    {
        MyQueue cola = new MyQueue(5);
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ COLA =====");
            Console.WriteLine("1. Mostrar COLA");
            Console.WriteLine("2. Insertar (Enqueue)");
            Console.WriteLine("3. Eliminar (Dequeue)");
            Console.WriteLine("4. Ver frente (Peek)");
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
                    cola.Mostrar();
                    break;
                case 2:
                    Console.Write("Ingrese el número a insertar: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        cola.Enqueue(valor);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido.");
                    }
                    break;
                case 3:
                    cola.Dequeue();
                    break;
                case 4:
                    int frente = cola.Peek();
                    if (frente != -1)
                        Console.WriteLine($"Elemento en el frente: {frente}");
                    break;
                case 5:
                    Console.WriteLine(cola.IsEmpty() ? "La cola está vacía." : "La cola NO está vacía.");
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

