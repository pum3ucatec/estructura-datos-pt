#  Potencia de una numero con Recursividad

## ¿Qué es una potencia?
La **Potencia** de un número es como decir:  
“Toma ese número y multiplícalo por el mismo numero las veces que se le requira”.

Por ejemplo:
- `3^3 = 3 × 3 × 3 = 27`
- `5^2 = 5 × 5 = 5`

El signo `^` significa **potencia**.

## Caso base y caso recursivo

### Caso base
El caso más sencillo que sabemos resolver sin ayuda.  
La potencia de:
- `1^n = 1`

Es como decir: “cuando llego al final de la escalera, paro”.

---

### Caso recursivo
Es cuando decimos:  
“Si quiero calcular `5^5`, primero calculo `5^4`, y se va resolviendo hasta llegar a 1/0”.

Así funciona:

- 5^5 = 5 × 5^4
- 5^4 = 4 × 5^3
- 5^3 = 3 × 5^2
- 5^2 = 2 × 5^1 
- 5^1 = 5 x 1(caso base, aquí paro)