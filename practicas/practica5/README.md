# Ejercicios Avanzados con Arreglos en C#

Este repositorio contiene 10 ejercicios avanzados en C# sobre arreglos y matrices.  
Hechos en Visual Studio Code usando .NET (C#).

**1. Requisitos**
- Tener instalado .NET SDK 
- Editor recomendado: Visual Studio Code

Para ejecutar un ejercicio (En la carpeta respectiva ejerN):

```bash
dotnet run
```


## 1. Rotación de Arreglo

**1.1. Enunciado:**

Escribe un programa que reciba un arreglo de enteros y un número `k`, y rote los elementos del arreglo hacia la derecha `k` posiciones.  
Ejemplo: `[1, 2, 3, 4, 5]` con `k=2` → `[4, 5, 1, 2, 3]`.

- **Que hace:** Rota el arreglo hacia la derecha k posiciones.

**1.2. Solucion:**  
- Se utiliza el operador modulo `%` para calcular la nueva posicion de cada elemento.  
- Cada elemento arr[i] se mueve a la posición (i + k) % n.
- Se copia en un nuevo arreglo ya rotado.

**1.3. Explicacion:** En este ejercicio se rota los elementos de un arreglo hacia la derecha con una cantidad determinada de veces pedida desde consola. Opte por usar el modulo de % para evitar que k sobrepase de numero de elementos que tiene el arrelgo.


## 2. Subarreglo con Suma Máxima (Kadane’s Algorithm)

**2.1. Enunciado:**
Dado un arreglo de enteros (puede contener positivos y negativos), encuentra el subarreglo contiguo con la suma más grande.  
Ejemplo: `[−2, 1, −3, 4, −1, 2, 1, −5, 4]` → el subarreglo `[4, −1, 2, 1]` tiene suma máxima `6`.

- **Que hace:** Encuentra la mayor suma de un subarreglo contiguo (puede haber negativos).

**2.2. Solucion:**
- Se recorre el arreglo acumulando sumas.  
- Si la suma es negativa, se reinicia.  
- Se guarda la máxima suma encontrada.

**2.3. Explicacion:** En este ejercicio se busca que el subarreglo haga una suma grande, incluso si hay numeros negativos.
Se uso el algoritmo de Kadane porque permite resolver problemas en tiempo lineal (osea que depende del tamanio del problema) recorre el arreglo una sola vez y compara sumas parciales en cada paso.


## 3. Eliminar Duplicados en un Arreglo Ordenado

**3.1. Enunciado:**

Escribe un programa que elimine los elementos duplicados de un arreglo **ordenado**, sin usar colecciones como `List` o `HashSet`.  
Ejemplo: `[1, 1, 2, 2, 3, 4, 4]` → `[1, 2, 3, 4]`.

- **Que hace:** Elimina duplicados in-place y deja solo valores únicos al inicio.

**3.2. Solucion:**
- j (última posición única escrita).
- i (escanea).
- Si arr[i] != arr[j], avanza j y copia arr[i] en arr[j].
- Se recorre el arreglo con dos punteros.  
- Se sobreescriben los valores únicos en orden.

**3.3. Explicacion:**

El objetivo es dejar un arreglo con solo los elementos únicos, eliminando los duplicados. Como el arreglo ya está ordenado, la comparación entre un elemento y el anterior permite identificar los repetidos fácilmente. Esta técnica aprovecha el orden para evitar estructuras adicionales como listas o conjuntos.
