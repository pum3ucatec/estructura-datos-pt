# PRÁCTICA 10: RECURSIVIDAD

### Estudiantes:
- José Gabriel Loayza Barrera
- Jorge Sebastian Torrico Pinto 

## Ejercicio 2. Suma de los primeros N números naturales
Pregunta:
Calcular la suma de los primeros n números naturales.

```csharp
public static int SumaIterativa(int n) 
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}

```
**Características:**
- Utiliza un bucle for para recorrer desde 1 hasta n.

- Va acumulando el valor en la variable suma.

- Es un proceso iterativo, ya que repite instrucciones hasta que la condición del ciclo deja de cumplirse.

- No depende de llamadas al mismo método, sino de un contador dentro del ciclo.

#  Código con recursividad (suma recursiva)

```csharp
using System;

class Program
{
    // Método recursivo para sumar los primeros N números naturales
    public static int SumaRecursiva(int n)
    {
        // Caso base
        if (n == 0)
            return 0;

        // Caso recursivo
        return n + SumaRecursiva(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = SumaRecursiva(n);
        Console.WriteLine($"La suma de los primeros {n} números naturales es: {resultado}");
    }
}

```
### Cambios principales:
- Eliminación del bucle for:
- La lógica del ciclo se reemplazó por llamadas recursivas a la misma función.

### Definición de un caso base:

```csharp
if (n == 0)
    return 0;
    
```
Es la condición de parada de la recursividad.

Cuando n llega a 0, la función deja de llamarse a sí misma y retorna el resultado acumulado.

### Caso recursivo:

```csharp
return n + SumaRecursiva(n - 1);
```
- En lugar de sumar en una variable con un bucle, cada llamada devuelve la suma de n más la suma de los números anteriores (n-1).

- El método se invoca a sí mismo hasta llegar al caso base.

### Uso del programa:

- Se solicita un número al usuario.

- Se llama al método recursivo con ese valor.

- Se imprime el resultado.

## Conclusión
**Iterativo:** Repite un bloque de instrucciones mediante ciclos (for, while).

**Recursivo:** Resuelve el problema dividiéndolo en subproblemas más pequeños, llamándose a sí mismo.

En este caso, la suma de los primeros n números naturales se logra tanto con iteración como con recursión, pero la recursiva es más elegante y matemática, ya que refleja la definición de la suma de manera natural:

### 𝑆(𝑛)=𝑛+𝑆(𝑛−1),𝑆(0)=0
