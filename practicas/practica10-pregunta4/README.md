#  Factorial con Recursividad explicado para niños

## ¿Qué es el factorial?
El **factorial** de un número es como decir:  
“Toma ese número y multiplícalo por todos los que están antes de él”.

Por ejemplo:
- `3! = 3 × 2 × 1 = 6`
- `5! = 5 × 4 × 3 × 2 × 1 = 120`

El signo `!` significa **factorial**.

## Caso base y caso recursivo

### Caso base
El caso más sencillo que sabemos resolver sin ayuda.  
En factorial:
- `0! = 1`
- `1! = 1`

Es como decir: “cuando llego al final de la escalera, paro”.

---

### Caso recursivo
Es cuando decimos:  
“Si quiero calcular `5!`, primero calculo `4!`, y luego multiplico por 5”.

Así funciona:

- 5! = 5 × 4!
- 4! = 4 × 3!
- 3! = 3 × 2!
- 2! = 2 × 1!
- 1! = 1 👈 (caso base, aquí paro)