<h1 align="center"> DOCUMENTACION DEL PRIMER EXAMEN-PARCIAL PREGUNTA 1 </h1>

## DESARROLLO DEL EJERICIO 1:

- Definimos la matriz de tipo entero **INT**
  con el nombre **matriz**

- Llama a la función que recorrerá la matriz en forma de espiral y luego imprime el resultado. Se llama de la siguiente manera: **`List<int> resultado = RecorrerEspiral(matriz);`**

- Muestra en pantalla el resultado con la palabra reservada **`Console.WriteLineConsole.WriteLine(string.Join(", ", resultado));`** que concatena los elementos de la coleccion resultado.

- Dentro la funcion **RecorreEspiral** de tipo **INT**, definimos como **INT** las filas y columnas, y con **inicioFila**, **InicioCol**, **finFila**, **finCol** que marcan el inicio del rango de filas y columnas.

- Definimos un bucle **WHILE** que indica : mientras no se crucen seguira recorriendo la espiral.

- Posteriormente definimos 2 bucles **FOR** para recorrer, uno para recorrer la fila de izquierda a derecha

1. `for (int i = inicioCol; i <= finCol; i++)
    espiral.Add(matriz[inicioFila, i]);
inicioFila++;`

y la otra para bajar por la columna derecha

2. `for (int i = inicioFila; i <= finFila; i++)
    espiral.Add(matriz[i, finCol]);
finCol--;`

y otros **FOR** anidados dentro de una sentencia **IF**, el primero que va de derecha a izquierda en la fila inferior.

3. `if (inicioFila <= finFila)
{
    for (int i = finCol; i >= inicioCol; i--)
        espiral.Add(matriz[finFila, i]);
    finFila--;
}`

y el segundo para que suba por la columna izquierda

4.`if (inicioCol <= finCol)
{
    for (int i = finFila; i >= inicioFila; i--)
        espiral.Add(matriz[i, inicioCol]);
    inicioCol++;
}`

El resultado final es:

- Fila superior → [1, 2, 3]

- Columna derecha → [6, 9]

- Fila inferior → [8, 7]

- Columna izquierda → [4]

- Repite dentro (solo queda el 5 en el centro).

- Recorrido final: 1, 2, 3, 6, 9, 8, 7, 4, 5\*\*

 <h1 align="center">Subir el archivo al repositorio:</h1>

Para subir tu avance al repositorio se hace de la siguiente manera:

1. muevete a la carpeta de tu repositorio local.
2. dirigete a la rama **MASTER** y descarga los ultimos cambio con `git fetch` y `git pull`.
3. Crea tu nueva rama con el `comando git checkout -b "nombre de tu rama"`.
4. Dirigete a tu rama con el comando `git chekckout "nombre de tu rama"` y comienza a trabajar.
5. una vez finalizado tu avance utiliza los siguientes comandos

- `git add .` pasa a un estado de preparado o se mueven a **stating**
- `git commit -m "descripcion"` que guarda los cambios en tu historial local de git
- `git push --set-upstream origin "nombre de la rama"` que permite subir los cambios al repositorio local.
