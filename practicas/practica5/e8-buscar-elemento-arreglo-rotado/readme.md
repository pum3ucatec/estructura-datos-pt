# 📝 Descripción
Implementa una búsqueda binaria modificada para encontrar elementos en un arreglo que fue rotado pero mantiene el orden interno. Determina qué mitad está ordenada y decide en qué mitad continuar la búsqueda.

## 🔧 Características
Búsqueda eficiente tipo binary search

Maneja arreglos rotados cualquier número de veces

Encuentra la posición exacta del elemento

## 🚀 Uso
```
int[] arr = {4, 5, 6, 7, 0, 1, 2};
int posicion = BuscarEnRotado(arr, 0);
// Resultado: 4
```
## 📊 Ejemplo
```
Input: [4, 5, 6, 7, 0, 1, 2], target=0

Proceso:
  Medio = 7 (índice 3)
  Mitad izquierda [4,5,6,7] está ordenada
  0 no está en [4,7] → buscar en mitad derecha [0,1,2]
  Encuentra 0 en índice 4

Output: 4
```