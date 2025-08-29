**INDICE**
- [Microevaluación 2](#microevaluación-2)
  - [1. Ejercicio 1](#1-ejercicio-1)
  - [1.1. Ejecución del programa](#11-ejecución-del-programa)
  - [1.2. Funciones](#12-funciones)
      - [Mostrar Lista](#mostrar-lista)
      - [Insertar al principio](#insertar-al-principio)
      - [Salir](#salir)
  - [1.3.  Ejemplo de uso](#13--ejemplo-de-uso)
      - [Selecciona una opcion del menu:](#selecciona-una-opcion-del-menu)
  - [1.4.  Ejemplo de ejecución:](#14--ejemplo-de-ejecución)
  - [2. Ejercicio 2](#2-ejercicio-2)
  - [2.1 Funciones](#21-funciones)
    - [Mostrar Lista](#mostrar-lista-1)
    - [Insertar al principio](#insertar-al-principio-1)
    - [Eliminar alrededor de la posición dada](#eliminar-alrededor-de-la-posición-dada)
    - [Salir](#salir-1)
  - [2.2. Explicación del por que no funcionó el programa](#22-explicación-del-por-que-no-funcionó-el-programa)
    
# Microevaluación 2
## 1. Ejercicio 1

Este proyecto implementa una **lista simple enlazada** en C#, donde la función principal  es  insertar elementos al inicio de la lista y mostrarlos en consola.

El proyecto consta de 3 clases principales:
- **Nodo.cs** → Aqui se define la clase `Nodo`, que contiene:
  - `Dato`: Este almacena la información (tipo `string`).
  - `Siguiente`: El cual hace referencia al siguiente nodo de la lista.

- **ListasSimples.cs** → Contiene la lógica de la lista, el método:
  - `InsertarAlPrincipio(string dato)`
  - `Mostrar()`

- **Program.cs** → Programa principal con menú de opciones:
  - Insertar elementos en la lista.
  - Mostrar la lista.
  - Salir del programa.

---

## 1.1. Ejecución del programa
1. Obtenga los cambios de la rama.
2. Abre el proyecto en tu IDE de preferencia.
3. Recuerda tener instalado el .Net
4. Ejecuta el archivo Program.cs con dotnet run.

---   

## 1.2. Funciones

#### Mostrar Lista

Muestra todos los nombres de la lista en orden desde el primero hasta el ultimo.

#### Insertar al principio
Permite agregar un nuevo nombre(Nodo) al inicio de la lista y esto se lo ingresa desde consola.

#### Salir
Finaliza el programa.

---

## 1.3.  Ejemplo de uso


    1. Insertar al principio
    2. Mostrar lista
    0. Salir
    Opción:

#### Selecciona una opcion del menu:
   
   - `1` para mostrar la lista.
   - `2` para insertar un nodo al principio.

---

## 1.4.  Ejemplo de ejecución:

    Opción: 1
    Ingrese un nombre: maria
    1. Insertar al principio
    2. Mostrar lista
    0. Salir
    Opción: 1
    Ingrese un nombre: juan
    1. Insertar al principio
    2. Mostrar lista
    0. Salir
    Opción: 2
    Lista: juan maria

---


## 2. Ejercicio 2
Este proyecto implementa una **lista simple enlazada** en C#, donde la función principal  es  eliminar los elememtos que se encuentran alrededor de la posición dada.

El proyecto consta de 3 clases principales:
- **Nodo.cs** → Aqui se define la clase `Nodo`, que contiene:
  - `Dato`: Este almacena la información (tipo `string`).
  - `Siguiente`: El cual hace referencia al siguiente nodo de la lista.

- **ListasSimples.cs** → Contiene la lógica de la lista, el método:
  - `InsertarAlPrincipio(string dato)`
  - `EliminarAlrededor(string dato)`
  - `Mostrar()`

- **Program.cs** → Programa principal con menú de opciones:
  - Insertar elementos en la lista.
  - Mostrar la lista.
  - Eliminar alrededor de la posición
  - Salir del programa.
  
---

## 2.1 Funciones

###  Mostrar Lista
Muestra todos los nombres de la lista en orden desde el primero hasta el ultimo.

### Insertar al principio
Permite agregar un nuevo nombre(Nodo) al inicio de la lista y esto se lo ingresa desde consola.

### Eliminar alrededor de la posición dada
Esta función elimina los elementos que se encuentran alrededor de dicha posición ingresada por consola


###  Salir
Finaliza el programa.

--- 

## 2.2. Explicación del por que no funcionó el programa

En este caso el programa no funciona, no pude terminarlo,
Sin embargo haré mención de las lineas de codigo que me falto, y con las cuales si iba a llegar a Funcionar.

- ****Nodo.cs**** Esta clase esta completa.
  
--

- **ListasSimples.cs** Aca se me fue, se debe de cambiar esto:
     
   ```csharp
       Console.WriteLine($"Eliminado el nodo anterior con nombre '{anterior.  Nombre}'");
            if (anterior == cabeza)

- Por esto: 
  ```csharp

       Console.WriteLine($"Eliminado el nodo anterior con nombre '{anterior.  Dato}'");
            if (anterior == cabeza)

Ademas de que no declare la propiedad Nodo?

Si bien el programa deberia de funcionar normal sin `?`, ya que no llega a ser necesario.
En mi caso yo uso  C# 8.0 con las referencias anulables habilitadas (#nullable enable), es por eso que el compilador me advierte que Siguiente puede ser null y que debería declararlo como  `Nodo?`

---

- **Program.cs** Pues aqui me falto terminar las lineas de codigo:
     ```csharp
        Console.Write("Ingrese el nombre central: ");
        string nombreCentral = Console.ReadLine()!;
        lista.EliminarAlrededor(nombreCentral);

Que debería de ir en:
            
```csharp
        case '3':
            lista.Mostrar();
            Console.Write("Ingrese el nombre central: ");
            string nombreCentral = Console.ReadLine()!;
            lista.EliminarAlrededor(nombreCentral);
            break;

