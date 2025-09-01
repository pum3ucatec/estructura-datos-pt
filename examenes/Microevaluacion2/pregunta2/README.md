# Lista Simple de Nombres en C# (Versión Extendida)

Un programa en **C#** que permite gestionar una **lista simplemente enlazada de nombres** con tres funcionalidades principales: **agregar, ver y eliminar alrededor de un nombre elegido**.

---

##  ¿Qué hace el programa?

Con este programa puedes:

-  **Agregar nombres al inicio** de la lista.  
-  **Ver todos los nombres** almacenados en orden.  
-  **Eliminar el nombre antes y después** de un nombre que elijas (si existen).  
-  **Salir del programa** cuando quieras.  

---

##  Cómo usarlo

1. Ejecuta el programa en consola.  
2. Selecciona una opción del menú:

   - **Opción 1:** Agregar un nuevo nombre.  
   - **Opción 2:** Ver todos los nombres guardados.  
   - **Opción 3:** Eliminar el nombre antes y después de uno elegido.  
   - **Opción 4:** Salir del programa.  

 **Para agregar nombres:**
- Elige la opción `1`.  
- Escribe el nombre.  
- Presiona **Enter**.  
- El nombre se insertará al inicio de la lista.  

**Para eliminar alrededor de un nombre:**
- Elige la opción `3`.  
- Escribe el nombre de referencia.  
- El programa eliminará el **anterior** y el **siguiente** (si existen).  

---

## Ejemplo de uso

--- LISTA DE NOMBRES ---

Agregar nombre al inicio

Ver todos los nombres

Eliminar antes y después de un nombre

Salir
Elige una opción: 1
Ingresa un nombre: Juan
¡Nombre agregado al inicio!

Elige una opción: 1
Ingresa un nombre: Ana
¡Nombre agregado al inicio!

Elige una opción: 1
Ingresa un nombre: Pedro
¡Nombre agregado al inicio!

Elige una opción: 2
Nombres en la lista:

Pedro

Ana

Juan

Elige una opción: 3
Ingresa el nombre elegido: Ana
Eliminando nombre antes: Pedro
Eliminando nombre después: Juan
Eliminación completada

Elige una opción: 2
Nombres en la lista:

Ana

Elige una opción: 4
Adiós

yaml
Copiar código

---

##  Estructura del código

- **Clase `Nodo`:**  
  Cada nodo guarda un `nombre` y una referencia al siguiente nodo.  

- **Variable `inicio`:**  
  Señala el primer nodo de la lista.  

- **Método `AgregarNombre()`:**  
  Inserta un nuevo nombre **al inicio** de la lista.  

- **Método `VerNombres()`:**  
  Recorre la lista y muestra todos los nombres guardados.  

- **Método `EliminarAlrededor()`:**  
  Busca un nombre en la lista y elimina el nodo **anterior** y el **siguiente** (si existen).  

---

##  ¿Por qué los nombres salen al revés?

Porque la inserción siempre es **al inicio de la lista**:  
- El **último nombre agregado** aparece **primero en la lista**.  
- El **primer nombre ingresado** termina quedando al final.