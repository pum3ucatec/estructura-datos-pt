# 🔢 Juego de Adivinanza en C#

## 🎯 Descripción breve

Este proyecto es un juego interactivo en consola donde el sistema genera un número aleatorio entre 1 y 50, y el usuario debe adivinarlo. El programa guía al jugador indicando si su intento es demasiado alto o demasiado bajo, hasta que acierte.  
Es ideal para principiantes en programación que desean practicar estructuras de control, bucles y manejo de entrada de usuario.

## 📌 Objetivos y funcionalidades

- Generar un número aleatorio entre 1 y 50.
- Solicitar al usuario que adivine el número.
- Indicar si el intento es mayor o menor que el número secreto.
- Repetir el proceso hasta que el usuario acierte.
- Validar que la entrada sea un número entero.

### Funcionalidad educativa

- Aprender a usar `Random` para generar números aleatorios.
- Aplicar el bucle `do-while` para repetir acciones hasta cumplir una condición.
- Practicar estructuras condicionales (`if`, `else if`, `else`).
- Validar entradas con `int.TryParse`.

## 🧪 Cómo ejecutar el proyecto

### Requisitos

- Lenguaje: C#
- Versión recomendada: .NET 6.0 o superior
- Editor sugerido: Visual Studio, Visual Studio Code, o cualquier IDE compatible con C#

### Instrucciones

1. **Clona el repositorio** (ver sección de Git abajo).
2. **Abre el archivo en tu editor de C# favorito.**
3. **Compila y ejecuta el programa:**

   Si usas la terminal con .NET CLI:
   ```bash
   dotnet new console -n JuegoAdivinanza
   cd JuegoAdivinanza
   # Copia el código en Program.cs
   dotnet run
