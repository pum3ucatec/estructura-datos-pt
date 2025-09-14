# Practica 8
# Implementación de Lista Simple 

Listas Simples donde se pueden almacenar nombres.  
Incluye todas las operaciones básicas como inserción, eliminación, búsqueda y verificación, con un menú interactivo para probarlas.

---

## 1. Clase Nodo

### Descripción
Cada nodo contiene un **nombre** (`Name`) y un puntero al siguiente nodo (`Next`). Esta clase es la base de la lista enlazada.

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
```
### Explicación

Name: almacena el valor del nodo.

Next: apunta al siguiente nodo de la lista.

El constructor inicializa el nodo con un nombre y establece Next en null.

## 2. Clase ListaSimple
### Descripción

Esta clase implementa la lista enlazada simple con operaciones comunes:

Insertar al final.

Eliminar el primer elemento o por posición.

Buscar y verificar existencia.

Mostrar todos los elementos.

### Código
```csharp
public class ListaSimple
{
    private Nodo cabeza;
    private int CountElements;

    public ListaSimple()
    {
        cabeza = null;
        CountElements = 0;
    }

    public void Insertar(string name)
    {
        Nodo nodo = new Nodo(name);
        if (cabeza == null) cabeza = nodo;
        else
        {
            Nodo current = cabeza;
            while (current.Next != null) current = current.Next;
            current.Next = nodo;
        }
        CountElements++;
    }

    public string EliminarPrimero()
    {
        if (cabeza == null) { Console.WriteLine("La lista está vacía."); return null; }
        string valor = cabeza.Name;
        cabeza = cabeza.Next;
        CountElements--;
        return valor;
    }

    public string EliminarEn(int posicion)
    {
        if (cabeza == null || posicion < 1 || posicion > CountElements)
        {
            Console.WriteLine("Posición inválida.");
            return null;
        }

        if (posicion == 1) return EliminarPrimero();

        Nodo current = cabeza, prev = null;
        int index = 1;
        while (index < posicion)
        {
            prev = current;
            current = current.Next;
            index++;
        }

        string valor = current.Name;
        prev.Next = current.Next;
        CountElements--;
        return valor;
    }

    public string VerPrimero() => cabeza != null ? cabeza.Name : null;

    public int Buscar(string name)
    {
        Nodo current = cabeza;
        int posicion = 1;
        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return posicion;
            current = current.Next;
            posicion++;
        }
        return -1;
    }

    public bool Contiene(string name) => Buscar(name) != -1;

    public void Vaciar() { cabeza = null; CountElements = 0; }

    public void Mostrar()
    {
        Nodo current = cabeza;
        if (current == null) { Console.WriteLine("La lista está vacía."); return; }

        Console.WriteLine("Nombres en la lista:");
        while (current != null)
        {
            Console.Write($"| {current.Name} ");
            current = current.Next;
        }
        Console.WriteLine("|");
    }

    public int Count() => CountElements;

    public bool EstaVacia() => cabeza == null;
}
```
### Explicación

Insertar: agrega un nodo al final de la lista.

EliminarPrimero: elimina el primer nodo y devuelve su valor.

EliminarEn: elimina el nodo en una posición específica.

VerPrimero: retorna el valor del primer nodo.

Buscar: devuelve la posición de un nombre, o -1 si no existe.

Contiene: indica si un nombre existe en la lista.

Vaciar: elimina todos los nodos.

Mostrar: imprime todos los elementos en orden.

Count: retorna la cantidad de elementos.

EstaVacia: indica si la lista está vacía.

## 3. Programa Principal Interactivo
### Descripción

Permite al usuario interactuar con la lista simple mediante un menú de opciones.

### Código
```csharp
class Program
{
    static void Main()
    {
        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("       MENÚ DE LISTA SIMPLE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Insertar nombre");
            Console.WriteLine("3. Eliminar primero");
            Console.WriteLine("4. Eliminar por posición");
            Console.WriteLine("5. Ver primer elemento");
            Console.WriteLine("6. Ver cantidad");
            Console.WriteLine("7. Buscar nombre y posición");
            Console.WriteLine("8. Verificar existencia");
            Console.WriteLine("9. Vaciar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion)) { Console.WriteLine("Opción inválida."); continue; }

            switch (opcion)
            {
                case 1: lista.Mostrar(); break;
                case 2:
                    Console.Write("Ingrese un nombre: ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre)) lista.Insertar(nombre);
                    else Console.WriteLine("Nombre inválido.");
                    break;
                case 3:
                    string eliminado = lista.EliminarPrimero();
                    if (eliminado != null) Console.WriteLine($"Se eliminó: {eliminado}");
                    break;
                case 4:
                    Console.Write("Ingrese la posición a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int pos))
                    {
                        string eliminadoPos = lista.EliminarEn(pos);
                        if (eliminadoPos != null) Console.WriteLine($"Se eliminó: {eliminadoPos}");
                    }
                    else Console.WriteLine("Posición inválida.");
                    break;
                case 5:
                    string primero = lista.VerPrimero();
                    Console.WriteLine(primero != null ? $"Primero: {primero}" : "La lista está vacía.");
                    break;
                case 6: Console.WriteLine($"La lista tiene {lista.Count()} elementos."); break;
                case 7:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string buscar = Console.ReadLine();
                    int posBuscada = lista.Buscar(buscar);
                    Console.WriteLine(posBuscada != -1 ? $"'{buscar}' está en la posición {posBuscada}" : "No se encontró el nombre.");
                    break;
                case 8:
                    Console.Write("Ingrese el nombre a verificar: ");
                    string existe = Console.ReadLine();
                    Console.WriteLine(lista.Contiene(existe) ? $"'{existe}' está en la lista." : $"'{existe}' no está en la lista.");
                    break;
                case 9: lista.Vaciar(); Console.WriteLine("La lista fue vaciada."); break;
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida."); break;
            }

        } while (opcion != 0);
    }
}
```

### Explicación

Permite probar todas las operaciones de la lista mediante un menú interactivo.

Valida entradas numéricas y de texto para evitar errores.

Cada opción llama al método correspondiente de la clase ListaSimple.

Se puede insertar, eliminar, buscar, mostrar y vaciar la lista fácilmente.  


### Cami