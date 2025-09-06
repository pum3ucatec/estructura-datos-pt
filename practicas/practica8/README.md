# **INDICE**

* [1. Descripción](#1-descripción)
  * [1.1. Lista Simple](#11-lista-simple)

---

# 1. Descripción

En esta práctica se implementa una **lista simple** en C#, utilizando nodos enlazados  
El programa permite insertar, eliminar, buscar y recorrer elementos en la lista mediante un menú interactivo.

* **Ejecución:**

1. Abrimos la carpeta del proyecto en la terminal  
   ![Ruta](Carrr.png)
2. Ejecutamos el comando:
    <pre>
    dotnet run</pre>

**Estilo de nombrado:**
- **Clases** → PascalCase (`ListaSimple`, `Nodo`)
- **Métodos** → PascalCase (`InsertarAlInicio`, `Buscar`, `Eliminar`)
- **Variables** → snake_case (`cabeza`, `temp`, `op`)

---

## 1.1. Lista Simple

El menú implementado tiene las siguientes opciones:

1. **Mostrar lista** → Recorre la lista desde el inicio e imprime sus elementos.  
2. **Insertar al inicio** → Inserta un nuevo nodo al comienzo de la lista.  
3. **Insertar al final** → Inserta un nuevo nodo al final de la lista.  
4. **Eliminar elemento** → Elimina un nodo por su valor.  
5. **Buscar elemento** → Busca un nodo en la lista y muestra su posición.  
6. **Cantidad de elementos** → Devuelve el número de nodos en la lista.  
7. **Verificar si está vacía** → Indica si la lista no contiene nodos.  
0. **Salir** → Finaliza la ejecución del programa.  

### **Flujo del programa:**
1. Se inicializa la lista vacía.  
2. El usuario selecciona una opción del menú.  
3. Dependiendo de la opción, se ejecuta la acción correspondiente sobre la lista.  
4. El menú se repite hasta que el usuario elige salir.  

### **Métodos implementados en `ListaSimple`:**
- `Mostrar()`  
- `InsertarAlInicio(string nombre)`  
- `InsertarAlFinal(string nombre)`  
- `Eliminar(string nombre)`  
- `Buscar(string nombre)`  
- `Cantidad()`  
- `EstaVacia()`  


