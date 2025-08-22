# **PROYECTO: ENCONTRAR EL NÚMERO FALTANTE EN UN ARREGLO**
- Este programa en **C#** resuelve el problema de encontrar el número que falta en un arreglo con valores del `1` al `n` que se nos pido a nosotros los estudiantes por resolver de manera individual.  
***
- Ejemplo:  
  Entrada → `[1, 2, 4, 5, 6]`  
  Salida → `Falta el número: 3`  
***
## ***Explicación de lo Utilizado***
1. *Convenciones de Código:*
   - Se utilizó **PascalCase** para los nombres de clases y métodos:
     - `NumeroFaltante`
     - `EncontrarFaltante`
   - Se utilizó **camelCase** para variables locales:
     - `sumaEsperada`
     - `sumaReal`
   - Se aprovechó la librería **LINQ** (`.Sum()`) para obtener rápidamente la suma de los elementos del arreglo.  

2. *Algoritmo Implementado:*
   - Se usa la fórmula de la suma de los primeros `n` números naturales:  
     \[
     suma = \frac{n \cdot (n+1)}{2}
     \]
   - Se resta la suma real del arreglo a la suma esperada.
   - El resultado es el número faltante .  

***

## ***Ejemplo de Funcionamiento***
- Arreglo: `[1, 2, 4, 5, 6]`  
- `n = 6`  
- `sumaEsperada = 21`  
- `sumaReal = 18`  
- Resultado → **Falta el número 3**   

***

## ***Comandos para Ejecutar***
1. Verificar que esté instalado **.NET SDK**:
   ```bash
   dotnet --version

2. Posteriormente agrega el comando(el cual sirve para crear una plantilla básica listo para que trabajemos en nuestro proyecto):
    ```bash
   dotnet new console

3. Por ultimo ejecutamos nuestro programa:
    ```bash
   dotnet run
