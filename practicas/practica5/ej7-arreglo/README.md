<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 7. Arreglo de Productos Excepto el Índice

1. Usar dos arreglos auxiliares (left y right).

2. left[i] guarda el producto de todos los elementos a la izquierda.

3. right[i] guarda el producto de todos los elementos a la derecha.

4. Multiplicar ambos para obtener el resultado final.

```
for (int i = 0; i < n; i++)
{
    resultado[i] = left[i] * right[i];
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
