**INDICE**
- [Documentación de la practica3](#documentación-de-la-practica3)
  - [1. Declaración e inicialización](#1-declaración-e-inicialización)
  - [2. Recorrido con `for`](#2-recorrido-con-for)
  - [3. Suma de elementos](#3-suma-de-elementos)
  - [4. Promedio de elementos](#4-promedio-de-elementos)
  - [5. Mayor y menor valor](#5-mayor-y-menor-valor)
  - [6. Búsqueda lineal](#6-búsqueda-lineal)
  - [7. Contar ocurrencias](#7-contar-ocurrencias)
  - [8. Invertir arreglo](#8-invertir-arreglo)
  - [9. Ordenamiento (básico)](#9-ordenamiento-básico)
  - [10. Arreglo bidimensional (matriz)](#10-arreglo-bidimensional-matriz)
# Documentación de la practica3 
 Esta practica contiene ejercicios utilizando arreglos en C#, y cada ejercicio sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase ( Ejemplo: Ejercicio1, Main).

- Variables locales y parámetros → camelCase ( Ejemplo: int i).

--- 

## 1. Declaración e inicialización  

Declara un arreglo de 5 enteros y asígnales valores manualmente. Luego imprime todos los valores en pantalla.  

**Archivo:** [`e1-declaracion-e-inicializacion/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e1-declaracion-e-inicializaci%C3%B3n/Program.cs)

- Se utiliza un bucle for que recorre desde i = 0 hasta i < edades.Length para acceder a cada elemento del arreglo.

- Dentro del bucle se imprime cada elemento usando Console.WriteLine(edades[i]).

- La propiedad .Length devuelve la cantidad de elementos del arreglo, evitando errores si se cambia el tamaño del arreglo más adelante.


**Ejemplo de salida:**

     10

     20

     30

     40

     50

---

## 2. Recorrido con `for`  

Crea un arreglo de 10 números enteros y muéstralos en consola utilizando un ciclo `for`.

**Archivo:** [`e2-recorrido-con-for/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e2-recorrido-con-for/Program.cs)

- Se declara un arreglo de enteros numeros con 10 elementos del 1 al 10.

- Se utiliza un bucle for para recorrer todos los elementos del arreglo.

- La condición i < numeros.Length asegura que se recorra todo el arreglo sin exceder su tamaño.

- Cada elemento se imprime en consola con Console.WriteLine(numeros[i]).

---

## 3. Suma de elementos  

Dado un arreglo de enteros, calcula la suma de todos sus elementos.  

**Archivo:** [`e3-suma-de-elementos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e3-suma-de-elementos/Program.cs)

- Se declara un arreglo de enteros numeros con los elementos {5, 10, 15, 20}.

- Se utiliza una variable acumuladora suma para almacenar la suma de los elementos.

- El bucle for recorre cada elemento del arreglo desde i = 0 hasta i < numeros.Length.

- En cada iteración se suma el valor del elemento actual a la variable suma.

- Al final, se imprime el resultado de la suma con Console.WriteLine.

**Ejemplo esperado:**

     Arreglo: [5, 10, 15, 20]

     Suma: 50

---


 

## 4. Promedio de elementos  

Ingresa 5 calificaciones en un arreglo y calcula el promedio.  

**Archivo:** [`e4-promedio-de-elementos/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e4-promedio-de-elementos/Program.cs)

- Se declara un arreglo de enteros calificaciones con 5 elementos asignados manualmente.

- Se utiliza una variable suma para acumular la suma de todas las calificaciones.

- El bucle for recorre cada elemento del arreglo y lo suma a la variable suma.

- Se calcula el promedio dividiendo suma entre calificaciones.Length, que es la cantidad de elementos del arreglo.

- El resultado se imprime en consola usando Console.WriteLine.

**Ejemplo esperado:**

     Notas: [80, 70, 90, 60, 100]

     Promedio: 80


---

## 5. Mayor y menor valor  

Crea un programa que lea 8 números en un arreglo y muestre el mayor y el menor.  

**Archivo:** [`e5-mayor-y-menor-valor/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e5-mayor-y-menor-valor/Program.cs)

 
- Se crean dos variables, mayor y menor, inicializadas con el primer elemento del arreglo (numeros[0]).

- El bucle for recorre los elementos restantes del arreglo (i = 1 hasta i < numeros.Length).

- Dentro del bucle:

   - Si el elemento actual es mayor que mayor, se actualiza mayor.

   - Si el elemento actual es menor que menor, se actualiza menor.

Al final, se imprime en consola el valor más grande y el más pequeño del arreglo.

**Ejemplo esperado:**

    Números: [12, 5, 8, 20, 3, 17, 25, 10]

    Mayor: 25

    Menor: 3


---

## 6. Búsqueda lineal  

Dado un arreglo de 10 números, pide al usuario un número y determina si está dentro del arreglo (imprime la posición si existe).  


**Archivo:** [`e6-busqueda-lineal/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e6-busqueda-lineal/Program.cs)
 

- Se utilizan dos variables auxiliares:

    - encontrado (boolean) para indicar si el número existe en el arreglo.

    - posicion para almacenar la posición del número encontrado, inicializada en -1.

- El bucle for recorre todos los elementos del arreglo.

- Si encuentra un elemento igual a buscar, se actualizan encontrado y posicion y se sale del bucle con break.

- Al finalizar el bucle, se imprime un mensaje indicando si el número fue encontrado y, en ese caso, en qué posición.

**Ejemplo esperado:**

     Ingrese un número: 17

     El número 17 se encuentra en la posición 4

---

## 7. Contar ocurrencias  

Dado un arreglo de enteros, pide un número y cuenta cuántas veces aparece en el arreglo.  

**Archivo:** [`e7-contar-ocurrencias/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e7-contar-ocurrencias/Program.cs)


- Se utiliza una variable contador para llevar la cuenta de cuántas veces aparece el número en el arreglo.

- El bucle for recorre cada elemento del arreglo y, si encuentra un elemento igual a buscado, incrementa contador.

- Al finalizar el bucle, se imprime un mensaje indicando cuántas veces aparece el número o si no se encuentra en el arreglo.

**Ejemplo esperado:** 

     Arreglo: [2, 5, 2, 8, 2, 9]

    Número buscado: 2

    El número aparece 3 veces


---

## 8. Invertir arreglo  

Dado un arreglo, crea un segundo arreglo que contenga los mismos elementos pero en orden inverso.  

**Archivo:** [`e8-invertir-arreglo/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e8-invertir-arreglo/Program.cs)

- Se declara un arreglo original con algunos elementos.

- Se crea un segundo arreglo inverso con el mismo tamaño que numeros para almacenar los elementos en orden inverso.

- El bucle for recorre cada índice i del arreglo original y asigna a inverso[i] el valor de numeros[numeros.Length - 1 - i].

- Se usan bucles foreach para imprimir los elementos de ambos arreglos: primero el original y luego el inverso.

- Esto permite ver claramente cómo los elementos fueron invertidos sin modificar el arreglo original.

**Ejemplo esperado:**

    Arreglo original: [1, 2, 3, 4, 5]

    invertido: [5, 4, 3, 2, 1]

---

## 9. Ordenamiento (básico)  

Implementa un algoritmo sencillo (por ejemplo, **Burbuja**) para ordenar un arreglo de enteros de menor a mayor.  

**Archivo:** [`e9-ordenamiento-basico/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e9-ordenamiento-basico/Program.cs)

- Se declara un arreglo de enteros con elementos desordenados.

- Se imprime el arreglo original usando el método auxiliar MostrarArreglo.

- Se implementa el algoritmo de burbuja para ordenar el arreglo de menor a mayor:

   - El bucle externo recorre todas las posiciones del arreglo.

   - El bucle interno compara elementos adyacentes y los intercambia si están en el orden incorrecto (numeros[j] > numeros[j + 1]).

   - La variable temporal temp se usa para realizar el intercambio sin perder datos.

- Después de ordenar, se imprime el arreglo ordenado con el mismo método MostrarArreglo.

- El uso de un método auxiliar mejora la legibilidad y evita repetir código al imprimir arreglos.

**Ejemplo esperado:**

    Arreglo desordenado: [8, 3, 5, 1, 9]

    Arreglo ordenado: [1, 3, 5, 8, 9]

---

## 10. Arreglo bidimensional (matriz)  

Declara una matriz de 3x3, inicialízala con valores y muestra la suma de cada fila y cada columna.  

**Archivo:** [`e10-arreglo-bidimensional/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica3/practicas/practica3/e10-arreglo-bidimensional/Program.cs)

- Se declara una matriz de enteros matriz de 3x3 con valores predefinidos.

- Se obtienen las dimensiones de la matriz:

    - filas = matriz.GetLength(0) → número de filas.

    - columnas = matriz.GetLength(1) → número de columnas.

- Para calcular la suma de cada fila:

    - Se recorre cada fila con un bucle externo for.

    - Un bucle interno recorre cada columna de la fila y acumula la suma en sumaFila.

    - Se imprime la suma de cada fila.

- Para calcular la suma de cada columna:

    - Se recorre cada columna con un bucle externo for.

    - Un bucle interno recorre cada fila de la columna y acumula la suma en sumaColumna.

    - Se imprime la suma de cada columna.

- El uso de bucles anidados permite recorrer correctamente todos los elementos de la matriz.

**Ejemplo esperado:**

    Suma de la fila 1: 36
    Suma de la fila 2: 37   
    Suma de la fila 3: 138  
    Suma de la columna 1: 87
    Suma de la columna 2: 78
    Suma de la columna 3: 46

