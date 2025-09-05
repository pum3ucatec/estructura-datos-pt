**INDICE**
- [Práctica 6: Implementación de Colas en C#](#práctica-6-implementación-de-colas-en-c)
  - [1. Estructura del Proyecto](#1-estructura-del-proyecto)
  - [2. Clase MyQueue](#2-clase-myqueue)
  - [3. Clase Program](#3-clase-program)
  - [4. Ejecución del programa](#4-ejecución-del-programa)
      - [4.1 Ejemplo de ejecución](#41-ejemplo-de-ejecución)

# Práctica 6: Implementación de Colas en C#

Este proyecto contiene la implementación de una estructura de datos tipo **Cola (Queue)** en C#, el cual sigue el principio **FIFO** y se esta utilizando un arreglo de caracteres **(char[])**: lo que te permite ingresar letras,números, símbolos, etc.  


El tipo de cola en este proyecto es **lineal** porque:
- Cuando haces **Enqueue**, el puntero **rear** avanza hasta el final.
- Cuando haces **Dequeue**, el puntero **front** también avanza.
- Pero si rear llega al último índice del arreglo y la cola no está llena (porque se liberaron elementos al inicio), **ese espacio ya no se reutiliza.**

Esta práctica sigue las siguientes convenciones de nombres:

- Clases y métodos → PascalCase

- Variables locales y parámetros → camelCase

---

## 1. Estructura del Proyecto

- **MyQueue.cs**  
    Contiene la implementación de la clase `MyQueue`, que define los métodos y propiedades para gestionar una cola personalizada.

- **Program.cs**  
    Archivo principal donde se realizan pruebas y demostraciones del funcionamiento de la clase `MyQueue`.

---

## 2. Clase MyQueue

**Archivo:** [`my-queue/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica6/practicas/practica6/Cola/MyQueue.cs)


Primero se definio el constructor:
- **Size = N;** → el tamaño máximo de la cola.

- **Elements = new char[N];** → el arreglo que guarda los elementos.

- **Front = 0;** → el frente de la cola empieza en 0.

- **Rear = -1;** → el final empieza en -1 (porque todavía no hay nada insertado).

- **Count = 0;** → contador de elementos.

Posterior a ello de definieron los metodos:
- **Enqueue:** Insertar un elemento al final de la cola.  
- **Dequeue:** Eliminar y devolver el primer elemento de la cola.  
- **Peek:** Ver el primer elemento sin eliminarlo.  
- **Mostrar:** Imprimir todos los elementos de la cola.  
- **GetCount:** Obtener la cantidad actual de elementos en la cola.  
- **GetLength:** Consultar la capacidad máxima de la cola.  
- **Contains:** Buscar si un elemento existe en la cola.  
- **IsEmpty:** Verificar si la cola está vacía.  
- **IsFull:** Verificar si la cola está llena.  

---

## 3. Clase Program

**Archivo:** [`Program/Program.cs`](https://github.com/pum3ucatec/estructura-datos-pt/blob/QuispeIsabel/Practica6/practicas/practica6/Cola/Program.cs)

Aqui se tiene el menú que representa el funcionamiento de la clase MyQueue.

        --- MENÚ ---

      1. Agregar un elemento(Enqueue)
      2. Eliminar un elemento (Dequeue)
      3. Ver frente (Peek)
      4. Mostrar cola
      5. Ver cantidad de elementos (Count)
      6. Ver tamaño de la cola(length)
      7. Buscar elemento (Contains)
      8. Ver si esta vacia (IsEmty)
      9.Ver si esta llena (IsFull)
      9. Salir

## 4. Ejecución del programa

1. Obten los cambios de la rama.
2. Abre el proyecto en tu IDE de preferencia.
3. Recuerda tener instalado el .Net
4. Ejecuta el archivo `Program.cs`  con dotnet run.

#### 4.1 Ejemplo de ejecución

    Ingrese el tamaño de la cola: 3

        --- MENÚ ---
    1. Agregar un elemento(Enqueue)
    2. Eliminar un elemento (Dequeue)
    3. Ver frente (Peek)
    4. Mostrar cola
    5. Ver cantidad de elementos (Count)
    6. Ver tamaño de la cola(length)
    7. Buscar elemento (Contains)
    8. Ver si esta vacia (IsEmty)
    9.Ver si esta llena (IsFull)
    0. Salir
    Seleccione una opción: 1
    Ingrese un carácter para agregar: C
    Insertado C en la cola.

Y eso es todo `**GRACIAS!!!!**
