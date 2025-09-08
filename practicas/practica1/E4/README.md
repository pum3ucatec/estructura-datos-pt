# Ejercicio 4 - Menú con do-while en C#

Este programa crea un pequeño **menú interactivo** que se repite hasta que el usuario elige la opción de salir.  
El menú ofrece tres opciones:  

1. **Saludar**  
2. **Sumar dos números**  
3. **Salir del programa**  


```csharp
using System;
class ejercicio_4
{
    static void Main()
    {
        int op; // op = opción 
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Salir");

            Console.Write("Seleccione una opcion: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Holis");
            }
            else if (op == 2)
            {
                Console.WriteLine("1er numero:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("2do numero:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma es: " + (x + y));
            }
            else if (op != 3)
            {
                Console.WriteLine("Opción no válida, intente de nuevo");
            }

        } while (op != 3);

        Console.WriteLine("bye");
    }
}
Explicación
Se declara la variable op para guardar la opción ingresada por el usuario.

Con un bucle do-while, se muestra el menú en pantalla.

Dependiendo de la opción:

Opción 1: Muestra un saludo.

Opción 2: Pide dos números y muestra su suma.

Opción 3: Finaliza el programa.

Si se ingresa otra opción, aparece un mensaje de error.

El menú se repite hasta que el usuario elige 3 (Salir).

Ejemplo de ejecución
markdown
Copiar código
Menu
1. Saludar
2. Sumar
3. Salir
Seleccione una opcion: 1
Hola

Menu
1. Saludar
2. Sumar
3. Salir
Seleccione una opcion: 2
1er numero:
5
2do numero:
3
La suma es: 8

Menu
1. Saludar
2. Sumar
3. Salir
Seleccione una opcion: 3
adios