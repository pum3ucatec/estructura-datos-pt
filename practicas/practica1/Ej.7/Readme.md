# Ejercicio 7: Suma de 7 Valores

## Descripción Completa
Calculadora acumulativa que solicita exactamente 7 valores numéricos al usuario y muestra la suma total. Ejemplo de bucle con entrada interactiva.

## Análisis Técnico

### Estructura de Acumulación
- **Contador Fijo**: 7 iteraciones exactas
- **Acumulador**: Variable `suma` que acumula valores
- **Entrada Secuencial**: Valores solicitados en orden

### Características de Entrada
- **Numeración Amigable**: "valor 1", "valor 2", etc.
- **Interfaz Conversacional**: Dialogo interactivo con usuario
- **Progreso Visible**: Usuario sabe cuántos valores faltan

### Consideraciones de Robustez
**Problemas Actuales:**
- `int.Parse()` sin validación - vulnerable a excepciones
- No manejo de valores decimales
- Sin verificación de overflow

