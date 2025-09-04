# Explicación: Inversión de Cadenas

## Enfoque Iterativo
El método iterativo utiliza:
1. **Conversión del string a un arreglo de caracteres** → `ToCharArray()`  
2. **Un algoritmo preconstruido de inversión** → `Array.Reverse()` que internamente usa un **bucle** para intercambiar posiciones (primero ↔ último, segundo ↔ penúltimo, etc.)  
3. **Reconstrucción del string** a partir del arreglo invertido  

---

## Enfoque Recursivo
En recursión, no se usa un bucle explícito, sino que divides el problema en **subproblemas más pequeños**.

- **Definición del caso base**: cuando el índice es menor a 0 → significa que ya no quedan caracteres, entonces se devuelve una cadena vacía.  
- **Definición del caso recursivo**: tomar el carácter actual (`cadena[indice]`) y concatenarlo con el resultado de la función aplicada al resto de la cadena (`indice - 1`).

Formalmente:

```
Invertir(cadena, n) = cadena[n] + Invertir(cadena, n-1)
```
con la condición de que:

```
Invertir(cadena, -1) = ""
```

---

## Diferencia Conceptual
- **Iterativo**: usa un **control de flujo explícito** (un bucle o un algoritmo listo como `Reverse`) para recorrer y manipular los elementos.  
- **Recursivo**: usa **autorreferencia** de la función (llamarse a sí misma) para recorrer indirectamente, hasta llegar a un **estado base** que detiene la recursión.

---

## Justificación de la Transformación
Transformar un algoritmo iterativo en uno recursivo se hace para:  
1. **Demostrar equivalencia de enfoques**: un mismo problema puede resolverse con iteración o recursión.  
2. **Expresar el problema en términos matemáticos**: la inversión de una cadena puede definirse como:  
   > “El último carácter más la inversión del resto de la cadena”.  
3. **Practicar la abstracción**: en lugar de manipular índices con bucles, se abstrae el proceso en una definición más declarativa.

---

##  En resumen:
- **Iterativo** = control del flujo mediante bucles.  
- **Recursivo** = control del flujo mediante la pila de llamadas (*stack*).  
- La transformación ocurre porque **invertir una cadena se puede definir inductivamente**:

- **Base**: string vacío → string vacío  
- **Paso recursivo**: `invertir(cadena) = último carácter + invertir(resto)`
