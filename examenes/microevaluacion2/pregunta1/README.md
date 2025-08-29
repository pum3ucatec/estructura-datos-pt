#  Proyecto: Cola con Inserción al Inicio  

Este proyecto implementa una **estructura de datos tipo Cola** en C# usando **nodos enlazados**.  
El programa permite mostrar los elementos de la cola e **insertar nuevos valores al inicio** mediante un menú interactivo.  

---

## Archivos principales  

- **Nodo.cs** → Representa cada nodo de la lista (guarda el dato y la referencia al siguiente).  
- **Cola.cs** → Contiene los métodos principales:  
  - `AgregarAlInicio()` → Inserta un valor al inicio de la lista.  
  - `Mostrar()` → Recorre y muestra todos los elementos.  
- **Program.cs** → Programa principal con el menú para interactuar.  

---

## Ejecución del programa  

Al iniciar, la lista se llena con los valores iniciales:  

P → K → A → D → D → A   

# Después, aparece el menú:  
--- Menú ---  

1. Mostrar lista  

2. Insertar al inicio  

3. Salir  

Elige una opción:

---

## Ejemplo de uso  

**Mostrar lista:**  
  
Elementos: P K A D D A  

**Insertar un valor al inicio:**  
  
Escribe el valor a insertar al inicio: X  
  
'X' agregado al inicio.  
  
Elementos: X P K A D D A  

**Salir del programa:**  

---

## Conclusión  

Este ejercicio demuestra cómo trabajar con una **lista enlazada simple en C#**, ofreciendo:  
- Visualización de elementos.  
- Inserción de datos al inicio.  
- Interacción mediante un menú sencillo.  
