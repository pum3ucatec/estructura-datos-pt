**INDICE**
- [Documentación de la practica5](#documentación-de-la-practica5)
  - [1. Rotación de Arreglo](#1-rotación-de-arreglo)
  - [2. Subarreglo con Suma Máxima (Kadane’s Algorithm)](#2-subarreglo-con-suma-máxima-kadanes-algorithm)
  - [3. Eliminar Duplicados en un Arreglo Ordenado](#3-eliminar-duplicados-en-un-arreglo-ordenado)
  - [4. Encontrar el Número que Falta](#4-encontrar-el-número-que-falta)
  - [5. Intersección de Dos Arreglos](#5-intersección-de-dos-arreglos)
  - [6. Matriz Transpuesta](#6-matriz-transpuesta)
  - [7. Arreglo de Productos Excepto el Índice](#7-arreglo-de-productos-excepto-el-índice)
  - [8. Buscar Elemento en Arreglo Rotado](#8-buscar-elemento-en-arreglo-rotado)
  - [9. Espiral en una Matriz](#9-espiral-en-una-matriz)
  - [10. Suma de Subconjuntos (Backtracking)](#10-suma-de-subconjuntos-backtracking)
# Documentación de la practica5
Esta practica contiene ejercicios con una implementación de arreglos mas avanzados.

Esta práctica sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase

- Variables locales y parámetros → camelCase
  
--- 

## 1. Rotación de Arreglo
Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.

**Archivo:** [`e1-rotacion-de-arreglo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e1-rotacion-de-arreglo/Program.cs)

- Se solicita al usuario el tamaño del arreglo `(n)` y se declara un arreglo arr de ese tamaño.

- Se pide al usuario que ingrese los elementos del arreglo mediante un bucle `for`.

- Se solicita el número de posiciones a rotar `(k)`.

   - Se aplica `k = k % n` para manejar casos donde `k` sea mayor que el tamaño del arreglo.

- Se crea un arreglo auxiliar `rotated` para almacenar los elementos rotados.

- La rotación del arreglo se realiza con la fórmula:
    
      rotated[(i + k) % n] = arr[i];

   - Esto asegura que los elementos se ubiquen correctamente, incluso cuando se supera el final del arreglo.

- Finalmente, se imprime el arreglo rotado usando un bucle `foreach`.

---

## 2. Subarreglo con Suma Máxima (Kadane’s Algorithm)
Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.

**Archivo:** [`e2-subarreglo-con-suma-maxima/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e2-subarreglo-con-suma-maxima/Program.cs)

- Se declara un arreglo que puede contener valores positivos y negativos.

- Se implementa el algoritmo de `Kadane`, que encuentra el subarreglo contiguo con la suma máxima de manera eficiente.

- Variables principales:

   - `maxSum`:Almacena la suma máxima encontrada hasta el momento (int.MinValue al inicio).

    - `currentSum`: Suma acumulada mientras se recorre el arreglo.

    - `start`, `end` : Indices que marcan el inicio y fin del subarreglo con suma máxima.

    - `tempStart`: Índice temporal para seguir el posible inicio de un nuevo subarreglo.

- Recorrido del arreglo con un bucle `for`:

    - Se suma el elemento actual a `currentSum`.

    - Si `currentSum > maxSum`, se actualiza `maxSum` y los índices `start`  y `end`.

    - Si `currentSum < 0`, se reinicia `currentSum` y se actualiza `tempStar`t para empezar un nuevo subarreglo.

- Finalmente, se imprime la suma máxima y el subarreglo contiguo que produce dicha suma usando otro bucle for.

---

## 3. Eliminar Duplicados en un Arreglo Ordenado
Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`.  
Ejemplo: `[1, 1, 2, 2, 3, 4, 4]` → `[1, 2, 3, 4]`.

**Archivo:** [`e3-eliminar-duplicados/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e3-eliminar-duplicados/Program.cs)

- Se declara un arreglo que puede contener elementos duplicados.

- Se obtiene la longitud del arreglo con `n = numeros.Length`.

- Se verifica si el arreglo está vacío `(n == 0)`y se termina la ejecución si es así.

- Se utiliza la variable `j` como índice para la posición de elementos únicos en el arreglo.

- El bucle `for` recorre el arreglo desde el segundo elemento `(i = 1)`.

- Si el elemento actual `(numeros[i])` es diferente al último elemento único `(numeros[j])`, se incrementa `j` y se asigna numeros[j] = numeros[i].

- Esto mantiene los elementos únicos al inicio del arreglo.
 
- Al finalizar, los elementos del índice `0` hasta `j` representan el arreglo sin duplicados.

- Y finalmente se imprime el arreglo resultante con un bucle `for`.
  
---

## 4. Encontrar el Número que Falta
En un arreglo de números del `1` al `n`, falta un número. Encuentra cuál es.  
Ejemplo: `[1, 2, 4, 5, 6]` → Falta `3`.

**Archivo:** [`e4-encontrar-numero-que-falta/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e4-encontrar-numero-que-falta/Program.cs)

- Se declara un arreglo que contiene números consecutivos del 1 al n, pero con un número faltante.

- Se calcula `n = numeros.Length + 1`, que representa el total de números esperados incluyendo el faltante.

- Se calcula la suma esperada de los números del 1 al n usando la fórmula:
   
      sumaEsperada = n * (n + 1) / 2

- Se calcula la **suma real** de los elementos presentes en el arreglo usando un bucle `foreach`.

- El **número faltante** se obtiene restando la suma real de la suma esperada:
        
        faltante = sumaEsperada - sumaActual

- Y finalmente, se imprime el número que falta en el arreglo.

---

## 5. Intersección de Dos Arreglos
Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ.  
Ejemplo: `[1,2,2,1]` y `[2,2]` → `[2,2]`.

**Archivo:** [`e5-interseccion-de-dos-arreglos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e5-interseccion-de-dos-arreglos/Program.cs)

- Se declaran dos arreglos de enteros arreglo1 y arreglo2 que pueden contener elementos duplicados.

- Se imprimen los arreglos originales usando `string.Join` para mayor claridad.

- Para encontrar los elementos comunes se usan dos bucles anidados:

    - Bucle externo recorre `arreglo1`.

    - Bucle interno recorre `arreglo2`.

-  Si se encuentra un elemento igual `(arreglo1[i] == arreglo2[j])`:

    - Se imprime el elemento como común.

    - Se reemplaza `arreglo2[j]` por `int.MinValue` para evitar contarlo nuevamente en caso de duplicados.

    - Se rompe el bucle interno con `break` para pasar al siguiente elemento de `arreglo1`.

- Este método asegura que se impriman los elementos comunes respetando la cantidad de repeticiones.


---

## 6. Matriz Transpuesta
Dada una **matriz** (arreglo bidimensional), encuentra su transpuesta.  
Ejemplo:  
```
[ [1, 2, 3],
  [4, 5, 6] ]
```
→  
```
[ [1, 4],
  [2, 5],
  [3, 6] ]
```

**Archivo:** [`e6-matriz-transpuesta/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e6-matriz-transpuesta/Program.cs)

- Se declara una matriz bidimensional matriz de tamaño 2x3.

- Se obtienen las dimensiones:

    - `filas = matriz.GetLength(0)` → número de filas.

    - `cols = matriz.GetLength(1)`→ número de columnas.

- Se imprime la matriz original usando bucles anidados (for), recorriendo filas y columnas.

- Se declara una nueva matriz transpuesta de tamaño invertido [cols, filas] para almacenar la transpuesta.

- La **transposición** se realiza intercambiando filas por columnas:
  
         transpuesta[j, i] = matriz[i, j];

- Finalmente, se imprime la matriz transpuesta usando nuevamente bucles anidados, mostrando cómo las filas y columnas originales se han invertido
  
---

## 7. Arreglo de Productos Excepto el Índice
Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de todos los elementos excepto el de esa posición (sin usar división).  
Ejemplo: `[1, 2, 3, 4]` → `[24, 12, 8, 6]`.

**Archivo:** [`e7-arreglo-de-productos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e7-arreglo-de-productos/Program.cs)

- Se declara un arreglo de enteros arreglo y se obtiene su tamaño `n`.

- Se crean tres arreglos auxiliares:

     - `resultado` → para almacenar el producto final de cada posición.

     - `izquierda` → para almacenar el producto acumulado de los elementos a la izquierda de cada posición.

     - `derecha` → para almacenar el producto acumulado de los elementos a la derecha de cada posición.
     - 
- La lógica funcionaa así:

      En la posición 0: 4 × 5 × 11 = 220

      En la posición 1: 12 × 5 × 11 = 660

      En la posición 2: 12 × 4 × 11 = 528

      En la posición 3: 12 × 4 × 5 = 240 

---

## 8. Buscar Elemento en Arreglo Rotado
Dado un arreglo **rotado y ordenado** (ej. `[4,5,6,7,0,1,2]`), implementa búsqueda binaria modificada para encontrar un número dado.

**Archivo:** [`e8-buscar-elemento-en-arreglo-rotado/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e8-buscar-elemento-en-arreglo-rotado/Program.cs)

- Se declara un arreglo rotado y ordenado `nums` y un número `target` a buscar.

- Se implementa el método `Buscar` que realiza una búsqueda binaria modificada:

     - Se inicializan l`eft = 0` y `right = nums.Length - 1`.

     - Mientras `left <= right`:

- Se calcula el índice medio 
  
        mid = (left + right) / 2

- Si `nums[mid] == target`, se retorna **mid**.

- Se verifica cuál mitad del arreglo está ordenada:

   - **Izquierda ordenada**: nums[left] <= nums[mid]

        - Si `target` está dentro de ese rango, se ajusta `right = mid - 1`.

        - Si no, se ajusta `left = mid + 1`.

    - **Derecha ordenada**: si la izquierda no está ordenada, entonces la derecha sí.

        - Si target está dentro del rango derecho, se ajusta `left = mid + 1`.

        - Si no, se ajusta `right = mid - `1.

- Si no se encuentra el target, se retorna -1.

- En `Main`, se llama a `Buscar` y se imprime el **índice del elemento encontrado** o un mensaje indicando que no se encontró.
---

## 9. Espiral en una Matriz
Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.  
Ejemplo:  
```
[ [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9] ]
```
→ `[1, 2, 3, 6, 9, 8, 7, 4, 5]`.

**Archivo:** [`e9-espiral-en-una-matriz/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e9-espiral-en-una-matriz/Program.cs)

- Se declara una **matriz bidimensional** matriz.

- Se obtienen las dimensiones:

    - `filas = matriz.GetLength(0)` → número de filas.

    - `cols = matriz.GetLength(1)`→ número de columnas.

- Se definen los límites del recorrido:

    - `top` → fila superior, inicial 0.

    - `bottom` → fila inferior, inicial filas - 1.

    - `left` → columna izquierda, inicial 0.

    - `right` → columna derecha, inicial cols - 1.

- Se imprime la matriz original.

- Para recorrer la **matriz en espiral** se utiliza un bucle while `(top <= bottom && left <= right)` que hace lo siguiente:

- El proceso se repite hasta recorrer todos los elementos en espiral.

- Se imprime el recorrido en la misma línea.

---

## 10. Suma de Subconjuntos (Backtracking)
Dado un arreglo de enteros y un número `target`, encuentra todos los subconjuntos cuya suma sea igual al `target`.  
Ejemplo: `[2, 3, 6, 7], target=7` → subconjuntos `[7]`, `[2, 2, 3]`.

**Archivo:** [`e10-suma-de-subconjuntos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica5/practicas/practica5/e10-suma-de-subconjuntos/Program.cs)

- Se solicita al usuario ingresar un arreglo de enteros y un número target.

- Se utiliza una lista de listas `(resultados)` para almacenar todos los subconjuntos cuya suma sea igual al target.

- El método `EncontrarSubconjuntos` recorre el arreglo de manera recursiva:

     - **Incluir el elemento actual** y restarlo del target.

     - **Excluir el elemento actual** y continuar la búsqueda.

- Cuando `target == 0`, se agrega el subconjunto actual a `resultados`.

- Al finalizar, se muestran todos los subconjuntos encontrados.

- Si no existe ninguno, se indica que no hay subconjuntos que cumplan la condición.