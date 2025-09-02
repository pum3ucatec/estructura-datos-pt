# 📝 Descripción
Encuentra todos los subconjuntos únicos que suman un target específico usando backtracking. Explora recursivamente todas las combinaciones posibles, evitando duplicados y podando ramas cuando la suma actual excede el target.

## 🔧 Características
Encuentra todas las soluciones únicas

Evita duplicados mediante ordenamiento y skipping

Backtracking eficiente con pruning

## 🚀 Uso
```
int[] arr = {2, 3, 6, 7};
int target = 7;
List<List<int>> resultado = SubconjuntosSuma(arr, target);
// Resultado: [[7], [2,2,3]]
```
## 📊 Ejemplo
```
Input: [2,3,6,7], target=7

Árbol de backtracking:
- Incluir 2 → target=5
  - Incluir 2 → target=3
    - Incluir 2 → target=1 (rechazar)
    - Incluir 3 → target=0 (éxito: [2,2,3])
  - Incluir 3 → target=2 (continuar...)
- Incluir 3 → target=4 (continuar...)
- Incluir 6 → target=1 (rechazar)
- Incluir 7 → target=0 (éxito: [7])

Output: [[2,2,3], [7]]
```