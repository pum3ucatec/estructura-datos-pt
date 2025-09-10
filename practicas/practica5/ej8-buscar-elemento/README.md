<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 8. Buscar Elemento en Arreglo Rotado

1. Usar búsqueda binaria modificada.

2. Identificar si la mitad izquierda o derecha está ordenada.

3. Reducir el rango según el valor buscado.

4. Retornar el índice si se encuentra, o -1 en caso contrario.

```
int BuscarEnRotado(int[] arr, int target)
{
    int izq = 0, der = arr.Length - 1;
    while (izq <= der)
    {
        int mid = (izq + der) / 2;
        if (arr[mid] == target) return mid;

        if (arr[izq] <= arr[mid])
        {
            if (target >= arr[izq] && target < arr[mid]) der = mid - 1;
            else izq = mid + 1;
        }
        else
        {
            if (target > arr[mid] && target <= arr[der]) izq = mid + 1;
            else der = mid - 1;
        }
    }
    return -1;
}
```

<h1 align= "center">Para subir tu avance al repositorio se hace de la siguiente manera:</h1>

1. Muevete a la carpeta de tu repositorio local.
   dirigete a la rama MASTER y descarga los ultimos cambio con `git fetch y git pull.`
2. Crea tu nueva rama con el comando `git checkout -b "nombre de tu rama".`
3. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
   una vez finalizado tu avance utiliza los siguientes comandos
4. `git add .` pasa a un estado de preparado o se mueven a stating
5. `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
6. `git push --set-upstream origin "nombre-rama" `que permite subir los cambios al repositorio local.
