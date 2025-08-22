# **Pregunta 1** - *Espiral en una Matriz* 
*Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.* 

*Ejemplo:*
<pre>
[ [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9] ]
</pre>
→ `[1, 2, 3, 6, 9, 8, 7, 4, 5]`.

**Estilo de nombrado:**

- Clase: → **PascalCase** ( `pregunta1`)
- Variables → **snake_case** (`num_filas`, `num_columnas`)
* Método → **PascalCase** (`ImprimirEspiral`).

---
## **1. Descripcion**

Este programa construye una **matriz** ingresada por teclado y luego recorre sus elementos en un recorrido en **forma de espiral** y los muestra.

El recorrido va asi:
1. De izquierda a derecha en la primera fila
2. De arriba hacia abajo en la ultima columna
3. De derecha a izquierda en la ultima fila restante
4. De abajo hacia arriba en la primera columna

Este recorrido se repite mientras va reduciendo el numero de filas y columnas hasta que se termine de recorrer toda la matriz.

## **2. Flujo del programa**

1. Se solicita al usuario el numero de filas (`num_filas`) y columnas (`num_columnas`)
2. Se pide al usuario que llene la matriz con datos ingresados por teclado
3. Se llama a la función `ImprimirEspiral`, que utiliza cuatro variables para delimitar el area restante de la matriz:
   * `inicioFila`
   * `inicioCol`
   * `num_filas`
   * `num_columnas`
4. Se imprime la matriz en el orden espiral hasta que no queden elementos

## **3. Ejecución**
1. Entramos a la carpeta del ejercicio en la terminal, asi como se ve en la imagen:
![Ruta](Carpeta%20ejecucion.png)
2. Ahora ingresamos el siguiente comando:
    <pre>dotnet run</pre>
3. Ingresamos los datos de la siguiente manera:
    <pre>Ingrese el número de filas de la matriz: 3
    Ingrese el número de columnas de la matriz: 3
    Ingrese los elementos de la matriz:
    (un numero en cada linea)
    1
    2
    3
    4
    5
    6
    7
    8
    9</pre>
4. Despues se debera mostrar el siguiente resultado:
    <pre>Recorrido en espiral:
    1 2 3 6 9 8 7 4 5 </pre>
