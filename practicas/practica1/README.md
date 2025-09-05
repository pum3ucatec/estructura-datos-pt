# Practica 1
  
La practica 1 es para poder practicar **bucles, condicionales, validaciones e interacción con el usuario**.

---

##  Índice
1. [Contador del 1 al 10](#-1-contador-del-1-al-10)
2. [Suma de números del 1 al N](#-2-suma-de-números-del-1-al-n)
3. [Tabla de multiplicar](#-3-tabla-de-multiplicar)
4. [Menú con do-while](#-4-menú-con-do-while)
5. [Contador regresivo](#-5-contador-regresivo)
6. [Validar número positivo](#-6-validar-número-positivo)
7. [Suma de 5 números](#-7-suma-de-5-números)
8. [Detectar si un número es primo](#-8-detectar-si-un-número-es-primo)
9. [Primeros 10 números pares](#-9-primeros-10-números-pares)
10. [Juego: Adivina el número](#-10-juego-adivina-el-número)


---

##  1. Contador del 1 al 10
###  Descripción
Este programa imprime los números del **1 al 10** en consola usando un bucle `for`.

###  Código
```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

```
### Explicación:

Se declara un bucle for que empieza en 1 y termina en 10.

En cada iteración, se imprime el valor de i.

i aumenta automáticamente en 1 cada ciclo. 

## 2. Suma de números del 1 al N   
### Descripción

El usuario ingresa un número N y el programa calcula la suma de todos los números desde 1 hasta N.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número N: ");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;

        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }

        Console.WriteLine($"La suma de 1 a {n} es: {suma}");
    }
}
```

### Explicación

Se pide al usuario un número n.

Se inicializa una variable suma en 0.

Un bucle for suma todos los números desde 1 hasta n.

Se muestra el resultado en pantalla.

## 3. Tabla de multiplicar
### Descripción

Muestra la tabla de multiplicar de un número ingresado por el usuario.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
```

### Explicación

Se pide un número al usuario.

Con un bucle for, se multiplica el número por i desde 1 hasta 10.

Se imprime cada resultado como una tabla de multiplicar.

## 4. Menú con do-while
### Descripción

Muestra un menú interactivo que se repite hasta que el usuario elija salir.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Salir");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola!");
                    break;
                case 2:
                    Console.Write("Ingrese A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese B: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La suma es: {a + b}");
                    break;
            }
        } while (opcion != 3);
    }
}
```

### Explicación

Se muestra un menú con 3 opciones.

El usuario elige una opción.

Con switch, se ejecuta la acción correspondiente:

Opción 1 → Saludo.

Opción 2 → Pide dos números y muestra la suma.

Opción 3 → Finaliza el programa.

El menú se repite hasta que el usuario elige salir (opcion == 3).

## 5. Contador regresivo
### Descripción

Imprime los números del 10 al 1 en orden descendente.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        int contador = 10;
        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--;
        }
    }
}
```

### Explicación

Se inicializa un contador en 10.

Mientras el contador sea mayor o igual a 1, se imprime.

En cada ciclo, el contador disminuye en 1.

## 6. Validar número positivo
### Descripción

El programa pide al usuario ingresar un número positivo.
Si se ingresa un número negativo o cero, vuelve a pedirlo.

## Código
```csharp
using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Ingrese un número positivo: ");
            numero = int.Parse(Console.ReadLine());
        } while (numero <= 0);

        Console.WriteLine($"Número válido: {numero}");
    }
}
```

### Explicación

Se declara una variable numero.

Con un ciclo do-while, se pide un número al usuario.

El ciclo se repite mientras el número sea menor o igual a 0.

Al final, se imprime el número válido.

##  7. Suma de 5 números
### Descripción

Solicita al usuario ingresar 5 números y calcula la suma total.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"La suma total es: {suma}");
    }
}
```

### Explicación

Se inicializa suma en 0.

Se repite 5 veces con un for.

En cada iteración, el usuario ingresa un número que se acumula en suma.

Al final, se imprime el resultado.

## 8. Detectar si un número es primo
### Descripción

Verifica si un número ingresado por el usuario es primo.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());
        bool esPrimo = true;

        if (numero <= 1) esPrimo = false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }
}
```

### Explicación

Se pide un número al usuario.

Si es menor o igual a 1, no es primo.

Se divide entre todos los números desde 2 hasta la raíz cuadrada.

Si es divisible por alguno, no es primo.

Si no, se considera primo.

## 9. Primeros 10 números pares
### Descripción

Imprime los primeros 10 números pares.

### Código
```csharp
using System;

class Program
{
    static void Main()
    {
        int numero = 2;
        int contador = 0;

        while (contador < 10)
        {
            Console.WriteLine(numero);
            numero += 2;
            contador++;
        }
    }
}
```

### Explicación

Se inicializa numero en 2 (el primer par).

Se usa un contador que se incrementa hasta 10.

En cada iteración, se imprime el número actual.

Luego se suma 2 para obtener el siguiente número par.

## 10. Juego: Adivina el número
### Descripción

La computadora genera un número aleatorio entre 1 y 50.
El usuario debe adivinarlo con pistas de "mayor" o "menor".

## Código
```csharp
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 51);
        int intento;

        do
        {
            Console.Write("Adivina el número (1-50): ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroAleatorio) Console.WriteLine("El número es mayor.");
            else if (intento > numeroAleatorio) Console.WriteLine("El número es menor.");

        } while (intento != numeroAleatorio);

        Console.WriteLine("¡Felicidades, adivinaste!");
    }
}
```

### Explicación

Se genera un número aleatorio entre 1 y 50.

El usuario ingresa intentos hasta adivinarlo.

Si el intento es menor, se muestra "El número es mayor".

Si el intento es mayor, se muestra "El número es menor".

El ciclo termina cuando se acierta el número.


## Cami