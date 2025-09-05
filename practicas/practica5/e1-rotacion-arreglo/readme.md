# 📝 Descripción
Este programa implementa una rotación eficiente de un arreglo hacia la derecha. Utiliza un algoritmo inteligente que hace tres reversiones: primero revierte todo el arreglo, luego revierte los primeros k elementos y finalmente revierte los elementos restantes. Este enfoque evita el uso de espacio adicional y es muy eficiente.

## 🔧 Características
Rotación in-place (sin crear un nuevo arreglo)

Maneja rotaciones mayores que el tamaño del arreglo

Algoritmo óptimo que evita desplazamientos múltiples

## 🚀 Uso
```
csharp

int[] arr = {1, 2, 3, 4, 5};

RotarDerecha(arr, 2);

// Resultado: [4, 5, 1, 2, 3]
```
## 📊 Ejemplo
```
text
Input: [A, B, C, D, E], k=2

Paso 1: Reverso completo → [E, D, C, B, A]

Paso 2: Reverso primeros 2 → [D, E, C, B, A]  

Paso 3: Reverso resto → [D, E, A, B, C]
Output: [D, E, A, B, C]
```