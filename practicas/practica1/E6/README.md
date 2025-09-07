# Ejercicio 6 - Validar Número Positivo

## Descripción
Este programa solicita al usuario que ingrese un número y valida que sea **positivo**.  
Si el valor ingresado es **menor o igual a 0**, vuelve a pedirlo hasta que el usuario introduzca un número válido.

---

## Ejemplo de Ejecución
Ingrese un número positivo: -4
Ingrese un número positivo: 0
Ingrese un número positivo: 7
Número válido ingresado: 7

---

## Funcionamiento
- Se utiliza un **bucle do-while** para asegurar que al menos una vez se pedirá el número.  
- El programa seguirá repitiendo la solicitud hasta que se ingrese un número mayor a **0**.  
- Se separa la lógica en el método `PedirNumeroPositivo` para mayor claridad.  