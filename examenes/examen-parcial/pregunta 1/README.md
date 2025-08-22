# Recorrido de Matriz en Espiral (C#)

Este proyecto en C# contiene una solución para recorrer e imprimir los elementos de una matriz en forma de espiral.

## Funcionalidad

El método estático `Traverse` de la clase `SpiralMatrix` toma una matriz bidimensional de enteros (`int[,]`) y devuelve una `List<int>` con los elementos en orden de espiral.

### Ejemplo

- **Entrada:** `[ [1, 2, 3], [4, 5, 6], [7, 8, 9] ]`
- **Salida:** `[1, 2, 3, 6, 9, 8, 7, 4, 5]`

## Estilo de Código

El código sigue las convenciones de estilo de C# y .NET:

-   Se usa **PascalCase** para los nombres de clases (`SpiralMatrix`) y métodos públicos (`Traverse`).
-   Las variables locales se nombran usando **camelCase**.

## Requisitos y Ejecución

Para compilar y ejecutar este programa, necesitas tener instalado el **.NET SDK**.

1.  Guarda el código en un archivo llamado `SpiralMatrix.cs`.
2.  Abre tu terminal o línea de comandos.
3.  Usa el siguiente comando para compilar y ejecutar el archivo directamente:
    ```bash
    dotnet run SpiralMatrix.cs
    ```

Este comando creará y ejecutará el proyecto en memoria. Si prefieres crear un proyecto formal, puedes usar `dotnet new console` y luego agregar el código.

---