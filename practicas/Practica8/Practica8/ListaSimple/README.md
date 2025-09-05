# 📋 Lista Enlazada de Nombres en C#

Este proyecto es una aplicación de consola en C# que implementa una **lista enlazada simple** para almacenar nombres. Permite al usuario agregar nombres al inicio de la lista y visualizar todos los nombres ingresados.

---

## 🚀 Características

- Agrega nombres al inicio de la lista.
- Muestra todos los nombres en orden de ingreso (último primero).
- Interfaz sencilla por consola.
- Estructura de datos tipo lista enlazada.

---

## 🧠 Estructura del Código

### Clase `Nodo`
Representa cada elemento de la lista:
- `nombre`: almacena el nombre.
- `siguiente`: referencia al siguiente nodo.

### Funciones principales

| Función         | Descripción                                                                 |
|----------------|------------------------------------------------------------------------------|
| `AgregarNombre()` | Solicita un nombre al usuario y lo agrega al inicio de la lista.           |
| `VerNombres()`    | Recorre la lista y muestra todos los nombres almacenados.                  |
| `Main()`          | Muestra el menú interactivo y gestiona las opciones del usuario.           |

---

## 📦 Cómo ejecutar

1. Abre el proyecto en tu entorno de desarrollo C# (por ejemplo, Visual Studio).
2. Compila y ejecuta el programa.
3. Usa el menú para agregar y visualizar nombres.

---

## 🧪 Ejemplo de uso

```plaintext
LISTA DE NOMBRES
1. Agregar nombre al inicio
2. Ver todos los nombres
3. Salir
Elige una opción: 1
Ingresa un nombre: Kire
Nombre agregado al inicio

Elige una opción: 2
Nombres en la lista:
1. Kire
