# Ejercicio: Eliminar Duplicados en un Arreglo Ordenado

## Descripción
Este programa elimina los elementos duplicados de un **arreglo ordenado** en C# sin utilizar colecciones como `List` o `HashSet`.  
Ejemplo:

Entrada: [1, 1, 2, 2, 3, 4, 4]
Salida: [1, 2, 3, 4]


## Cómo funciona
- Se usa un índice `uniqueIndex` para mantener la posición del último número único.
- Se recorre el arreglo desde la segunda posición.
- Cada vez que se encuentra un número diferente al último único, se mueve adelante.
- Al final, `uniqueIndex + 1` indica la cantidad de elementos únicos.

## Uso
1. Clonar o descargar el repositorio.
2. Abrir el proyecto en Visual Studio o usar `dotnet run` desde la terminal.
3. Observar el arreglo original y el arreglo resultante sin duplicados.

## Comando para ejecutar
```bash
dotnet run


Autor

Denisse Yesenia Soliz Paredes - Estudiante de Ingeniería en Sistemas

