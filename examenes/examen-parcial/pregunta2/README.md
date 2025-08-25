# Pregunta 1 - Encontrar el Número que Falta

## Descripción

En un arreglo de números consecutivos del `1` al `n`, falta un número.\
El objetivo es **detectar cuál es el número faltante**.

## Lógica

1.  Se calcula la **suma esperada** de los números del `1` al `n` usando
    la fórmula: 
                (n \* (n + 1)) / 2

donde `n` es el último número esperado en la secuencia./

2. Se calcula la **suma real** de todos los elementos presentes en el arreglo./

3. El número faltante es la diferencia entre la suma esperada y la suma real.

## 🔹 Ejecución

    Arreglo: [1, 2, 4, 5, 6]
    Suma esperada (1..6) = 21
    Suma real = 18
    Número faltante = 3
