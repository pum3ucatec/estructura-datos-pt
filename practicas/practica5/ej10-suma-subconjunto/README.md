<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 10. Suma de Subconjuntos (Backtracking)

1. Usar recursividad para generar subconjuntos.

2. Si la suma de un subconjunto es igual al target, mostrarlo.

3. Detenerse si la suma supera al target o si se llega al final.

4. Explorar dos opciones: incluir o excluir cada elemento.

```
void BuscarSubconjuntos(int[] arr, int index, List<int> subset, int suma)
{
    if (suma == target)
    {
        Console.WriteLine("[" + string.Join(", ", subset) + "]");
        return;
    }
    if (suma > target || index >= arr.Length) return;

    subset.Add(arr[index]);
    BuscarSubconjuntos(arr, index + 1, subset, suma + arr[index]);
    subset.RemoveAt(subset.Count - 1);

    BuscarSubconjuntos(arr, index + 1, subset, suma);
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
