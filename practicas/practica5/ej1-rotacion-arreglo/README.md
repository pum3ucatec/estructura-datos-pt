<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

## 1. Rotación de Arreglo

1. Definir la función `RotarArreglo` que recibe un arreglo y un número de rotaciones `k`.
2. Calcular la nueva posición de cada elemento usando la fórmula `(i + k) % n`.
3. Crear un arreglo auxiliar para guardar el resultado.
4. Mostrar el arreglo original y el rotado.

```
static void RotarArreglo(int[] arr, int k)
{
    int n = arr.Length;
    if (n == 0) return;

    k = k % n;
    int[] resultado = new int[n];

    for (int i = 0; i < n; i++)
    {
        int nuevaPos = (i + k) % n;
        resultado[nuevaPos] = arr[i];
    }

    for (int i = 0; i < n; i++)
    {
        arr[i] = resultado[i];
    }
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
