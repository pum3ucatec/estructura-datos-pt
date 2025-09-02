# 📝 Descripción
Elimina elementos duplicados de un arreglo ordenado manteniendo el orden original y trabajando in-place. Utiliza la técnica de dos punteros: un puntero para recorrer el arreglo y otro para marcar la posición donde colocar el siguiente elemento único.

## 🔧 Características
Modifica el arreglo original sin usar espacio adicional

Preserva el orden de los elementos

Retorna la nueva longitud válida del arreglo

## 🚀 Uso
```
csharp
int[] arr = {1, 1, 2, 2, 3, 4, 4};
int nuevaLongitud = EliminarDuplicados(arr);
// Arreglo modificado: [1, 2, 3, 4, ...]
```
## 📊 Ejemplo
```
text
Input: [1, 1, 2, 2, 3, 4, 4]
Proceso: 
  Puntero único en índice 0: [1, 1, 2, 2, 3, 4, 4]
  Encuentra 2 ≠ 1 → mueve a índice 1: [1, 2, 2, 2, 3, 4, 4]  
  Encuentra 3 ≠ 2 → mueve a índice 2: [1, 2, 3, 2, 3, 4, 4]
  Encuentra 4 ≠ 3 → mueve a índice 3: [1, 2, 3, 4, 3, 4, 4]
Output: [1, 2, 3, 4] (primeros 4 elementos)
```