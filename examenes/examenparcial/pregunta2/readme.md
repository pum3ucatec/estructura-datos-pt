# 🌀 Recorrido en Espiral de Matriz

## Descripción
Programa en C# que recorre matrices bidimensionales en forma de espiral, en sentido horario(clockwise).

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
 ### MATRIZ 3x4:
```
 Entrada:
[ 1,  2,  3,  4]
[ 5,  6,  7,  8]
[ 9, 10, 11, 12]

Salida: 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7
```
### Matriz 4x3:
```
Entrada:
[ 10,  20,  30]
[ 40,  50,  60]
[ 70,  80,  90]
[100, 110, 120]

Salida: 10, 20, 30, 60, 90, 120, 110, 100, 70, 40, 50, 80
```
## 📝 Convenciones
- PascalCase para métodos.

- camelCase para variables.

## 🧪 Compatibilidad
- .NET Framework y .NET Core.

- Matrices de diferentes dimensiones.

- Manejo de matrices vacías.