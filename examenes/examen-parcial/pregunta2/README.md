# Encontrar el Número Faltante (C#)

Este proyecto en C# contiene una solución para encontrar el único número faltante en un arreglo de enteros que debería contener todos los números del 1 al `n`.

## Funcionalidad

El método estático `FindMissingNumber` de la clase `MissingNumberFinder` determina el número faltante en un arreglo dado. La solución se basa en una propiedad matemática simple: la **suma de los primeros `n` números naturales**. Al comparar la suma esperada con la suma real de los elementos del arreglo, la diferencia revela el número que falta.

### Ejemplo

-   **Entrada:** `[1, 2, 4, 5, 6]`
-   **Salida:** `3`

## Estilo de Código

El código sigue las convenciones de estilo de C# y .NET:

-   Se usa **PascalCase** para los nombres de clases (`MissingNumberFinder`) y métodos públicos (`FindMissingNumber`).
-   Las variables locales se nombran usando **camelCase**.

## Requisitos y Ejecución

Para compilar y ejecutar este programa, necesitas tener instalado el **.NET SDK**.

1.  Guarda el código en un archivo llamado `MissingNumberFinder.cs`.
2.  Abre tu terminal o línea de comandos.
3.  Usa el siguiente comando para compilar y ejecutar el archivo directamente:
    ```bash
    dotnet run MissingNumberFinder.cs
    ```
Este comando creará y ejecutará el proyecto en memoria. Si prefieres crear un proyecto formal, puedes usar `dotnet new console` y luego agregar el código.

---