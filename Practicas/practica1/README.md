# 📘 Ejercicios Básicos en C# - Consola

Este repositorio contiene una colección de programas simples en **C#** diseñados para practicar estructuras de control, ciclos, condicionales y manejo de entrada/salida por consola.

---

## ✅ Índice de Programas

| Código | Descripción |
|--------|-------------|
| `p1`   | Imprimir números del 1 al 10 |
| `p2`   | Sumar números del 1 al N (versión con `while`) |
| `p3`   | Idéntico a `p2`, suma del 1 al N |
| `p4`   | Menú interactivo con opciones (saludo, suma, salir) |
| `p5`   | Cuenta regresiva del 10 al 1 |
| `p6`   | Validación de número positivo (uso de `do-while`) |
| `p7`   | Suma de 5 números ingresados por el usuario |
| `p8`   | Verificar si un número es primo |
| `p9`   | Mostrar los primeros 10 números pares |
| `p10`  | Juego: adivinar un número secreto entre 1 y 50 |

---

## 🧾 Detalle de cada programa

### 🔹 `p1`: Imprimir del 1 al 10
Utiliza un bucle `for` para imprimir los números del 1 al 10.

---

### 🔹 `p2` / `p3`: Suma del 1 al N
Solicita al usuario un número `N` e imprime la suma de todos los números del 1 al N usando un ciclo `while`.

---

### 🔹 `p4`: Menú interactivo
Despliega un menú con las siguientes opciones:

- `1`: Saluda al usuario
- `2`: Suma dos números ingresados
- `3`: Sale del programa

Utiliza `do-while` y `switch`.

---

### 🔹 `p5`: Cuenta regresiva
Imprime una cuenta regresiva del 10 al 1 utilizando un bucle `while` decreciente.

---

### 🔹 `p6`: Validación de número positivo
Solicita repetidamente un número hasta que el usuario ingrese uno **positivo**. Usa un ciclo `do-while`.

---

### 🔹 `p7`: Suma de 5 números
Pide al usuario ingresar 5 números uno por uno y muestra la suma total.

---

### 🔹 `p8`: Verificación de número primo
Pide al usuario un número e indica si es **primo** o no, usando una verificación hasta la raíz cuadrada del número.

---

### 🔹 `p9`: Primeros 10 pares
Imprime los primeros 10 números pares (empezando desde 2) usando un ciclo `while`.

---

### 🔹 `p10`: Adivina el número secreto
Genera un número aleatorio entre 1 y 50. El usuario debe adivinarlo con pistas de "mayor" o "menor" hasta acertar.

---

## 🚀 Cómo ejecutar

1. Abre una terminal en Visual Studio Code. especificamente Bash.
2. Crea un nuevo proyecto de consola (`dotnet new console` si usas .NET Core).
3. Copia el contenido del archivo que deseas ejecutar.
4. Compila y ejecuta (`dotnet run` o F5 en el IDE).

---

## 🧠 Temas aplicados

- Estructuras de control (`if`, `switch`, `for`, `while`, `do-while`)
- Entrada y salida por consola
- Conversión de tipos (`int.Parse`)
- Generación de números aleatorios
- Validaciones básicas
- Lógica de programación

