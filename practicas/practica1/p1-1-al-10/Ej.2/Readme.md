# Ejercicio 2: Suma del 1 al N

## Descripción Completa
Programa que calcula la suma acumulativa de todos los números enteros desde 1 hasta un número N ingresado por el usuario. Implementa la fórmula matemática de manera iterativa.

## Análisis Técnico

### Algoritmo Implementado
- **Entrada**: Número entero positivo N
- **Proceso**: Suma iterativa 1 + 2 + 3 + ... + N
- **Salida**: Resultado de la suma acumulativa

### Complejidad Computacional
- **Tiempo**: O(N) - Lineal, depende del valor de N
- **Espacio**: O(1) - Memoria constante, solo variables simples

### Validación de Entrada
- **Parseo Directo**: `int.Parse()` - Convierte string a int
- **Riesgo**: Puede lanzar excepción con entradas no numéricas
- **Alternativas Seguras**: `int.TryParse()` para mejor manejo de errores

### Optimización Matemática
El algoritmo iterativo es didáctico pero ineficiente para N grandes. Existe una fórmula matemática óptima: