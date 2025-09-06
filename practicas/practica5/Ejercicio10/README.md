# 📌 Ejercicio 10: Suma de Subconjuntos (Backtracking)

## 📖 Enunciado
Dado un **arreglo de enteros** y un número `target`, encuentra todos los subconjuntos cuya suma sea igual al `target`.

---

## ✨ Ejemplo
### Entrada:
nums = [2, 3, 6, 7]
target = 7

shell
Copiar código

### Salida:
[7]
[2, 2, 3]

csharp
Copiar código

---

## 📌 Código en C#
```csharp
static void Backtracking(int[] nums, int target, int inicio, List<int> actual, List<List<int>> resultados)
{
    if (target == 0)
    {
        resultados.Add(new List<int>(actual));
        return;
    }

    for (int i = inicio; i < nums.Length; i++)
    {
        if (nums[i] <= target)
        {
            actual.Add(nums[i]);                  
            Backtracking(nums, target - nums[i], i, actual, resultados); 
            actual.RemoveAt(actual.Count - 1);    
        }
    }
}
🛠️ Explicación
Backtracking: probamos incluir o no cada número.

Cuando la suma llega a 0, hemos encontrado un subconjunto válido.

Usamos inicio para permitir reutilizar el mismo número varias veces.

Al regresar (backtrack), quitamos el último número y seguimos buscando otros subconjuntos.

✅ Ejemplo de ejecución
yaml
Copiar código
Arreglo: [2, 3, 6, 7]
Target: 7

Subconjuntos que suman al target:
[2, 2, 3]
[7]