<h1 align="center">DOCUMENTACION DE LOS EJERCICIOS DE ARREGLOS Y MATRICES</h1>

### 9. Recorrer Matriz en Espiral

1. Definir cuatro variables (arriba, abajo, izq, der).

2. Recorrer en espiral:

3. De izquierda a derecha.

4. De arriba a abajo.

5. De derecha a izquierda.

6. De abajo a arriba.

7. Reducir los límites después de cada recorrido.

```
while (arriba <= abajo && izq <= der)
{
    for (int j = izq; j <= der; j++) Console.Write(matriz[arriba, j] + " ");
    arriba++;
    for (int i = arriba; i <= abajo; i++) Console.Write(matriz[i, der] + " ");
    der--;
    if (arriba <= abajo)
    {
        for (int j = der; j >= izq; j--) Console.Write(matriz[abajo, j] + " ");
        abajo--;
    }
    if (izq <= der)
    {
        for (int i = abajo; i >= arriba; i--) Console.Write(matriz[i, izq] + " ");
        izq++;
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
