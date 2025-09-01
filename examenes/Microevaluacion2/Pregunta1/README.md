# 📌 Lista Simple de Nombres en C#

Este proyecto contiene dos versiones de un programa en **C#** que maneja una **lista simplemente enlazada** para guardar nombres.

- La **versión básica** permite agregar y mostrar nombres.  
- La **versión extendida** también permite eliminar el nombre **antes** y **después** de uno elegido.

---

##  Objetivo del programa

El objetivo es **practicar estructuras de datos dinámicas (listas enlazadas)** en C#, implementando operaciones como:

- Inserción al inicio.  
- Recorrido completo de la lista.  
- Eliminación de nodos alrededor de uno específico (versión extendida).  

---

#  Versión 1: Básica (Agregar y Ver)

###  Funcionalidades

-  Agregar nombres al inicio.  
-  Ver todos los nombres almacenados.  
-  Salir del programa.  
-  Los nombres se mantienen en **orden inverso al de ingreso** (el último en entrar aparece primero).  

###  Ejemplo de uso

--- LISTA DE NOMBRES ---

Agregar nombre al inicio

Ver todos los nombres

Salir
Elige una opción: 1
Ingresa un nombre: Juan
Nombre agregado al inicio

Elige una opción: 1
Ingresa un nombre: Ana
Nombre agregado al inicio

Elige una opción: 2
Nombres en la lista:

Ana

Juan

Elige una opción: 3
programa terminado


###  Estructura del código

- **Clase `Nodo`** → guarda un nombre y referencia al siguiente nodo.  
- **Variable `inicio`** → indica el primer nodo de la lista.  
- **Método `AgregarNombre()`** → inserta un nombre al inicio.  
- **Método `VerNombres()`** → recorre y muestra la lista completa.  

---

#  Versión 2: Extendida (Agregar, Ver y Eliminar alrededor)

### Funcionalidades

-  Agregar nombres al inicio.  
-  Ver todos los nombres almacenados.  
-  Eliminar el nombre **antes** y **después** de uno elegido (si existen).  
-  Salir del programa.  

###  Ejemplo de uso

--- LISTA DE NOMBRES ---

Agregar nombre al inicio

Ver todos los nombres

Eliminar antes y después de un nombre

Salir
Elige una opción: 1
Ingresa un nombre: Juan
¡Nombre agregado al inicio!

Elige una opción: 1
Ingresa un nombre: Cobaya
¡Nombre agregado al inicio!

Elige una opción: 2
Nombres en la lista:

Cobaya

Juan

Elige una opción: 3
Ingresa el nombre elegido: Cobaya
No hay nombre antes del seleccionado
Eliminando nombre después: Juan
Eliminación completada


###  Estructura del código

- **Clase `Nodo`** → cada nodo almacena un nombre y referencia al siguiente.  
- **Variable `inicio`** → indica el primer nodo de la lista.  
- **Método `AgregarNombre()`** → inserta un nombre al inicio.  
- **Método `VerNombres()`** → muestra todos los nombres.  
- **Método `EliminarAlrededor()`** → elimina el nodo anterior y posterior al nombre elegido.  

---

##  ¿Por qué los nombres salen al revés?

Porque la lista usa el principio **LIFO (Last In, First Out)**:  
- El **último nombre que agregas** aparece **primero en la lista**.  
- El **primer nombre ingresado** termina quedando al final.  
