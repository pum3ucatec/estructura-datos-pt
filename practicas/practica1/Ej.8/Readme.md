# Ejercicio 8: Verificación de Números Primos

## Descripción Completa
Algoritmo optimizado para determinar si un número es primo, implementando múltiples optimizaciones matemáticas para reducir las comprobaciones necesarias.

## Análisis Matemático

### Definición de Primalidad
Un número primo es divisible únicamente por 1 y por sí mismo. Este algoritmo implementa varias optimizaciones:

### Optimizaciones Implementadas
1. **Exclusión de ≤1**: 0, 1 y negativos no son primos
2. **Caso Especial 2 y 3**: Únicos primos pares y el 3
3. **Exclusión de Pares**: Ningún par >2 es primo
4. **Límite Cuadrático**: Solo verificar hasta √n
5. **Solo Impares**: Saltar números pares en verificación

### Complejidad Computacional
- **Peor Caso**: O(√n) - Para números primos grandes
- **Mejor Caso**: O(1) - Para números pares o pequeños
- **Caso Promedio**: O(√n) - Para números compuestos

### Ejemplo de Eficiencia
Para verificar si 1,000,000 es primo:
- **Método Naive**: 1,000,000 verificaciones
- **Este Método**: ≈ 500 verificaciones (solo impares hasta 1000)

### Limitaciones y Mejoras
**Límites Actuales:**
- Máximo: int.MaxValue (2,147,483,647)
- No maneja números muy grandes (BigInteger)

**Para Números Más Grandes:**
```csharp
// Usar long para mayor rango
static bool EsPrimo(long n)
{
    // misma lógica pero con long
}