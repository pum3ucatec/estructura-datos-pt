# Ordenamiento Burbuja

## Descripción
Implementa el algoritmo de ordenamiento Burbuja para ordenar un arreglo de menor a mayor.

## Funcionalidad
- **Arreglo desordenado**: `{5, 3, 8, 4, 2, 7, 1, 6}`
- **Algoritmo Burbuja**:
  - Dos ciclos anidados
  - Compara elementos adyacentes
  - Intercambia si están en orden incorrecto
  - Reduce el rango de comparación en cada iteración externa
- **Visualización**: Muestra el arreglo antes y después

## Características del Algoritmo
- **Tipo**: Comparación e intercambio
- **Complejidad**: O(n²) en el peor caso
- **Estable**: Mantiene el orden relativo de elementos iguales
- **In-place**: No requiere memoria adicional significativa

## Métodos Auxiliares
- `MostrarArreglo(int[] arr)`: Función helper para mostrar arreglos