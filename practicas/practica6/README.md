# Implementacion De Una Cola En PascalCase En CSharp

Este Programa Implementa Una Estructura De Datos **Cola** Utilizando Un Arreglo Circular.  
Se Permiten Operaciones Clasicas Como Insertar, Eliminar, Mostrar, Buscar Y Consultar Estado.  

---

## Explicacion Del Codigo

1. **Clase Cola**
   - Contiene Los Atributos:
     - `Elementos` → Arreglo Que Almacena Los Datos.
     - `Frente` → Indica El Primer Elemento De La Cola.
     - `Fin` → Indica El Ultimo Elemento Insertado.
     - `CountInterno` → Cuenta El Numero De Elementos.
     - `Capacidad` → Tamaño Maximo De La Cola.

2. **Constructor**
   ```csharp
   public Cola(int Size)
   {
       Capacidad = Size;
       Elementos = new int[Capacidad];
       Frente = 0;
       Fin = -1;
       CountInterno = 0;
   }
   ```
   - Inicializa La Cola Con El Tamaño Definido Por El Usuario.

3. **Operacion Enqueue (Insertar)**
   ```csharp
   public void Enqueue(int Valor)
   {
       if (IsFull())
       {
           Console.WriteLine("❌ La Cola Esta Llena. No Se Puede Insertar.");
           return;
       }
       Fin = (Fin + 1) % Capacidad;
       Elementos[Fin] = Valor;
       CountInterno++;
       Console.WriteLine($"✔ Se Inserto: {Valor}");
   }
   ```

4. **Operacion Dequeue (Eliminar)**
   ```csharp
   public int Dequeue()
   {
       if (IsEmpty())
       {
           Console.WriteLine("❌ La Cola Esta Vacia. No Se Puede Eliminar.");
           return -1;
       }
       int Valor = Elementos[Frente];
       Frente = (Frente + 1) % Capacidad;
       CountInterno--;
       Console.WriteLine($"✔ Se Elimino: {Valor}");
       return Valor;
   }
   ```

5. **Otros Metodos**
   - `Peek()` → Devuelve El Elemento En El Frente.  
   - `Count()` → Devuelve El Numero De Elementos En La Cola.  
   - `Size()` → Devuelve La Capacidad Total.  
   - `Contains(Valor)` → Verifica Si Un Elemento Existe.  
   - `IsEmpty()` → Indica Si Esta Vacia.  
   - `IsFull()` → Indica Si Esta Llena.  
   - `Display()` → Muestra Todos Los Elementos.

6. **Menu De Opciones En Main**
   - Permite Al Usuario Interactuar Con La Cola:
     - Insertar (`Enqueue`)
     - Eliminar (`Dequeue`)
     - Mostrar Frente (`Peek`)
     - Mostrar Todos Los Elementos (`Display`)
     - Consultar Cantidad (`Count`)
     - Ver Capacidad (`Size`)
     - Buscar Un Valor (`Contains`)
     - Verificar Estado (`IsEmpty`, `IsFull`)
     - Salir

---

## Ejemplo De Ejecucion

```
Ingrese La Capacidad De La Cola (Entero Positivo): 3

--- Menu De Operaciones ---
1. Enqueue (Insertar)
2. Dequeue (Eliminar)
3. Peek (Mostrar Frente)
4. Mostrar Cola
5. Count (Cantidad)
6. Size (Capacidad)
7. Contains (Buscar)
8. Esta Vacia?
9. Esta Llena?
0. Salir

Seleccione Una Opcion: 1
Ingrese Un Valor: 10
✔ Se Inserto: 10

Seleccione Una Opcion: 4
Cola: 10
```

---

Todo El Codigo Y La Documentacion Estan Escritos Siguiendo La Convencion **PascalCase**.