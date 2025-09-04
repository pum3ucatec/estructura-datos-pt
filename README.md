# Buscar un elemento en un arreglo - Recursividad
```csharp
public static bool BuscarElementoRecursivo(int[] arr, int valor)
{
    return BuscarRecursivo(arr, valor, 0);
}

// Función auxiliar recursiva
private static bool BuscarRecursivo(int[] arr, int valor, int indice)
{
    // Caso base 1: fin del array
    if (indice >= arr.Length)
        return false;
    
    // Caso base 2: elemento encontrado
    if (arr[indice] == valor)
        return true;
    
    // Caso recursivo: siguiente elemento
    return BuscarRecursivo(arr, valor, indice + 1);
}
```
## Parámetros

arr: el arreglo donde buscamos.

valor: el número que queremos encontrar.

indice = 0: indica en qué posición del arreglo estamos buscando. Si no se envía, comienza desde 0.

### Casos base

La recursión siempre necesita condiciones de parada. Aquí tenemos dos:

```csharp
if (indice >= arr.Length)
    return false;
```
```csharp
if (arr[indice] == valor)
    return true;
```
Paso recursivo

```csharp
return BuscarElementoRecursivo(arr, valor, indice + 1);
```
## Ejemplo en ejecución

Supongamos que tenemos:
```csharp

int[] numeros = { 3, 7, 10, 15, 20 };
Console.WriteLine(BuscarElementoRecursivo(numeros, 10));

```
### Llamadas recursivas paso a paso:

```csharp
indice = 0 → arr[0] = 3 → no es 10 → llama otra vez con indice = 1.

indice = 1 → arr[1] = 7 → no es 10 → llama otra vez con indice = 2.

indice = 2 → arr[2] = 10 → ¡sí es 10! → devuelve true.
```

