# 📝 Descripción
Encuentra los elementos comunes entre dos arreglos, incluyendo duplicados. Primero ordena ambos arreglos y luego usa dos punteros para recorrerlos simultáneamente, avanzando el puntero del arreglo con el valor menor en cada comparación.

## 🔧 Características
Maneja duplicados correctamente

Ordena los arreglos para eficiencia

Retorna un nuevo arreglo con la intersección

## 🚀 Uso
```
csharp
int[] arr1 = {1, 2, 2, 1};
int[] arr2 = {2, 2};
int[] resultado = Interseccion(arr1, arr2);
// Resultado: [2, 2]
```
## 📊 Ejemplo
```
text
Arreglo 1 ordenado: [1, 1, 2, 2]
Arreglo 2 ordenado: [2, 2]

Comparaciones:
1 < 2 → avanzar arr1
1 < 2 → avanzar arr1  
2 == 2 → agregar 2, avanzar ambos
2 == 2 → agregar 2, avanzar ambos

Output: [2, 2]
```