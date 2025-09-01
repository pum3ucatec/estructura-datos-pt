# Practiva con C#

En este documento se explicara los diferentes ejercicios basicos con C#, como ejecutarlos, su funcionamiento y los metodos usados.

- **Como ejecutarlo:**

Se abre la terminal integrada y se coloca lo siguiente

```bash
dotnet run
```

**Dato:**
El estilo usado para los ejercicios es snake_case


## Ejercicio 1: Contar del 1 al 10
**Descripción:**  
Muestra en pantalla los números del 1 al 10.  

**Funcionamiento:**  
Se utiliza un ciclo que comienza en 1 y se incrementa hasta llegar a 10, imprimiendo cada valor en cada iteración.  

**Métodos usados:**  
- Bucle `for`  
- `Console.WriteLine` para mostrar los valores  


## Ejercicio 2: Sumar números del 1 al N
**Descripción:**  
El usuario introduce un número `N` y el programa calcula la suma de todos los números desde 1 hasta `N`.  

**Funcionamiento:**  
Un ciclo se repite mientras el contador sea menor o igual a `N`, acumulando la suma en una variable.  

**Métodos usados:**  
- Bucle `while`  
- Entrada de datos con `Console.ReadLine`  
- Conversión con `int.Parse`  

**Qué es o qué hace?**
- _int.Parse_ -> para convertir un valor de cadena en un valor entero


## Ejercicio 3: Tabla de multiplicar
**Descripción:**  
Se pide un número al usuario y se muestra su tabla de multiplicar del 1 al 10.  

**Funcionamiento:**  
Se usa un ciclo que recorre del 1 al 10, multiplicando en cada paso el número ingresado por el usuario.  

**Métodos usados:**  
- Bucle `for`  
- Entrada y salida de datos  


## Ejercicio 4: Menú con do-while
**Descripción:**  
Se muestra un menú con opciones (saludar, sumar y salir). El menú se repite hasta que el usuario elija salir.  

**Funcionamiento:**  
Se utiliza un bucle que vuelve a mostrar el menú tras cada acción, mientras la opción seleccionada no sea "Salir".  

**Métodos usados:**  
- Bucle `do-while`  
- Condicionales `if` y `else if`  
- Entrada de datos del usuario  


## Ejercicio 5: Cuenta regresiva
**Descripción:**  
Contador regresivo Mostrar una cuenta regresiva del 10 al 1 usando while.  

**Funcionamiento:**  
Se usa un bucle que comienza en 10 y se disminuye hasta llegar a 1, imprimiendo cada valor en cada resta.  

**Métodos usados:**  
- Bucle `while`  


## Ejercicio 6: Validar entrada con do-while
**Descripción:**  
El programa pide un número positivo y sigue solicitando hasta que el usuario introduzca uno válido.  

**Funcionamiento:**  
El ciclo se repite hasta que el número ingresado cumpla la condición de ser mayor a 0.  

**Métodos usados:**  
- Bucle `do-while`  
- Entrada y conversión de datos  


## Ejercicio 7: Suma de 5 números
**Descripción:**  
Se solicitan 5 números al usuario y se suman entre sí.  

**Funcionamiento:**  
El ciclo se repite cinco veces, cada vez se guarda el número ingresado y se acumula en una variable.  

**Métodos usados:**  
- Bucle `for`  
- Entrada de datos  
- Variable acumuladora  


## Ejercicio 8: Detectar número primo
**Descripción:**  
Se verifica si un número ingresado por el usuario es primo o no.  

**Funcionamiento:**  
El programa prueba si el número es divisible entre otros números menores a él. Si encuentra un divisor, concluye que no es primo.  

**Métodos usados:**  
- Bucle `for`  
- Condicionales  
- Variable booleana para verificar el estado  


## Ejercicio 9: Primeros 10 números pares
**Descripción:**  
Muestra en pantalla los primeros 10 números pares.  

**Funcionamiento:**  
Se inicia con el número 2 y se incrementa de dos en dos, mientras un contador controla que se impriman solo diez valores.  

**Métodos usados:**  
- Bucle `while`  
- Variable contador  


## Ejercicio 10: Juego "Adivina el número"
**Descripción:**  
El sistema genera un número aleatorio del 1 al 50 y el usuario intenta adivinarlo. El programa indica si el número a adivinar es mayor o menor, hasta que se acierte.  

**Funcionamiento:**  
En cada intento, el programa compara el número del usuario con el aleatorio y da una pista. El ciclo termina cuando el usuario acierta.  

**Métodos usados:**  
- Generación de número aleatorio con `Random`  
- Bucle `do-while`  
- Condicionales  
- Contador de intentos  