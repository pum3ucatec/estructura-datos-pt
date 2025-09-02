# 📝 Descripción
Calcula para cada posición el producto de todos los elementos excepto el de esa posición, sin usar división. Utiliza dos pasadas: una de izquierda a derecha calculando productos acumulativos izquierdos, y otra de derecha a izquierda multiplicando por productos acumulativos derechos.

## 🔧 Características
Evita el uso de división (útil cuando hay ceros)

Solución óptima con dos pasadas

Maneja arreglos con ceros correctamente

## 🚀 Uso
```
int[] arr = {1, 2, 3, 4};
int[] resultado = ProductoExceptoIndice(arr);
// Resultado: [24, 12, 8, 6]
```
# 📊 Ejemplo
```
Input: [1, 2, 3, 4]

Pasada izquierda: 
  [1, 1, 2, 6] (productos acumulativos izquierdos)

Pasada derecha:
  [24, 12, 8, 6] (multiplicando por productos derechos)

Output: [24, 12, 8, 6]
```