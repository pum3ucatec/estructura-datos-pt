#  Explicación del Código: Ejercicios de Bucles en C#

Este programa contiene **10 ejercicios prácticos** que muestran cómo usar bucles y estructuras de control en C#.

El código principal (`Main`) llama a cada ejercicio en orden, mostrando el resultado en consola.

----------

##  1. Contar del 1 al 10

**Cómo funciona:**  
Se usa un bucle `for` que comienza en 1 y termina en 10, imprimiendo cada número.

`for (int i = 1; i <= 10; i++)
{
    Console.Write(i + " ");
}` 

 El bucle incrementa `i` en 1 en cada iteración hasta llegar a 10.

----------

##  2. Sumar números del 1 al N

**Cómo funciona:**  
El usuario ingresa un número `N`. Luego, con un `while`, se suman todos los números desde 1 hasta N.

`int n = int.Parse(Console.ReadLine()); int suma = 0, contador = 1; while (contador <= n)
{
    suma += contador;
    contador++;
}` 

 El `while` acumula la suma y detiene cuando `contador > N`.

----------

##  3. Tabla de multiplicar

**Cómo funciona:**  
Se pide un número al usuario y se usa un `for` para multiplicarlo por los valores del 1 al 10.

`for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}` 

 El bucle recorre de 1 a 10 y muestra cada producto.

----------

##  4. Menú interactivo (do-while)

**Cómo funciona:**  
Un menú con tres opciones se ejecuta dentro de un `do-while`, asegurando que se muestre al menos una vez.

-   Opción 1: muestra un saludo.
    
-   Opción 2: pide dos números y los suma.
    
-   Opción 3: sale del menú.
    

`do {
    Console.WriteLine("1. Saludar\n2. Sumar dos números\n3. Salir");
    opcion = int.Parse(Console.ReadLine()); switch (opcion)
    { case  1: Console.WriteLine("¡Hola!"); break; case  2: /* pide y suma números */  break; case  3: Console.WriteLine("Saliendo..."); break;
    }
} while (opcion != 3);` 

 El menú se repite hasta que se elige la opción **3**.

----------

##  5. Contador regresivo

**Cómo funciona:**  
Se inicia en 10 y se va restando 1 en cada iteración hasta llegar a 1.

`int contador = 10; while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}
Console.WriteLine("¡Despegue!");` 

 Cada ciclo imprime el valor y lo decrementa.

----------

##  6. Validar entrada positiva

**Cómo funciona:**  
Con un `do-while`, se pide un número hasta que el usuario ingrese uno mayor que 0.

`do {
    Console.Write("Ingrese un número positivo: ");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);` 

El bucle se repite mientras el valor ingresado no sea positivo.

----------

##  7. Suma de 5 números

**Cómo funciona:**  
Se piden 5 números usando un `for` y se van sumando en una variable acumuladora.

`int suma = 0; for (int i = 1; i <= 5; i++)
{ int numero = int.Parse(Console.ReadLine());
    suma += numero;
}` 

 El `for` se ejecuta exactamente 5 veces.

----------

##  8. Detectar número primo

**Cómo funciona:**  
Un número primo solo es divisible entre 1 y él mismo.  
Se comprueba dividiendo desde 2 hasta la raíz cuadrada del número.

`bool esPrimo = true; for (int i = 2; i <= Math.Sqrt(numero); i++)
{ if (numero % i == 0)
    {
        esPrimo = false; break;
    }
}` 

 Si encuentra un divisor, se marca como **no primo** y se interrumpe el bucle.

----------

##  9. Primeros 10 números pares

**Cómo funciona:**  
Se inicializan dos variables:

-   `contador` para llevar la cantidad de pares encontrados.
    
-   `numero` que se incrementa en cada ciclo.
    

`while (contador < 10)
{ if (numero % 2 == 0)
    {
        Console.Write(numero + " ");
        contador++;
    }
    numero++;
}` 

 El bucle termina cuando se muestran 10 números pares.

----------

##  10. Adivina el número (juego)

**Cómo funciona:**  
El programa genera un número aleatorio entre 1 y 50.  
El usuario intenta adivinarlo, y el programa indica si el intento es mayor o menor que el secreto.

`Random random = new Random(); int numeroSecreto = random.Next(1, 51); bool adivinado = false; while (!adivinado)
{
    intentoUsuario = int.Parse(Console.ReadLine()); if (intentoUsuario == numeroSecreto)
        adivinado = true; else  if (intentoUsuario < numeroSecreto)
        Console.WriteLine("El número es mayor."); else Console.WriteLine("El número es menor.");
}` 

 El ciclo `while` continúa hasta que el usuario acierta el número.
