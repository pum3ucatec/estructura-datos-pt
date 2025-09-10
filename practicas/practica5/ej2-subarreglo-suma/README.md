<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 2. Suma Máxima de un Subarreglo (Kadane’s Algorithm)

1. Usar variables maxHastaAqui y maxTotal.

2. Recorrer el arreglo acumulando la suma máxima hasta cada posición.

3. El resultado final será el máximo subarreglo encontrado.

```
static int MaxSubArray(int[] arr)
{
    int maxHastaAqui = arr[0];
    int maxTotal = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        maxHastaAqui = Math.Max(arr[i], maxHastaAqui + arr[i]);
        maxTotal = Math.Max(maxTotal, maxHastaAqui);
    }
    return maxTotal;
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
