# Práctica 7: Cola con Nodos en C#

## Descripción

Este proyecto implementa una **cola (queue) dinámica** utilizando **nodos enlazados** en C#.  
Permite operaciones típicas de una cola: insertar, eliminar, ver frente, verificar si está vacía, contar elementos, vaciar la cola y buscar un valor.


El proyecto consta de tres clases principales:
- **Nodo.cs** → Representa cada nodo.
- **Cola.cs** → Implementa la estructura de la cola con operaciones básicas.
- **Program.cs (Principal.cs)** → Muestra la interfaz de usuario mediante un menú en consola.



---

## Estructura de la cola

La cola se compone de nodos, donde cada nodo contiene un dato y una referencia al siguiente nodo.

```
A[Frente] --> B[Nodo 1] --> C[Nodo 2] --> E[Final]
```

---

## Estructura del proyecto

    ColaNodo/
    │
    ├─ Nodo.cs # Clase Nodo genérico
    ├─ Cola.cs # Clase Cola genérica con operaciones
    ├─ Program.cs # Clase principal con menú de consola
    ├─ ColaNodo.csproj
    └─ README.md

---

## Funcionalidades
1. **Mostrar Cola** → Visualiza todos los elementos de la cola.  
2. **Insertar (Enqueue)** → Añade un elemento al final de la cola.  
3. **Eliminar (Dequeue)** → Elimina el elemento del frente de la cola.  
4. **Ver frente (Peek)** → Muestra el elemento al frente sin eliminarlo.  
5. **Verificar si está vacía** → Retorna si la cola tiene elementos o no.  
6. **Contar elementos** → Muestra la cantidad de elementos en la cola.  
7. **Vaciar cola (Clear)** → Elimina todos los elementos de la cola.  
8. **Verificar si contiene un valor (Contains)** → Busca un valor específico dentro de la cola.  
9. **Eliminar cualquier elemento** → Elimina un elemento especifico no siempre el del frente.
---

## Ejecución del programa
1. Obtenga los cambios de la rama.
2. Abre el proyecto en tu IDE de preferencia.
3. Recuerda tener instalado el .Net
4. Ejecuta el archivo Program.cs con dotnet run.

---

## Ejemplo de ejecución
     ===== MENÚ COLA con NODOS =====
    1. Mostrar Cola
    2. Insertar (Enqueue)
    3. Eliminar (Dequeue)
    4. Ver frente (Peek)
    5. Verificar si está vacía
    6. Contar elementos
    7. Vaciar cola (Clear)
    8. Verificar si contiene un valor
    9. Eliminar cualquier elemento
    0. Salir
    Seleccione una opción: 5
    La cola está vacía.

---

## Detalles a aclarar

En este caso hemos usado generics **(< T >)**, lo que significa que el nodo puede almacenar cualquier tipo de dato que elijamos cuando creemos la cola.
- **Diferencia**
    - Sin < T > (con string) → la estructura solo sirve para strings.
    - Con < T > (genérica) → la estructura sirve para cualquier tipo de dato, más flexible y reutilizable.

---

Hemos Declarado la propiedad como nullable con `?`

    public Nodo<T>? Siguiente { get; set; }


### Pero que significa  `?` en C#

En C#, al declarar una variable o propiedad como nullable, se indica que puede contener un valor null además de su tipo normal. Se hace agregando `?` después del tipo:


     private Nodo<T>? frente;
     private Nodo<T>? fin;

Esto significa que frente o Siguiente pueden ser null, lo cual tiene sentido en estructuras de datos dinámicas como colas o listas enlazadas, donde:

- Al inicio, la cola está vacía → frente = null

- El último nodo de la cola apunta a null → Siguiente = null

---

### Ahora por que lo hemos utilizado?
Pues para evitar warnings del compilador sobre referencias nullables

En .NET 6+ y C# 8+, las referencias no-nullable (Nodo<T> frente) no pueden iniciar como null y como nuestra cola empieza vacía:

     private Nodo<T> frente = null; // ❌ Nos marca Error CS8625


Si usamos:

    private Nodo<T>? frente = null; // ✅ Correcto


Con esto estamos diciendo: "Esta variable puede ser null", y el compilador deja de generar warnings.

---

### En resumen.......

Hemos utilizado esto....  por tal cosa:

- **Nodo< T >? frente**	-->La cola puede estar vacía al inicio
- **Nodo< T >? Siguiente** -->El último nodo apunta a null
- **? al acceder** -->	Evita NullReferenceException al recorrer la lista
- **! al acceder** -->	Indica al compilador que sabemos que no es null