# Ejercicio 1: Recorrer una Matriz en Espiral

Este programa recorre una matriz de cualquier tamaño en **forma de espiral**, empezando desde la esquina superior izquierda y girando en sentido del reloj (horario).

## Cómo funciona

1. Se definen cuatro limites: "top", "bottom", "left" y "right" que representan los bordes de la matriz.
2. Se recorre la **fila superior** de izquierda a derecha.
3. Luego se recorre la **columna derecha** de arriba hacia abajo.
4. Si aún quedan filas o columnas, se recorre la **fila inferior** de derecha a izquierda y la **columna izquierda** de abajo hacia arriba.
5. Se ajustan los límites y se repite el proceso hasta recorrer toda la matriz.
6. Cada elemento recorrido se guarda en una lista que luego se imprime en la consola.

## Función principal 
`Matriz En Espiral`

## Estilo de nombres

Se utilizó **PascalCase** para las funciones y variables principales.

## Para ejecutar en VS Code

1. Abre la terminal integrada de VS Code.
2. Crea un proyecto de consola (si no tienes uno):

    `dotnet new console` 

3. Avanzar en el código en Program.cs.

4. Ejecuta el programa:
`dotnet run`