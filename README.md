# Proyecto: Lista Enlazada en C#

Este proyecto implementa una **lista enlazada simple** en C#.  
La lista permite realizar operaciones básicas como:

- Insertar nodos al principio.  
- Eliminar nodos alrededor de un valor específico.  
- Mostrar el contenido de la lista.  

---

##  Estructura del Código

El código está dividido en **tres incisos principales**:

### 🔹Inciso A: Insertar al principio
```csharp
public void InsertarAlPrincipio(int valor)

-Crea un nodo nuevo con el valor recibido.
-Hace que este nuevo nodo se convierta en la cabeza de la lista.
-El nuevo nodo apunta al que antes era la cabeza.

EJEMPLO
Si la lista es 10 -> 20 -> 30 -> null
```
### 🔹 Inciso B: Eliminar alrededor de un valor
```csharp
public void EliminarAlrededor(int valor)

-Busca el nodo que contiene el valor indicado.
-Si lo encuentra:
-Elimina el nodo anterior (si existe).
-Elimina el nodo siguiente (si existe).

Ejemplo
Lista original:
10 -> 20 -> 30 -> 40 -> 50 -> null

Después de ejecutar EliminarAlrededor(30):
10 -> 30 -> 50 -> null
```
###🔹 Inciso C: Mostrar lista
```csharp
public void MostrarLista()
Recorre la lista desde la cabeza hasta el final.

Imprime todos los nodos en el formato:
rust
Copiar código
valor1 -> valor2 -> ... -> null

 Ejemplo de salida:
rust
Copiar código
Lista: 10 -> 20 -> 30 -> 40 -> 50 -> null
