# Documentación: Ejercicios de Arreglos y Bucles en C#

Se presentan los 10 programas en C# que trabajan con **arreglos, ciclos y estructuras básicas de control**.  
Cada sección explica brevemente el funcionamiento de cada código.

---

# Ejercicio 1: Imprimir números del 1 al 10
```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

## Explicación:
El programa recorre un bucle for desde 1 hasta 10, imprimiendo los números en orden.

# Ejercicio 2: Suma de números del 1 al N
```csharp 
int suma = 0;
int i = 1;
while (i <= N)
{
    suma += i;
    i++;
}
```


## Explicación:
Solicita un número N y calcula la suma de todos los números desde 1 hasta N usando un ciclo while.

# Ejercicio 3: Tabla de multiplicar
``` csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}
```

## Explicación:
El usuario ingresa un número y se genera su tabla de multiplicar del 1 al 10.

# Ejercicio 4: Menú interactivo con opciones
```csharp
do
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Sumar dos números");
    Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: Console.WriteLine("¡Hola! "); break;
        case 2: Console.WriteLine($"La suma es: {a + b}"); break;
        case 3: Console.WriteLine("Saliendo..."); break;
        default: Console.WriteLine("Opción no válida"); break;
    }
} while (opcion != 3);
```

## Explicación:
El programa muestra un menú con 3 opciones: saludar, sumar dos números o salir.
Se repite hasta que el usuario elige la opción 3.



# Ejercicio 6: Validar número positivo
```csharp
int numero;
do
{
    Console.Write("Introduce un número positivo: ");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);
```

## Explicación:
El ciclo do-while obliga al usuario a ingresar un número positivo.
Si escribe un número negativo o cero, vuelve a pedirlo hasta que sea válido.

# Ejercicio 7: Sumar 5 números ingresados por el usuario
```csharp
int suma = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingresa el número {i}: ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
}
```


## Explicación:
El programa solicita 5 números al usuario y acumula la suma de todos ellos.
Al final muestra el total.


# Ejercicio 9: Primeros 10 números pares
```csharp 
int contador = 0;
int numero = 2;
while (contador < 10)
{
    Console.WriteLine(numero);
    numero += 2;
    contador++;
}
```

## Explicación:
Imprime los primeros 10 números pares, iniciando desde 2.
Se controla con un contador que incrementa en cada iteración.

# Ejercicio 10: Juego de adivinar número
```csharp
Random random = new Random();
int secreto = random.Next(1, 51);
int intento;
do
{
    Console.Write("Adivina el número (1-50): ");
    intento = int.Parse(Console.ReadLine());

    if (intento < secreto)
        Console.WriteLine("El número secreto es mayor.");
    else if (intento > secreto)
        Console.WriteLine("El número secreto es menor.");

} while (intento != secreto);
```

## Explicación:
El programa genera un número secreto aleatorio entre 1 y 50.
El usuario debe adivinarlo, recibiendo pistas ("mayor" o "menor") hasta acertar.