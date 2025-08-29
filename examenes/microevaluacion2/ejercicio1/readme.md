#  Lista Simple de Nombres
Un programa simple en C# que permite gestionar una lista de nombres usando una lista simplemente enlazada.

## que hace el programa
Este programa te permite:

1. Agregar nombres al principio de la lista

2.  Ver todos los nombres almacenados

3.  Mantener los nombres en orden de ingreso inverso (el último en entrar aparece primero)

##  Como usar
Ejecuta el programa

Selecciona una opción del menú:
```
Opción 1: Agregar un nuevo nombre

Opción 2: Ver todos los nombres guardados

Opción 3: Salir del programa
```
Para agregar nombres:

Elige la opción 1
```
Escribe el nombre

Presiona Enter
```
El nombre se agregara al inicio de la lista

## Ejemplo de uso
```
--- LISTA DE NOMBRES ---
1. Agregar nombre al inicio
2. Ver todos los nombres
3. Salir
Elige una opción: 1
Ingresa un nombre: Juan
¡Nombre agregado al inicio!

Elige una opción: 1
Ingresa un nombre: Cobaya
¡Nombre agregado al inicio!

Elige una opción: 2
Nombres en la lista:
1. Cobaya
2. Juan
```
## Estructura del código
Clase Nodo: Cada "caja" que almacena un nombre y apunta al siguiente

Variable inicio: Guarda el primer nombre de la lista

Método AgregarNombre(): Añade nombres al principio

Método VerNombres(): Muestra todos los nombres guardados

## porque los nombres salen al reves
Porque el programa usa el principio LIFO (Last In, First Out):

El último nombre que ingresas se convierte en el primero de la lista

El primer nombre que ingresaste termina siendo el último
