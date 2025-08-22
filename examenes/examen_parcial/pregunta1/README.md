# Ejercicio 1 - Número Faltante en una Secuencia

📋 **Descripción**  
Este programa permite encontrar un número perdido dentro de una secuencia consecutiva de enteros que va del 1 al n.  
El código se ejecuta desde consola con el comando `dotnet run`.

---

🔍 **Problema Resuelto**  

Se tiene un arreglo que contiene números consecutivos del 1 al n, pero falta exactamente un valor.  
El programa identifica cuál es ese número ausente de forma eficiente.

---

🛠️ **Tecnologías Utilizadas**  

- Lenguaje: C#  
- Plataforma: .NET  
- Ejecución: Compatible con .NET Framework y .NET Core  

---

📁 **Estructura de la Solución**  
En lugar de usar sumas, este programa utiliza la operación **XOR**:  

1. Se calcula el XOR de todos los números que deberían estar en el rango `[1..n]`.  
2. Se calcula el XOR de los números realmente presentes en el arreglo.  
3. El resultado de hacer XOR entre ambos es el número faltante.  

Fórmula general:  
faltante = (1 ^ 2 ^ ... ^ n) ^ (a1 ^ a2 ^ ... ^ an-1)

---

📊 **Ejemplo de Ejecución**

Entrada: 1, 2, 4, 5, 6
Salida: El número que falta es: 3

---

🎯 **Características**

- Funciona para secuencias de cualquier tamaño.  
- Detecta el faltante en cualquier posición de la lista.  
- Método eficiente sin necesidad de ordenar ni sumar valores grandes.  

---

📝 **Convenciones**

- Métodos con `PascalCase`.  
- Variables con `camelCase`.  
