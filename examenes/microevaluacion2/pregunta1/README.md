#  Lista Simple en C#

Este proyecto muestra cómo funciona una **lista simplemente enlazada** en C#.  
Una lista simple es una estructura de datos donde cada nodo guarda un valor y una referencia al siguiente nodo. Lo q hace el programa es ingresar un dato y cada dato nuevo hace que el dato que antes era el Head pasa a ser el siguiente (Next).
---

##  ¿Qué hace el código?

1. **ListaSimple (Head)**  
   - `Head` apunta siempre al primer nodo.  
   - Si `Head` es `null`, la lista está vacía.  

2. **Agregar al inicio (`AddFirst`)**  
   - Crea un nuevo nodo.  
   - El nuevo nodo apunta al antiguo primero.  
   - `Head` se actualiza al nuevo nodo.  

3. **Mostrar la lista (`View`)**  
   - Recorre los nodos desde `Head`.  
   - Imprime sus valores en orden.  
   - Si está vacía, muestra un mensaje.  

---



- Con `AddFirst`, alguien nuevo entra **al frente de la fila**.  
- Con `View`, recorres la fila de principio a fin diciendo los nombres.  

