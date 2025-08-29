# Proyecto: Lista/Cola con Nodos en C#

## Descripción
Este proyecto implementa una **estructura de datos dinámica** utilizando nodos enlazados en C#.  
Permite manejar una lista/cola con operaciones como:
1. Insertar elementos al principio como en una **lista simple**.
2. Mostrar el contenido de la lista.
3. Eliminar los elementos que se encuentran **a la izquierda y derecha de una posición seleccionada**.

El programa es interactivo mediante un menú en consola.

---

##  Archivos principales
- **Nodo.cs** → Clase que representa cada nodo de la lista.
- **Fila.cs** → Contiene la lógica principal de la estructura (insertar, eliminar, ver).
- **Programs.cs** → Programa principal con menú interactivo.

---

##  Clases y métodos principales

### Clase `Nodo`
Representa un nodo de la lista.
```csharp
public class Nodo
{
    public string Valor { get; set; }
    public Nodo? Next { get; set; }

    public Nodo(string valor)
    {
        Valor = valor;
        Next = null;
    }
}
```

###  Clase `Fila`
Contiene las operaciones principales de la lista/cola.

#### Insertar al principio
```csharp
public void InsertFirst(string valor)
{
    Nodo nuevo = new Nodo(valor);
    nuevo.Next = Head;
    Head = nuevo;
}
```

#### Eliminar alrededor de una posición
Elimina los nodos a la **izquierda y derecha** de la posición seleccionada.
```csharp
public void DeleteAround(int posicion)
{
    if (Head == null || posicion < 1) return;

    int n = Count();
    if (posicion > n) return;

    // Eliminar derecha e izquierda
    RemoveAt(posicion + 1); 
    RemoveAt(posicion - 1);
}
```

#### Mostrar la lista
```csharp
public void View()
{
    Nodo? actual = Head;

    if (actual == null)
    {
        Console.WriteLine("La lista está vacía.");
        return;
    }

    Console.Write("Contenido de la lista: ");
    while (actual != null)
    {
        Console.Write(actual.Valor + " -> ");
        actual = actual.Next;
    }
    Console.WriteLine("null");
}
```

---

## Programa principal (`Programs.cs`)
El menú interactivo:
```csharp
Console.WriteLine("===== MENÚ Lista/Fila con NODOS =====");
Console.WriteLine("1. Mostrar lista");
Console.WriteLine("2. Insertar al final");
Console.WriteLine("3. Eliminar alrededor de una posición");
Console.WriteLine("4. Insertar al principio");
Console.WriteLine("0. Salir");
```
Ejemplo de uso:
```
===== MENÚ Lista/Fila con NODOS =====
1. Mostrar lista
2. Insertar al final
3. Eliminar alrededor de una posición
4. Insertar al principio
0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar (al final): Juan
```

---

## Ejecución
1. Compila el proyecto:
   ```bash
   dotnet build
   ```
2. Ejecuta:
   ```bash
   dotnet run
   ```

---

## Conclusiones
- Se trabajó con **nodos enlazados** para simular una lista.
- Se implementaron operaciones clave: **inserción**, **eliminación de nodos alrededor de una posición** y **visualización**.