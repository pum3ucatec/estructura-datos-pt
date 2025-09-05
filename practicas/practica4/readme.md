# 📋 Descripción General
Este programa implementa una pila (estructura LIFO - Last In, First Out) en C# con una interfaz de menú interactiva que permite realizar diversas operaciones sobre la estructura de datos.

## 🏗️ Estructura del Código
### Clase Pila
Implementa la estructura de datos pila utilizando una List<int> para almacenar los elementos.

1. Métodos Principales:
- Push(int valor): Inserta un elemento en la cima de la pila

- Pop(): Elimina y retorna el elemento de la cima de la pila

- Peek(): Consulta el elemento en la cima sin eliminarlo

- IsEmpty(): Verifica si la pila está vacía

- Mostrar(): Muestra el contenido de la pila de forma visual

- Clear(): Limpia todos los elementos de la pila

2. Clase Principal
- Contiene el método Main con el menú interactivo que permite al usuario:

- Gestionar la pila mediante opciones numeradas

- Insertar elementos individuales o múltiples

3. Visualizar el estado de la pila

- Realizar operaciones estándar de pilas

## 🎯 Funcionalidades Implementadas
Operaciones Disponibles:

Mostrar pila - Visualización gráfica del contenido

Insertar (Push) - Añade un elemento a la cima

Insertar N elementos - Añade múltiples elementos consecutivos

Eliminar (Pop) - Remueve el elemento de la cima

Ver cima (Peek) - Consulta el elemento superior sin removerlo

Verificar si está vacía - Comprueba el estado de la pila

Limpiar pila - Elimina todos los elementos

Salir - Finaliza el programa

## 📊 Ejemplo de Uso

```===== MENÚ PILA =====
1. Mostrar pila
2. Insertar (Push)
3. Insertar N elementos (Push N)
4. Eliminar (Pop)
5. Ver cima (Peek)
6. Verificar si está vacía
7. Limpiar pila (Clear)
0. Salir
Seleccione una opción: 2
Ingrese el número a insertar: 42
Elemento 42 insertado correctamente.
Visualización de la pila:
text
Contenido de la pila (de arriba a abajo):
│ 42 │
└───┘
```

## 🎨 Representación Visual
```
El método Mostrar() presenta la pila de manera gráfica:

│ 30 │
├───┤
│ 20 │
├───┤
│ 10 │
└───┘
```