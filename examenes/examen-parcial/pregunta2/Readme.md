# DOCUMENTACIÓN DE LA PREGUNTA 2

## Explicación de como funciona
### 1. Declaración de variables
 - **cantidad:** Se refiere a la cantidad de números que ingresará el usuario.
 - **numeros:** Es el arreglo que guarda los valores.

### 2. Ingreso de datos
 - Aquí el usuario tiene que indicar cuantos números va a tener la lista.
 - Luego se tiene que escribir cada número( del 1 al N, pero con uno faltante).

 ### 3. Cálculo de la suma separada
  - Fórmula:
  
---
      
    suma esperada = n * (n+1)/2

---
Esto representa la suma de todos los numeros del 1 al N.


### 4. Cálculo de la suma actual
 - Se suman los numeros que se llegan a ingresar.

### 5. Número faltante
- Se resta <span style="color:green">suma esperada</span> <span style="color:red">-</span> <span style="color:green">suma actual</span>
- El resultado es el numero que falta en la secuencia.

---
## Explicación de líneas de codigo 
### 1. using System;
Esto le dice al programa que use la librería System, que contiene muchas funciones básicas de **C#**, como **Console.WriteLine()** y **Console.ReadLine()** para trabajar con la consola.

---

### 2. class Pregunta2 
 Aquí definimos una clase, que en C# es como un contenedor de código.

 - El nombre Pregunta2 puede variar, pero debe ser único.

 - Dentro de esta clase ponemos el método principal.

---

### 3. static void Main()
Es el punto de entrada de todo programa en C#.
   - **static** → significa que no necesitamos crear un objeto para ejecutar este método.
   - **void** → indica que la función no devuelve ningún valor.
   - **Main** → es el nombre especial que C# busca para arrancar el programa.

---

### 4. Console.Write
Imprime en la pantalla sin salto de línea

---

### 5. Console.WriteLine
Imprime en la pantalla y luego hace un salto de línea.

---

### 6. int.Parse(Console.ReadLine())
Convierte lo que escribe el usuario en un número entero.

---

### 7. for (int i = 0; i < cantidad; i++)
Bucle que pide al usuario todos los numeros
   - **int i = 0** ->inicia el contador en 0.

   - **i < cantidad** → condición para seguir repitiendo.

   - **i++** → aumenta i en 1 cada vez.

   Se usa para recorrer arreglos o matrices.

--- 

### 8. foreach (int num in numeros)
Recorre el arreglo sumando cada valor.