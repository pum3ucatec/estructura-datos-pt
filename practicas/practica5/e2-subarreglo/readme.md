# 📝 Descripción
Implementa el famoso algoritmo de Kadane para encontrar el subarreglo contiguo con la mayor suma. El algoritmo recorre el arreglo una sola vez, manteniendo un registro de la suma máxima actual y la suma máxima global. También trackea los índices del subarreglo resultante.

## 🔧 Características
Encuentra el subarreglo exacto, no solo la suma

Funciona con números positivos y negativos

Retorna tanto el subarreglo como la suma máxima

## 🚀 Uso
```
csharp
int[] arr = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
var resultado = SubarregloSumaMaxima(arr);
// Subarreglo: [4, -1, 2, 1], Suma: 6
```
## 📊 Ejemplo
```
text
Input: [-2, 1, -3, 4, -1, 2, 1, -5, 4]
Proceso: El algoritmo identifica que [4, -1, 2, 1] es la secuencia óptima
Output: Subarreglo: [4, -1, 2, 1], Suma máxima: 6
```