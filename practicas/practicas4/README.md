# 📚 Proyecto: Implementación de una Pila en C#

Este proyecto implementa la **estructura de datos Pila (Stack)** en el lenguaje de programación **C#** utilizando la clase `List<int>` como base para almacenar los elementos.  

Una **pila** es una estructura de datos que sigue la lógica **LIFO (Last In, First Out)**, es decir, el último elemento en entrar es el primero en salir.

---

## 🚀 Funcionalidades principales

La clase `Pila` permite realizar las siguientes operaciones:

1. **Push** → Insertar un elemento en la pila.
2. **PushN** → Insertar varios elementos a la vez.
3. **Pop** → Eliminar el último elemento agregado (cima).
4. **Peek** → Ver el último elemento sin eliminarlo.
5. **Mostrar** → Imprimir todos los elementos de la pila.
6. **IsEmpty** → Verificar si la pila está vacía.
7. **Count** → Contar cuántos elementos hay en la pila.
8. **Clear** → Vaciar completamente la pila.

---

## 📝 Explicación del código

### Definición de la clase `Pila`
```csharp
class Pila
{
    private List<int> elementos = new List<int>();
```
Se define un atributo privado elementos de tipo List<int>, que es la lista donde se guardarán los valores de la pila. 

## Insertar elementos en la Pila 
``` csharp
public void Push(int valor)
{
    elementos.Add(valor);
    Console.WriteLine($"Se insertó {valor} en la pila.");
} 
```

Add(valor) agrega un nuevo elemento al final de la lista, que corresponde a la cima de la pila.

## Insertar múltiples elementos
```csharp
public void PushN(List<int> valores)
{
    foreach (int valor in valores)
    {
        Push(valor); // Reutilizamos el método Push
    }
}
```

Este método recorre una lista de valores y los inserta uno por uno en la pila reutilizando el método Push.

## Eliminar un elemento (Pop)
```csharp
public int Pop()
{
    if (IsEmpty())
    {
        Console.WriteLine("La pila está vacía, no se puede eliminar.");
        return -1;
    }

    int valor = elementos[elementos.Count - 1];
    elementos.RemoveAt(elementos.Count - 1);
    Console.WriteLine($"Se eliminó {valor} de la pila.");
    return valor;
}
```

Se obtiene el último elemento **(elementos[elementos.Count - 1]).**

Luego se elimina con RemoveAt.

Devuelve el valor eliminado.

## Ver la cima de la pila (Peek)
```csharp
public int Peek()
{
    if (IsEmpty())
    {
        Console.WriteLine("La pila está vacía.");
        return -1;
    }
    return elementos[elementos.Count - 1];
}
```

Permite consultar el último elemento sin eliminarlo.

## Mostrar todos los elementos
```csharp
public void Mostrar()
{
    if (IsEmpty())
    {
        Console.WriteLine("La pila está completamente vacía.");
        return;
    }

    Console.WriteLine("\nElementos en la pila:");
    for (int i = elementos.Count - 1; i >= 0; i--)
    {
        Console.WriteLine(elementos[i]);
    }
}
```

Se recorre la lista desde el último hasta el primero para mostrar los elementos en orden de pila (de cima a base).

## Métodos auxiliares

**IsEmpty() →** Verifica si la pila no tiene elementos.

**Count() →** Devuelve la cantidad de elementos en la pila.

**Clear() →** Vacía por completo la pila.