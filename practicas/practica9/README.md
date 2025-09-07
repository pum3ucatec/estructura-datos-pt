# Lista Doblemente Enlazada en C#

Este proyecto implementa una **lista doblemente enlazada** en el lenguaje **C#**, donde se permite administrar nodos de forma dinámica, agregando, eliminando, recorriendo y buscando elementos dentro de la estructura.

El programa se compone de **tres clases principales**:

1. [`Principal`](./Principal.cs) → Clase con el **menú principal** para interactuar con el usuario.  
2. [`ListaEnlazadaDoble`](./ListaEnlazadaDoble.cs) → Clase que **implementa la lógica** de la lista doblemente enlazada.  
3. [`NodoDobleEnlazado`](./NodoDobleEnlazado.cs) → Clase que **representa un nodo** de la lista con enlaces a su anterior y siguiente.

---

## Funcionamiento del Programa

Al ejecutar el programa, se muestra un **menú interactivo en consola** que permite realizar operaciones sobre la lista:

- Recorrer la lista hacia adelante o atrás.  
- Insertar nodos al inicio o al final.  
- Eliminar nodos en distintas posiciones.  
- Buscar un elemento dentro de la lista.  
- Contar cuántos nodos existen.  
- Verificar si la lista está vacía.  
- Limpiar todos los nodos de la lista.  

---

##  Explicación de las Clases

###  Clase `NodoDobleEnlazado`
Ubicada en [`NodoDobleEnlazado.cs`](./NodoDobleEnlazado.cs).

Define la **estructura básica de cada nodo** en la lista:
```csharp
public class NodoDobleEnlazado
{
    public int Valor { get; set; }               // Dato almacenado en el nodo
    public NodoDobleEnlazado? Siguiente { get; set; }  // Apunta al nodo siguiente
    public NodoDobleEnlazado? Anterior { get; set; }   // Apunta al nodo anterior

    public NodoDobleEnlazado(int valor)
    {
        Valor = valor;
        Siguiente = null;
        Anterior = null;
    }
}
```
Cada nodo conoce a su anterior y a su siguiente, lo que permite recorrer la lista en ambos sentidos.

### Clase ListaEnlazadaDoble
Ubicada en [`ListaEnlazadaDoble.cs`](./ListaEnlazadaDoble.cs).

Contiene toda la **lógica de la lista doblemente enlazada:**

Referencias a inicio y fin.

Métodos de inserción, eliminación, búsqueda, recorrido y limpieza.

**Ejemplo de método para insertar al inicio:**

```csharp

public void InsertarInicio(int valor)
{
    NodoDobleEnlazado nuevo = new NodoDobleEnlazado(valor);
    if (inicio == null)
    {
        inicio = fin = nuevo;  // Lista vacía → el nuevo nodo es inicio y fin
    }
    else
    {
        nuevo.Siguiente = inicio;
        inicio.Anterior = nuevo;
        inicio = nuevo;
    }
}
```
**Ejemplo de método para recorrer hacia atrás:**

```csharp

public void RecorrerAtras()
{
    if (fin == null)
    {
        Console.WriteLine("Lista vacía.");
        return;
    }

    NodoDobleEnlazado? actual = fin;
    Console.Write("Fin -> ");
    while (actual != null)
    {
        Console.Write(actual.Valor + " <-> ");
        actual = actual.Anterior;
    }
    Console.WriteLine("null");
}
```
Se manejan referencias dobles (Anterior y Siguiente).

La lista permite recorrer desde el inicio o desde el fin.

### Clase Principal
Ubicada en [`Principal.cs`](./Principal.cs).

Controla la **interacción con el usuario** mediante un menú en consola:

```csharp

do
{
    Console.WriteLine("\n===== MENÚ DE LISTA DOBLE =====");
    Console.WriteLine("1. Recorrer hacia adelante");
    Console.WriteLine("2. Recorrer hacia atrás");
    Console.WriteLine("3. Agregar al inicio");
    Console.WriteLine("4. Agregar al final");
    Console.WriteLine("5. Quitar al inicio");
    Console.WriteLine("6. Quitar al final");
    Console.WriteLine("7. Quitar en posición específica");
    Console.WriteLine("8. Buscar elemento");
    Console.WriteLine("9. Total de elementos");
    Console.WriteLine("10. Comprobar si está vacía");
    Console.WriteLine("11. Limpiar lista");
    Console.WriteLine("0. Salir");

    Console.Write("Selecciona una opción: ");
    bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

    if (!esNumero)
    {
        Console.WriteLine("Entrada inválida.");
        opcion = -1;
    }

    switch (opcion)
    {
        case 1: lista.RecorrerAdelante(); break;
        case 2: lista.RecorrerAtras(); break;
        case 3: /* Insertar al inicio */ break;
        case 4: /* Insertar al final */ break;
        ...
    }
} while (opcion != 0);
```

Se valida la entrada del usuario con **int.TryParse.**

Se utiliza un switch para manejar las opciones.

El programa funciona hasta que el usuario elige 0. Salir.

Ejemplo de Ejecución

```
===== MENÚ DE LISTA DOBLE =====
1. Recorrer hacia adelante
2. Recorrer hacia atrás
3. Agregar al inicio
4. Agregar al final
5. Quitar al inicio
6. Quitar al final
7. Quitar en posición específica
8. Buscar elemento
9. Total de elementos
10. Comprobar si está vacía
11. Limpiar lista
0. Salir
Selecciona una opción: 3
Valor a insertar al inicio: 10

===== MENÚ DE LISTA DOBLE =====
Selecciona una opción: 1
Inicio -> 10 <-> null
```
