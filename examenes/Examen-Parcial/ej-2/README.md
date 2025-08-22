# Ejercicio 2: Encontrar el Número que Falta

Este programa identifica un número que falta en un arreglo que contiene números consecutivos del 1 al n. Es un problema clásico que se puede resolver de manera rápida usando matemáticas en lugar de buscar elemento por elemento.

## Cómo funciona

1. Se calcula la **suma que deberían tener todos los números** del 1 al n usando la fórmula: ***n * (n + 1) / 2;***

2. Se suma todos los números que realmente están en el arreglo (`sumaActual`).
3. Se resta la suma real de la suma esperada:

`numeroFaltante = sumaEsperada - sumaActual`

4. El resultado es el número que falta.

## Función principal

`Numero Faltante`

## Estilo de nombres

Se utilizó **PascalCase** para las funciones y variables principales, siguiendo buenas prácticas de C#.

## Para hacerlo correr en VsCode

1. Abre la terminal integrada de VS Code.
2. Crea un proyecto de consola si no tienes uno:

`dotnet new console`


3. Programar el código en Program.cs.

4. Ejecutar el programa con `dotnet run`

***Se debe ver algo como***
Número faltante: 3
