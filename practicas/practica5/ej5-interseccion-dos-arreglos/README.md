<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 5. Intersección de dos Arreglos

1. Recorrer ambos arreglos con dos bucles anidados.

2. Si un valor coincide, añadirlo al arreglo intersección.

3. Evitar duplicados marcando con int.MinValue.

4. Mostrar el resultado.

```
for (int i = 0; i < arr1.Length; i++)
{
    for (int j = 0; j < arr2.Length; j++)
    {
        if (arr1[i] == arr2[j])
        {
            interseccion[k++] = arr1[i];
            arr2[j] = int.MinValue; // evitar repetición
            break;
        }
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
