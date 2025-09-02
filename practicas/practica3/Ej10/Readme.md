# Matriz 3x3 con Suma de Filas y Columnas

## Descripción
Trabaja con una matriz bidimensional 3x3, mostrando la matriz y calculando las sumas de filas y columnas.

## Funcionalidad
- **Matriz predefinida**: Valores `{{2,4,6}, {1,3,5}, {7,8,9}}`
- **Visualización**: Muestra la matriz en formato grid 3x3
- **Cálculo de sumas**:
  - **Filas**: Suma horizontal de cada fila
  - **Columnas**: Suma vertical de cada columna
- **Resultados**: Muestra sumas con identificación clara

## Estructura de Datos
- **Tipo**: `int[,]` - arreglo bidimensional
- **Dimensiones**: 3 filas × 3 columnas
- **Acceso**: `matriz[i,j]` donde i=filas, j=columnas

## Características
- **Doble iteración**: Ciclos anidados para recorrer filas y columnas
- **Cálculos separados**: Suma de filas y columnas en procesos distintos
- **Presentación tabular**: Muestra la matriz como tabla visual
- **Resultados organizados**: Agrupa sumas por filas y por columnas