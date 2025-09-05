# 📝 Descripción
Recorre una matriz en forma de espiral, comenzando desde la esquina superior izquierda y moviéndose en el sentido de las agujas del reloj. Usa cuatro variables para trackear los límites actuales y se mueve en cuatro direcciones: derecha, abajo, izquierda, arriba.

## 🔧 Características
Maneja matrices rectangulares

Recorrido completo sin saltarse elementos

Algoritmo claro con boundaries bien definidos

## 🚀 Uso
```
int[,] matriz = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
int[] resultado = RecorridoEspiral(matriz);
// Resultado: [1, 2, 3, 6, 9, 8, 7, 4, 5]
```
## 📊 Ejemplo
```
Input:
[1, 2, 3]
[4, 5, 6] 
[7, 8, 9]

Recorrido:
→ Derecha: 1,2,3
↓ Abajo: 6,9  
← Izquierda: 8,7
↑ Arriba: 4
→ Derecha: 5

Output: [1,2,3,6,9,8,7,4,5]
```