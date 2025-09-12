# Resumen de Práctica de Recursividad en C#

| # | Ejercicio | Descripción breve | Funcionamiento | Ejemplo |
|---|-----------|-----------------|----------------|---------|
| 1 | Factorial | Calcula n! de un número entero positivo | Multiplica n por factorial de n-1 hasta 1 | n=5 → 120 |
| 2 | Suma N números | Suma de los primeros n números naturales | Suma n al resultado de Suma(n-1) hasta 0 | n=5 → 15 |
| 3 | Fibonacci | Muestra los primeros n términos de Fibonacci | Suma los dos anteriores recursivamente | n=5 → 0->1->1->2->3 |
| 4 | Potencia | Calcula base^exponente | Multiplica base por resultado de Potencia(base, exp-1) hasta exp=0 | 2^4 → 16 |
| 5 | Invertir cadena | Invierte una cadena de texto | Toma la primera letra y la mueve al final recursivamente | "hola" → "aloh" |
| 6 | Contar dígitos | Cuenta los dígitos de un número | Divide el número entre 10 sumando 1 recursivamente | 12345 → 5 |
| 7 | MCD | Calcula máximo común divisor usando Euclides | Llama MCD(a,b) hasta que b=0 | 12,18 → 6 |
| 8 | Suma arreglo | Suma todos los elementos de un arreglo | Suma el último elemento con la suma del resto recursivamente | [2,3,4] → 9 |
| 9 | Buscar elemento | Verifica si un número está en un arreglo | Compara último elemento con valor; si no coincide, recursión | [2,3,4], 3 → encontrado |
|10 | Decimal a binario | Convierte un número decimal a binario | Divide entre 2 recursivamente y concatena residuo | 10 → 1010 |
