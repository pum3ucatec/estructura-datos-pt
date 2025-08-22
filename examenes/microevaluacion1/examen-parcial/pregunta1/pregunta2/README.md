# Recorrer Matriz en Forma de Espiral

## Descripción
Este programa en C# recorre una matriz bidimensional y devuelve los elementos en orden de espiral, comenzando desde la esquina superior izquierda y siguiendo en sentido horario.

### Ejemplo
Para la matriz:
[
[ 1, 2, 3, 4, 5],
[ 6, 7, 8, 9, 10],
[11, 12, 13, 14, 15],
[16, 17, 18, 19, 20]
]

La salida será:  
`[1, 2, 3, 4, 5, 10, 15, 20, 19, 18, 17, 16, 11, 6, 7, 8, 9, 14, 13, 12]`

## Estructura y Convenciones
- Se utilizó **PascalCase** para nombrar clases y métodos, siguiendo las convenciones estándar de C#.
- El método principal que realiza el recorrido espiral es `SpiralOrder`, que recibe una matriz 2D y devuelve una lista con los elementos en orden espiral.
- La función `Main` crea una matriz de ejemplo, llama a `SpiralOrder` y muestra el resultado en consola.

## Cómo correr el programa

1. Asegúrate de tener instalado el SDK de .NET (versión 5.0 o superior recomendado).
2. Guarda el código en un archivo llamado `Program.cs`.
3. Abre una terminal o PowerShell y navega al directorio donde está el archivo.
4. Ejecuta los siguientes comandos para compilar y correr el programa:

```bash
# Compilar
csc Program.cs

# Ejecutar
./Program.exe

dotnet new console -n SpiralMatrixApp
cd SpiralMatrixApp
# Copia el contenido de Program.cs en el archivo Program.cs generado
dotnet run
