# Practica 4
#  Ejercicio de Pila 

Este proyecto implementa una **pila** en C# usando la clase genérica `Stack<int>`.  
Permite insertar, eliminar, ver la cima, contar elementos y vaciar la pila, además de interactuar con el usuario mediante un menú.

---

##  Funcionalidades del programa

El programa está organizado en **dos clases principales**:  

- **`Pila`**: Implementa la lógica de la pila y sus operaciones.  
- **`Principal`**: Contiene el menú interactivo y permite al usuario ejecutar las operaciones.  

---

##  Clase `Pila`

### 1. Insertar un elemento (`Push`)
```csharp
public void Push(int valor)
{
    stack.Push(valor);
    Console.WriteLine($"Se insertó: {valor}");
}
```
Inserta un nuevo elemento en la cima de la pila.

Muestra un mensaje confirmando la inserción.

### 2. Insertar varios elementos (PushN)
```csharp
public void PushN(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"Ingrese el elemento {i}: ");
        if (int.TryParse(Console.ReadLine(), out int valor))
        {
            stack.Push(valor);
        }
        else
        {
            Console.WriteLine("Valor inválido, se omitirá.");
        }
    }
    Console.WriteLine($"Se insertaron {n} elementos.");
}
```

Permite al usuario insertar n elementos consecutivos.

Valida que la entrada sea numérica antes de insertarla.

### 3. Eliminar un elemento (Pop)
```csharp
public void Pop()
{
    if (stack.Count > 0)
        Console.WriteLine($"Se eliminó: {stack.Pop()}");
    else
        Console.WriteLine("La pila está vacía.");
}
```

Elimina el elemento en la cima de la pila.

Muestra un mensaje indicando cuál fue eliminado o si la pila está vacía.

### 4. Ver la cima (Peek)
```csharp
public int Peek()
{
    if (stack.Count > 0)
        return stack.Peek();
    Console.WriteLine("La pila está vacía.");
    return -1;
}
```

Devuelve el elemento en la cima sin eliminarlo.

Si la pila está vacía, retorna -1 y muestra un mensaje.

### 5. Mostrar todos los elementos (Mostrar)
```csharp
public void Mostrar()
{
    if (stack.Count == 0)
    {
        Console.WriteLine("La pila está vacía.");
        return;
    }

    Console.WriteLine("Elementos en la pila:");
    foreach (int item in stack)
        Console.WriteLine(item);
}
```

Recorre la pila e imprime todos los elementos desde la cima hacia abajo.

### 6. Verificar si está vacía (IsEmpty)
```csharp
public bool IsEmpty()
{
    return stack.Count == 0;
}
```

Retorna true si la pila no tiene elementos, de lo contrario false.

### 7. Contar elementos (Count)
```csharp
public int Count()
{
    return stack.Count;
}
```

Devuelve la cantidad de elementos actualmente en la pila.

### 8. Vaciar pila (Clear)
```csharp
public void Clear()
{
    stack.Clear();
    Console.WriteLine("La pila fue vaciada.");
}
```

Elimina todos los elementos de la pila y muestra un mensaje.

##  Clase Principal (Menú interactivo)

Implementa un menú de opciones para que el usuario elija qué acción realizar:

Mostrar pila

Insertar elemento (Push)

Eliminar elemento (Pop)

Ver cima (Peek)

Verificar si está vacía (IsEmpty)

Contar elementos (Count)

Vaciar pila (Clear)

Insertar varios elementos (Push n)

Salir

El programa usa un bucle do-while para que el menú se repita hasta que el usuario decida salir.

Cada opción valida la entrada del usuario para evitar errores.

##  Flujo del programa

Se crea una instancia de la clase Pila.

Se muestra el menú y se solicita la opción al usuario.

Según la opción seleccionada, se ejecuta la operación correspondiente.

El bucle continúa hasta que el usuario elija 0 para salir.

## Cami