# 📝 DOCUMENTACIÓN TÉCNICA - SOLUCIONES DE ALGORITMOS

## 🔢 PROBLEMA 1: ENCONTRAR EL NÚMERO FALTANTE

### 📋 DESCRIPCIÓN DEL PROBLEMA
**Problema:** Dado un array de números enteros que contiene todos los números del 1 al `n` excepto uno, encontrar el número que falta en la secuencia.

**Ejemplo:**  
`Input: [1, 2, 4, 5, 6]` → `Output: 3`

---

### 🧮 FUNDAMENTACIÓN MATEMÁTICA
El algoritmo se basa en la **fórmula de Gauss** para la suma de una serie aritmética:


---

### 📝 IMPLEMENTACIÓN DEL ALGORITMO

```csharp
public static int EncontrarNumeroFaltante(int[] arr)
{
    // Paso 1: Calcular n (tamaño completo de la secuencia)
    int n = arr.Length + 1;
    
    // Paso 2: Calcular suma teórica (1 + 2 + ... + n)
    int sumaTotal = n * (n + 1) / 2;
    
    // Paso 3: Calcular suma actual del array
    int sumaActual = arr.Sum();
    
    // Paso 4: La diferencia es el número faltante
    return sumaTotal - sumaActual;
}

*Problema numero 2*
Input: 
[[1, 2, 3],
 [4, 5, 6], 
 [7, 8, 9]]

Output: [1, 2, 3, 6, 9, 8, 7, 4, 5]

int top = 0;           // ← Borde superior
int bottom = rows - 1;  // ← Borde inferior  
int left = 0;          // ← Borde izquierdo
int right = cols - 1;   // ← Borde derecho
