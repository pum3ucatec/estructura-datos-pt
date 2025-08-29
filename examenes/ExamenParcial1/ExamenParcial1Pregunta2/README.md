# Ejercicio: Matriz Transpuesta

## Descripción
Este programa en C# encuentra la **transpuesta** de una matriz (arreglo bidimensional).  
La transpuesta de una matriz se obtiene intercambiando sus filas por columnas.  

### Ejemplo:
Matriz original:
[ [1, 2, 3],
[4, 5, 6] ]

Matriz transpuesta:
[ [1, 4],
[2, 5],
[3, 6] ]


## Cómo funciona
- Se obtiene el número de filas y columnas de la matriz original usando `GetLength`.
- Se crea una nueva matriz `transpuesta` con dimensiones invertidas.
- Cada elemento `matriz[i, j]` se asigna a `transpuesta[j, i]`.
- Se imprime la matriz original y la transpuesta de manera ordenada.

## Uso
1. Clonar o descargar el repositorio.
2. Abrir el proyecto en Visual Studio o usar `dotnet run` desde la terminal.
3. Ver el resultado de la matriz original y la transpuesta en consola.

## Comando para ejecutar
```bash
dotnet run
Autor

Denisse Yesenia Soliz Paredes - Estudiante de Ingeniería en Sistemas