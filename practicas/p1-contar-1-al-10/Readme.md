#  Práctica de Bucles en C#

Este proyecto es un ejemplo sencillo en C# que muestra cómo utilizar un **bucle `for`** para imprimir números en la consola.

---

##  Estructura del código

```
using System;

namespace PracticaBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

```

# Explicación paso a paso
1. **Directiva using System;**

Permite usar clases de la librería base de C#.
En este caso, usamos Console.WriteLine para imprimir en pantalla.

2. **Namespace = 
namespace PracticaBucles**


Define un espacio de nombres llamado PracticaBucles.

Sirve para organizar el código y evitar conflictos con otros proyectos o librerías.

3. **Clase Program
class Program**


Es la clase principal que contiene el punto de entrada de la aplicación.

4. **Método Main
static void Main(string[] args)**


Es el punto de inicio del programa en C#.

Todo el código dentro de este método se ejecuta cuando se corre la aplicación.

5. **Bucle for**

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


int i = 1; → Inicializa la variable i en 1.

i <= 10; → Condición: el bucle sigue mientras i sea menor o igual a 10.

i++ → Incrementa i en 1 después de cada iteración.

Console.WriteLine(i); → Imprime el valor actual de i.

# Resultado en consola:
````
1
2
3
4
5
6
7
8
9
10
