# 📌 Ejercicio 8: Buscar Elemento en Arreglo Rotado

## 📖 Enunciado
Dado un **arreglo rotado y ordenado** (ejemplo: `[4,5,6,7,0,1,2]`), implementar una **búsqueda binaria modificada** para encontrar un número dado de manera eficiente.

---

## ✨ Ejemplo
Entrada: arreglo = [4,5,6,7,0,1,2], objetivo = 0
Salida: índice = 4

csharp
Copiar código

---

## 📌 Código en C#
```csharp
static int BuscarEnRotado(int[] arr, int objetivo)
{
    int izquierda = 0, derecha = arr.Length - 1;

    while (izquierda <= derecha)
    {
        int medio = (izquierda + derecha) / 2;

        if (arr[medio] == objetivo)
            return medio;

        if (arr[izquierda] <= arr[medio])
        {
            if (objetivo >= arr[izquierda] && objetivo < arr[medio])
                derecha = medio - 1;
            else
                izquierda = medio + 1;
        }
        else
        {
            if (objetivo > arr[medio] && objetivo <= arr[derecha])
                izquierda = medio + 1;
            else
                derecha = medio - 1;
        }
    }
    return -1;
}
🛠️ Explicación paso a paso
Arreglo rotado:
Un arreglo ordenado se rota en algún punto, por ejemplo:

makefile
Copiar código
Original: [0,1,2,4,5,6,7]
Rotado:   [4,5,6,7,0,1,2]
Idea principal:

Dividir el arreglo a la mitad con búsqueda binaria.

Verificar cuál de las mitades está ordenada.

Decidir si el número objetivo está en esa mitad o en la otra.

Complejidad:

Tiempo: O(log n)

Espacio: O(1)

✅ Ejemplo de ejecución
yaml
Copiar código
Arreglo rotado:
4 5 6 7 0 1 2 

El número 0 se encuentra en el índice 4.