# Proyecto: Cola con Eliminación alrededor de un valor  

Este proyecto implementa una **cola enlazada en C#** con operaciones avanzadas.  
El programa permite mostrar los elementos, ingresar letras al final y eliminar nodos que estén **alrededor de un valor específico**.  

---

##  Archivos principales  

- **Nodo.cs** → Define cada nodo con dos propiedades:  
  - `Dato` → Valor almacenado.  
  - `Siguiente` → Referencia al siguiente nodo.  

- **Cola.cs** → Contiene los métodos principales de la estructura:  
  - `InsertarAlFinal(valor)` → Inserta un nuevo nodo al final.  
  - `Mostrar()` → Recorre y muestra los elementos con su posición.  
  - `CargarInicial(valores[])` → Carga los valores iniciales en la lista.  
  - `EliminarAlrededor(valor)` → Busca el valor dado y elimina sus **nodos vecinos** (anterior y siguiente).  

- **Program.cs** → Programa principal con un menú interactivo para el usuario.  

---

## Ejecución del programa  

Al iniciar, la lista se carga con los valores:  

P → K → A → D → D → A

El menú disponible es:  
--- Menú de opciones ---

1. Mostrar lista

2. Eliminar alrededor de un valor

3. Ingresar letra

4. Salir
Elige una opción:

---

## Ejemplo de uso  

**1. Mostrar lista:**  
Elementos en la lista: [1:P] [2:K] [3:A] [4:D] [5:D] [6:A]

**2. Eliminar alrededor de un valor:**  
Ingrese el valor alrededor del cual desea eliminar: A
Se eliminó 'K' en la posición 2
Se eliminó 'D' en la posición 4

**3. Ingresar letra:**  
Ingrese la letra a agregar: X
'X' agregado a la lista.

**4. Salir:**  

---

## Conclusión  

Este proyecto extiende el manejo de **colas enlazadas en C#**, permitiendo:  
- Insertar valores al final de la lista.  
- Mostrar los elementos con sus posiciones.  
- Eliminar nodos vecinos alrededor de un valor específico.  
- Controlar la ejecución con un menú simple en consola. 