# Lista Simple en C#

## 📌 Descripción
Este proyecto implementa una **lista simplemente enlazada** en C#, una estructura de datos dinámica que permite almacenar elementos en nodos conectados de manera secuencial.  
Cada nodo contiene un valor y una referencia al siguiente nodo, lo que facilita operaciones como inserción, eliminación, búsqueda y recorrido.

El programa incluye un menú interactivo en consola que permite al usuario realizar distintas operaciones sobre la lista de manera sencilla.

---

## ⚙️ Operaciones implementadas
- **Insertar al inicio**: Agrega un nuevo nodo al comienzo de la lista.  
- **Insertar al final**: Agrega un nuevo nodo al final de la lista.  
- **Eliminar por valor**: Elimina el primer nodo que contenga el valor indicado.  
- **Buscar valor**: Recorre la lista para comprobar si un valor existe.  
- **Mostrar lista**: Muestra todos los elementos de la lista en orden.  

---

## 📂 Estructura del código
El proyecto está compuesto por tres clases principales:

1. **Nodo**
   - Contiene el dato a almacenar.
   - Guarda la referencia al siguiente nodo.

2. **ListaSimple**
   - Maneja la lógica de la lista enlazada.
   - Contiene los métodos para insertar, eliminar, buscar y mostrar elementos.

3. **Program**
   - Contiene el método `Main`.
   - Muestra un menú para que el usuario pueda interactuar con la lista mediante consola.

---

## ▶️ Ejemplo de uso
Al ejecutar el programa, se mostrará un menú en consola como el siguiente:

```
===== MENÚ LISTA SIMPLE =====

Insertar al inicio

Insertar al final

Eliminar un valor

Buscar un valor

Mostrar lista

Salir
Elige una opción:
```

Ejemplo de ejecución:  
- Insertando los valores `10`, `20` y `30` al final, la lista se mostrará así:  
