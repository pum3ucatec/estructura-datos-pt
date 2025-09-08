# Ejercicio 2 - Recorrido en Espiral de una Matriz

📋 **Descripción**  
Este programa recorre e imprime los elementos de una matriz en forma de espiral.  
Primero pide al usuario el número de filas y columnas, luego los elementos, y finalmente muestra el recorrido en espiral.  
Se ejecuta en consola usando `dotnet run`.

---

🔍 **Problema Resuelto**  
Dada una matriz de tamaño `m x n`, el algoritmo devuelve los elementos en orden espiral, empezando desde la esquina superior izquierda y avanzando en sentido horario.

---

🛠️ **Tecnologías Utilizadas**  
- Lenguaje: **C#**  
- Plataforma: **.NET**  
- Ejecución: Compatible con .NET Framework y .NET Core  

---

📁 **Lógica de la Solución**  
El algoritmo controla 4 límites:  
- `arriba` (fila inicial)  
- `abajo` (fila final)  
- `izquierda` (columna inicial)  
- `derecha` (columna final)  

El recorrido sigue estos pasos:  
1. Moverse de izquierda a derecha.  
2. Bajar por la última columna.  
3. Moverse de derecha a izquierda.  
4. Subir por la primera columna.  

Este ciclo se repite mientras queden filas o columnas disponibles.  

---

📊 **Ejemplo de Ejecución**
Entrada:
Matriz 3x3 =
1 2 3
4 5 6
7 8 9

Salida:
Elementos en espiral: [1, 2, 3, 6, 9, 8, 7, 4, 5]

---

🎯 **Características**
- Soporta matrices cuadradas y rectangulares.  
- Recorre todos los elementos sin omitir ninguno.  
- Imprime los valores en el orden correcto de espiral.  

---

📝 **Convenciones**
- Métodos: `PascalCase`  
- Variables: `camelCase`  
