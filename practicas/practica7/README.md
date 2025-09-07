# Implementacion De Una Cola Con Nodos En PascalCase En CSharp

Este Programa Implementa Una Estructura De Datos **Cola Con Nodos** Utilizando La Convencion **PascalCase**.  
Se Incluyen Operaciones Como Insertar, Eliminar, Mostrar, Buscar, Contar, Vaciar Y Eliminar En Una Posicion Especifica.  

---

## Explicacion Del Codigo

1. **Clase Nodo**
   - Contiene:
     - `Valor` → Dato Que Almacena El Nodo.
     - `Siguiente` → Referencia Al Nodo Siguiente.

2. **Clase Cola**
   - Atributos:
     - `Frente` → Primer Nodo De La Cola.
     - `Final` → Ultimo Nodo De La Cola.

   - Metodos Principales:
     - `Enqueue(Valor)` → Inserta Un Elemento Al Final.
     - `Dequeue()` → Elimina El Elemento En El Frente.
     - `Peek()` → Muestra El Elemento En El Frente Sin Eliminarlo.
     - `IsEmpty()` → Verifica Si La Cola Esta Vacia.
     - `View()` → Muestra Todos Los Elementos.
     - `Count()` → Cuenta Los Elementos.
     - `Clear()` → Vacía La Cola.
     - `Search(Valor)` → Busca Un Elemento.
     - `RemoveAt(Posicion)` → Elimina Un Elemento En Una Posicion Especifica.

3. **Clase Principal**
   - Contiene El Metodo `Main`, Donde Se Muestra Un **Menu Interactivo** Para Realizar Operaciones Sobre La Cola.

---

## Ejemplo De Ejecucion

```
===== Menu Cola Con Nodos =====
1. Mostrar Cola
2. Insertar Un Valor A La Cola
3. Eliminar Un Valor De La Cola
4. Ver Frente De La Cola
5. Verificar Si Esta Vacia
6. Contar Elementos
7. Vaciar Cola
8. Buscar Elemento
9. Eliminar En Una Posicion Especifica
0. Salir
Seleccione Una Opcion: 2
Ingrese El Nombre A Insertar: Maria
Elemento 'Maria' Insertado.

Seleccione Una Opcion: 1
Elementos En La Cola:
 - Maria
```

---

Todo El Codigo Y La Documentacion Estan Escritos Usando La Convencion **PascalCase**.