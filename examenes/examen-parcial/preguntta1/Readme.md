# DOCUMENTACIÓN DE LA PREGUNTA 1

## Explicación de como funciona

### 1. Ingreso de dimensiones
- Aqui el usuario tiene que indicar cauntas filas y columnas tendrá la metriz.
### 2. Ingreso de elementos
- Acá se llena cada posición **[i,j]** con un número ingresado por el usuario.
### 3. Mostrar matriz original
- Es para que se imprima en formato de tabla.

### 4. Variables de control
- **top, bottom, left, right**-> Indican los limitesd el recorrido
### 5. Recorrido en espiral
- Se recorre la primera fila **(top)**, luego la última columna **(right)**, después la fila inferior **(bottom)** y finalmente la primera columna **(left)**.
- Los límites se actualizan y el proceso se repite hasta cubrir toda la matriz.

---

## Explicación de las líneas de código

Los primeros 3 los explicaremos de forma mas resumida ya que ya lo detallamos en la documentación de la pregunta2

### 1. using System
Importa la librería para usar Console.

### 2. class Pregunta1 
Define la clase del programa.

### 3. static void Main() 
Punto de inicio.

### 4. int[,] matriz = new int[filas, cols];
Esto crea una matriz bidimensional con el tamaño que ingrese el usuario.

### 5. for (int i = 0; i < filas; i++)
Este es un bucle externo
 - Este es el bucle externo.

 - La variable **i** representa el índice de la fila.

 - Comienza en **0** y se incrementa **(i++)** hasta que i ya no sea menor que filas.

Es decir, este for recorre todas las filas de la matriz.

**Ejemplo:** si filas = 3, entonces i tomará los valores: 0, 1, 2.

### 6. for (int j = 0; j < cols; j++)

Este es un bucle interno
 - La variable **j** representa el índice de la columna.

 - Comienza en **0** y se incrementa hasta que **j** ya no sea menor que **cols**.

Es decir, este for recorre todas las columnas dentro de una fila específica.

**Ejemplo:** si cols = 4, entonces j tomará los valores: 0, 1, 2, 3.

---
### ¿Como trabajan ambos bucles?
- Por cada fila **(i)**, se recorren todas las columnas **(j)**.

- Es decir, se visitan todas las posiciones de la matriz en orden.
- En conclusión **i** controla las filas y **j** controla las columnas
### 7. Variables
Controlan hasta donde reocrrer la matriz y se van ajustando en cada vuelta para que el recorrido en espiral avance hacia el centro.
 - **top**= primera fila aún no recorrida.
 - **bottom** = última fila aún no recorrida.
 - **left** = primera columna aún no recorrida.
 - **right** = última columna aún no recorrida.

### 8. while (top <= bottom && left <= right)
Se asegura de que todavía haya elementos por recorrer en la espiral.
