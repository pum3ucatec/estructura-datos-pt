# Implementación de una Cola Dinámica en C#

Este programa implementa una **cola (queue)** usando **nodos enlazados**, con un menú interactivo en consola para realizar operaciones básicas.

----------

## 🔹 1. Clase `Nodo`

Representa un **elemento de la cola**.

`public  class  Nodo { public  string Name { get; set; } // Dato almacenado en el nodo  public Nodo Next { get; set; } // Referencia al siguiente nodo  public  Nodo(string name)
    { this.Name = name; this.Next = null;
    }
}` 

-   **`Name`** → almacena el valor.
    
-   **`Next`** → apunta al siguiente nodo en la cola.
    
-   Constructor inicializa un nodo con un valor y lo conecta en la estructura.
    

----------

## 🔹 2. Clase `Cola`

Se encarga de la **lógica de la cola dinámica**.

`public  class  Cola { public Nodo Front { get; private  set; } // Primer nodo (frente de la cola)  public Nodo Rear { get; private  set; } // Último nodo (final de la cola)` 

### 📌 Métodos principales:

1.  **`Enqueue(string name)`**  
    Inserta un nuevo elemento al final de la cola.
    
    `cola.Enqueue("A");` 
    
    🔹 Si la cola está vacía, el nuevo nodo será tanto `Front` como `Rear`.
    

----------

2.  **`Dequeue()`**  
    Elimina el elemento al frente de la cola y devuelve su valor.
    
    `string eliminado = cola.Dequeue();` 
    
    🔹 Si la cola queda vacía después de la eliminación, `Front` y `Rear` se establecen en `null`.
    

----------

3.  **`Peek()`**  
    Muestra el valor del primer elemento sin eliminarlo.
    
    `string frente = cola.Peek();` 
    

----------

4.  **`IsEmpty()`**  
    Verifica si la cola está vacía.
    
    `bool vacia = cola.IsEmpty();` 
    

----------

5.  **`View()`**  
    Recorre la cola desde `Front` hasta `Rear` mostrando los valores almacenados.
    
    `cola.View(); // Ejemplo: A | B | C |` 
    

----------

## 🔹 3. Clase `Principal` (Main)

Aquí se implementa un **menú interactivo** que permite al usuario manipular la cola.

```
do {
Console.WriteLine("\n===== MENÚ COLA con NODOS =====");
    Console.WriteLine("1. Mostrar Cola");
    Console.WriteLine("2. Insertar (Enqueue)");
    Console.WriteLine("3. Eliminar (Dequeue)");
    Console.WriteLine("4. Ver frente (Peek)");
    Console.WriteLine("5. Verificar si está vacía");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    
} while (opcion != 0);` 
```
----------

## 🔹 4. Ejemplo de Ejecución

`===== MENÚ COLA con NODOS ===== 1. Mostrar Cola 2. Insertar (Enqueue) 3. Eliminar (Dequeue) 4. Ver frente (Peek) 5. Verificar si está vacía 0. Salir
Seleccione una opción: 2
Ingrese el nombre a insertar: Juan
Elemento 'Juan' agregado a la cola.

Seleccione una opción: 2
Ingrese el nombre a insertar: Ana
Elemento 'Ana' agregado a la cola.

Seleccione una opción: 1
Contenido de la cola: Juan | Ana |`
