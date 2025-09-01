Muy bien, Estefanía. Como eres principiante, te voy a dar cada ejercicio en **C#** con una explicación sencilla y el código listo para que lo entiendas y practiques.

---

### 1. Contar del 1 al 10 (for)

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```

👉 El `for` va aumentando `i` desde 1 hasta 10.

---

### 2. Sumar números del 1 al N (while)

```csharp
Console.Write("Ingresa un número N: ");
int N = int.Parse(Console.ReadLine());

int suma = 0;
int i = 1;

while (i <= N)
{
    suma += i;
    i++;
}

Console.WriteLine("La suma es: " + suma);
```

👉 El `while` repite mientras `i <= N`.

---

### 3. Tablas de multiplicar (for)

```csharp
Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " x " + i + " = " + (num * i));
}
```

👉 Multiplica tu número por cada valor del 1 al 10.

---

### 4. Menú con do-while

```csharp
int opcion;

do
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Sumar dos números");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("¡Hola!");
    }
    else if (opcion == 2)
    {
        Console.Write("Número 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Número 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("La suma es: " + (a + b));
    }

} while (opcion != 3);
Console.WriteLine("chauuuu");
```

👉 El `do-while` hace que el menú se repita hasta que elijas 3.

---

### 5. Contador regresivo (while)

```csharp
int i = 10;
while (i >= 0)
{
    Console.WriteLine(i);
    i--;
}
```

👉 Va de 10 hacia 1 restando.

---

### 6. Validar entrada con do-while

```csharp
int numero;

do
{
    Console.Write("Ingresa un número positivo: ");
    numero = int.Parse(Console.ReadLine());

} while (numero <= 0);

Console.WriteLine("Ingresaste: " + numero);
```

👉 Se repite hasta que pongas un número positivo.

---

### 7. Suma de 5 números

```csharp
int suma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Ingresa el número " + i + ": ");
    int num = int.Parse(Console.ReadLine());
    suma += num;
}

Console.WriteLine("La suma de los 5 números es: " + suma);
```

👉 Pide 5 números y los suma.

---

### 8. Detectar número primo

```csharp
Console.Write("Ingresa un número: ");
int num = int.Parse(Console.ReadLine());

bool esPrimo = true;

for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        esPrimo = false;
        break;
    }
}

if (esPrimo && num > 1)
    Console.WriteLine(num + " es primo");
else
    Console.WriteLine(num + " NO es primo");
```

👉 Un número es primo si solo se divide entre 1 y él mismo.

---

### 9. Primeros 10 números pares

```csharp
int i = 1;
int cont = 0;

while (cont < 10)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        cont++;
    }
    i++;
}
```

👉 Muestra los primeros 10 pares.

---

### 10. Adivina el número

```csharp
Random rnd = new Random();
int secreto = rnd.Next(1, 51); // número entre 1 y 50
int intento;

do
{
    Console.Write("Adivina el número (1-50): ");
    intento = int.Parse(Console.ReadLine());

    if (intento < secreto)
        Console.WriteLine("Es mayor");
    else if (intento > secreto)
        Console.WriteLine("Es menor");

} while (intento != secreto);

Console.WriteLine("¡Correcto! El número era " + secreto);
```

👉 El sistema genera un número aleatorio y tú tienes que adivinarlo.

---

¿Quieres que te arme todos estos ejercicios dentro de un **solo proyecto en C# con menú** para que elijas cuál ejecutar, o prefieres que queden separados cada uno en su propio programita?
