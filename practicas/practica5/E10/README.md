# Subconjuntos con suma objetivo en C#

Este programa encuentra **todos los subconjuntos posibles** de un arreglo de enteros cuya suma sea igual a un valor objetivo (`target`).

## Ejemplo de uso

Entrada:

```csharp
int[] numeros = { 2, 3, 6, 7 };
int target = 7;

Salida esperada
Subconjuntos cuya suma es 7:
[2, 2, 3]
[7]

Funcionamiento

Se utiliza backtracking para explorar todas las combinaciones:

Incluir el número actual (se resta a la suma objetivo).

Excluir el número actual (se avanza al siguiente índice).

Si la suma acumulada llega a 0, se imprime el subconjunto como solución.

Si la suma excede el objetivo o no quedan más elementos, se descarta esa rama.