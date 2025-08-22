# 🌀 Recorrido en Espiral de Matriz

## Descripción
Programa en C# que recorre matrices bidimensionales en forma de espiral clockwise.

## 🧠 Algoritmo
**Estrategia de cuatro direcciones** con límites variables:
```csharp
while (filaInicio <= filaFin && columnaInicio <= columnaFin)
{
    // → Derecha (fila superior)
    // ↓ Abajo (columna derecha)
    // ← Izquierda (fila inferior) 
    // ↑ Arriba (columna izquierda)
}
```
## Compilar y ejecutar
```
dotnet run
```
 ## 📊 Ejemplos
```
 Entrada:
[ 1,  2,  3,  4]
[ 5,  6,  7,  8]
[ 9, 10, 11, 12]

Salida: 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7
```