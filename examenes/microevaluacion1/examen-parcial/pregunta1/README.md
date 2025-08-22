# Encontrar Número que Falta

## Descripción
Este programa en C# encuentra el número que falta en un arreglo que contiene números del 1 al 22, con un solo número faltante.

### Ejemplo
Entrada: `[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22]`  
Salida: `11` (porque falta el número 11)

## Estructura y Convenciones
- Se usó **PascalCase** para nombrar métodos y clases, que es la convención estándar en C#.
- El método principal para encontrar el número faltante se llama `FindMissingNumber`.
- La función `Main` ejecuta el programa y muestra el resultado en consola.

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
