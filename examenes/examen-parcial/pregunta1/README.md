# pregunta 1 - Recorrido en Espiral de una Matriz

## Descripción

Este ejercicio imprime los elementos de una **matriz**
siguiendo un recorrido en forma de **espiral**.

## Lógica 

1. Primero comemos toda la fila de arriba (de izquierda a derecha)./

2. Luego bajamos y comemos toda la columna de la derecha (de arriba hacia abajo)./

3. Después seguimos por la fila de abajo (de derecha a izquierda)./

4. Y por último subimos por la columna de la izquierda (de abajo hacia arriba)./

¡Ahora tenemos un cuadro más pequeño en el centro!
Repetimos el proceso hasta que no quede nada.

## 🔹 Ejemplo de ejecución

    Matriz:
    [ [1, 2, 3],
      [4, 5, 6],
      [7, 8, 9] ]

    Recorrido en espiral: [1, 2, 3, 6, 9, 8, 7, 4, 5]
