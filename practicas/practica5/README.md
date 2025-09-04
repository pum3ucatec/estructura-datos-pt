# **Ejercicios Avanzados con Arreglos en C#**

**INDICE** 
- [**Ejercicios Avanzados con Arreglos en C#**](#ejercicios-avanzados-con-arreglos-en-c)
- [**Requisitos y ejecucion del programa**](#requisitos-y-ejecucion-del-programa)
- [**1. Rotación de Arreglo**](#1-rotación-de-arreglo)
	- [**1.1. Enunciado:**](#11-enunciado)
	- [**1.2. Solucion:**](#12-solucion)
	- [**1.3. Explicacion:**](#13-explicacion)
- [**2. Subarreglo con Suma Máxima (Kadane’s Algorithm)**](#2-subarreglo-con-suma-máxima-kadanes-algorithm)
	- [**2.1. Enunciado:**](#21-enunciado)
	- [**2.2. Solucion:**](#22-solucion)
	- [**2.3. Explicacion:**](#23-explicacion)
- [**3. Eliminar Duplicados en un Arreglo Ordenado**](#3-eliminar-duplicados-en-un-arreglo-ordenado)
	- [**3.1. Enunciado:**](#31-enunciado)
	- [**3.2. Solucion:**](#32-solucion)
	- [**3.3. Explicacion:**](#33-explicacion)
- [**4. Encontrar el Número que Falta**](#4-encontrar-el-número-que-falta)
	- [**4.1. Enunciado:**](#41-enunciado)
	- [**4.2. Solución:**](#42-solución)
	- [**4.3. Explicación:**](#43-explicación)
- [**5. Intersección de Dos Arreglos**](#5-intersección-de-dos-arreglos)
	- [**5.1. Enunciado:**](#51-enunciado)
	- [**5.2. Solución:**](#52-solución)
	- [**5.3. Explicación:**](#53-explicación)
- [**6.Matriz Transpuesta**](#6matriz-transpuesta)
	- [**6.1. Enunciado:**](#61-enunciado)
	- [**6.2. Solución:**](#62-solución)
	- [**6.3. Explicación:**](#63-explicación)
- [**7. Arreglo de Productos Excepto el Índice**](#7-arreglo-de-productos-excepto-el-índice)
	- [**7.1. Enunciado:**](#71-enunciado)
	- [**7.2. Solución:**](#72-solución)
	- [**7.3. Explicación:**](#73-explicación)
- [**8. Buscar Elemento en Arreglo Rotado**](#8-buscar-elemento-en-arreglo-rotado)
	- [**8.1. Enunciado:**](#81-enunciado)
	- [**8.2. Solución:**](#82-solución)
	- [**8.3. Explicación:**](#83-explicación)
- [**9. Espiral en una Matriz**](#9-espiral-en-una-matriz)
	- [**9.1. Enunciado:**](#91-enunciado)
	- [**9.2. Solución:**](#92-solución)
	- [**9.3. Explicación:**](#93-explicación)
- [**10.  Suma de Subconjuntos (Backtracking)**](#10--suma-de-subconjuntos-backtracking)
	- [**10.1. Enunciado:**](#101-enunciado)
	- [**10.2. Solución:**](#102-solución)
	- [**10.3. Explicación:**](#103-explicación)


# **Requisitos y ejecucion del programa**

Este repositorio contiene 10 ejercicios avanzados en C# sobre arreglos y matrices.  
Hechos en Visual Studio Code usando .NET (C#).

**Requisitos**
- Tener instalado .NET SDK 
- Editor recomendado: Visual Studio Code

Para ejecutar un ejercicio (En la carpeta respectiva ejerN):

```bash
dotnet run
```


# **1. Rotación de Arreglo**

## **1.1. Enunciado:**

Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.

- **Que hace:** Rota el arreglo hacia la derecha k posiciones.

## **1.2. Solucion:**  
- Se utiliza el operador modulo `%` para calcular la nueva posicion de cada elemento.  
- Cada elemento arr[i] se mueve a la posición (i + k) % n.
- Se copia en un nuevo arreglo ya rotado.

## **1.3. Explicacion:** 
En este ejercicio se rota los elementos de un arreglo hacia la derecha con una cantidad determinada de veces pedida desde consola. Opte por usar el modulo de % para evitar que k sobrepase de numero de elementos que tiene el arrelgo.


# **2. Subarreglo con Suma Máxima (Kadane’s Algorithm)**

## **2.1. Enunciado:**
Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.

- **Que hace:** Encuentra la mayor suma de un subarreglo contiguo (puede haber negativos).

## **2.2. Solucion:**
- Se recorre el arreglo acumulando sumas.  
- Si la suma es negativa, se reinicia.  
- Se guarda la máxima suma encontrada.

## **2.3. Explicacion:** 
En este ejercicio se busca que el subarreglo haga una suma grande, incluso si hay numeros negativos.
Se uso el algoritmo de Kadane porque permite resolver problemas en tiempo lineal (osea que depende del tamanio del problema) recorre el arreglo una sola vez y compara sumas parciales en cada paso.


# **3. Eliminar Duplicados en un Arreglo Ordenado**

## **3.1. Enunciado:**

Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`.  
Ejemplo: `[1, 1, 2, 2, 3, 4, 4]` → `[1, 2, 3, 4]`.

- **Que hace:** Elimina duplicados in-place y deja solo valores únicos al inicio.

## **3.2. Solucion:**
- j (última posición única escrita).
- i (escanea).
- Si arr[i] != arr[j], avanza j y copia arr[i] en arr[j].
- Se recorre el arreglo con dos punteros.  
- Se sobreescriben los valores únicos en orden.

## **3.3. Explicacion:**
El objetivo es dejar un arreglo con solo los elementos únicos, eliminando los duplicados. Como el arreglo ya está ordenado, la comparación entre un elemento y el anterior permite identificar los repetidos fácilmente. Esta técnica aprovecha el orden para evitar estructuras adicionales como listas o conjuntos.


# **4. Encontrar el Número que Falta**

## **4.1. Enunciado:**
En un arreglo de números del 1 al n, falta un número. Encuentra cuál es.
Ejemplo: [1, 2, 4, 5, 6] → Falta 3.

- **Qué hace:**
Calcula cuál número no está presente en un arreglo con elementos del 1 al n.

## **4.2. Solución:**

- Se calcula la suma esperada de todos los números de 1 a n: sumaEsperada = n*(n+1)/2.
- Se suma todos los números que realmente están en el arreglo.
- La diferencia entre la suma esperada y la suma real es el número faltante.

## **4.3. Explicación:**
Se usa una fórmula matemática sencilla para sumar los números del 1 al n. No requiere recorrer el arreglo varias veces ni usar estructuras adicionales.
Métodos usados: foreach para recorrer el arreglo y sumar sus elementos.

# **5. Intersección de Dos Arreglos** 

## **5.1. Enunciado:**
Dado dos arreglos de enteros, encuentra los elementos comunes sin usar LINQ.
Ejemplo: [1,2,2,1] y [2,2] → [2,2].

- **Qué hace:**
Devuelve un arreglo con los elementos que aparecen en ambos arreglos, respetando la cantidad de repeticiones.

## **5.2. Solución:**
- Se recorren ambos arreglos con bucles anidados.
- Cada vez que se encuentra un elemento común, se agrega al resultado y se marca la posición en el segundo arreglo para que no se use otra vez.

## **5.3. Explicación:** 
Este método compara cada elemento del primer arreglo con todos los del segundo.

- Se usa for para recorrer los arreglos.
- break detiene la búsqueda una vez que se encuentra coincidencia.
- Modificar temporalmente el segundo arreglo evita contar el mismo elemento más de una vez.

Este enfoque es sencillo y claro aunque no es el más eficiente para arreglos grandes, aparte del detalle que se debe poner numero tras numero con enter.

# **6.Matriz Transpuesta**
## **6.1. Enunciado:**
Dada una matriz (arreglo bidimensional), encuentra su transpuesta.
Ejemplo:

```text
  [1, 2, 3],                [1, 4],
  [4, 5, 6]         →       [2, 5],
                            [3, 6] 
```

- **Qué hace:** 
Convierte filas en columnas y columnas en filas.

## **6.2. Solución:** 
- Se crea una matriz nueva de tamaño columnas x filas.
- Se recorren las posiciones de la matriz original y se asigna: transpuesta[j, i] = original[i, j].

## **6.3. Explicación:**
- Los bucles for recorren filas y columnas.
- Cada valor se copia en su posición transpuesta.
- Se usa Console.Write y Console.WriteLine para mostrar la matriz.


# **7. Arreglo de Productos Excepto el Índice**
## **7.1. Enunciado:** 
Dado un arreglo de enteros, construye un nuevo arreglo donde cada posición contenga el producto de todos los elementos excepto el de esa posición (sin usar división).
Ejemplo: [1, 2, 3, 4] → [24, 12, 8, 6].

- **Qué hace:**
Para cada elemento, calcula el producto de todos los demás elementos.

## **7.2. Solución:**
- _Se crean dos arreglos auxiliares:_ izquierda y derecha.
	- izquierda[i] contiene el producto de todos los elementos a la izquierda de i.
	- derecha[i] contiene el producto de todos los elementos a la derecha de i.
- El resultado se obtiene multiplicando izquierda[i] * derecha[i].

## **7.3. Explicación:**

La idea es acumular productos parciales para no usar división y evitar recalcular productos varias veces.

- for recorre el arreglo para calcular acumulados y luego el resultado final.


# **8. Buscar Elemento en Arreglo Rotado**
## **8.1. Enunciado:**
Dado un arreglo rotado y ordenado, implementa búsqueda binaria modificada para encontrar un número dado.

Ejemplo: [4,5,6,7,0,1,2], buscar 0 → índice 4.

- **Qué hace:**
Encuentra el índice de un elemento en un arreglo rotado usando búsqueda binaria.

## **8.2. Solución:**
- Se usa búsqueda binaria tradicional modificando los límites según qué mitad del arreglo está ordenada.
- Si el target está dentro del rango ordenado, se busca allí; si no, se busca en la otra mitad.

## **8.3. Explicación:**
- while recorre mientras inicio <= fin.
- int mid = (inicio + fin)/2 calcula el punto medio.
- Comparaciones determinan en qué mitad continuar.
- Complejidad: O(log n).

# **9. Espiral en una Matriz**
## **9.1. Enunciado:**
Escribe un programa que recorra e imprima los elementos de una matriz en forma de espiral.
Ejemplo:
```text
  [1, 2, 3],
  [4, 5, 6],      →    [1, 2, 3, 6, 9, 8, 7, 4, 5].
  [7, 8, 9] 
```
- **Qué hace:**
Recorre la matriz desde el borde externo hacia adentro siguiendo un patrón espiral.

## **9.2. Solución:**
- Se usan 4 punteros: top, bottom, left, right.

- Se recorre:

	- Fila superior → derecha
	- Columna derecha → abajo
	- Fila inferior → izquierda
	- Columna izquierda → arriba
  
Se repite hasta cubrir toda la matriz.

## **9.3. Explicación:**

- while (top <= bottom && left <= right) controla el recorrido.
- for recorre filas y columnas según punteros.


# **10.  Suma de Subconjuntos (Backtracking)**

## **10.1. Enunciado:**
Dado un arreglo de enteros y un número target, encuentra todos los subconjuntos cuya suma sea igual al target.
Ejemplo: [2, 3, 6, 7], target=7 → [7], [2, 2, 3].

- **Qué hace:**
Explora todas las combinaciones de elementos para encontrar subconjuntos que sumen el target.

## **10.2. Solución:**

- Función recursiva Backtrack que:

	- Toma el elemento actual y resta su valor del target.
	- Llama recursivamente manteniendo el mismo índice (para permitir repetición).
	- Si target == 0, imprime el subconjunto.
	- Si target < 0 o se acaban elementos, retorna.

## **10.3. Explicación:**

- La recursividad permite explorar todas las combinaciones posibles.
- Se usan List<int> para almacenar temporalmente el subconjunto actual.
