# Ejercicio 6: Validación con Do-While

## Descripción Completa
Sistema robusto de validación de entrada que garantiza que el usuario ingrese exclusivamente números enteros positivos utilizando un bucle `do-while` con validación exhaustiva.

## Análisis Técnico

### Estrategia de Validación
- **Validación en Capas**: Múltiples checks en cada iteración
- **TryParse Seguro**: Evita excepciones por formato incorrecto
- **Forzado Controlado**: `numero = -1` para repetir el bucle

### Flujo de Validación
1. **Intento de Parseo**: Convierte entrada a número
2. **Validación de Formato**: Verifica si es numérico
3. **Validación de Rango**: Verifica si es positivo
4. **Retroalimentación**: Mensajes específicos por error

### Patrones de Validación
- **Bucle con Condición Compuesta**: Múltiples criterios de salida
- **Estado Forzado**: Asignación manual para control de flujo
- **Mensajes Contextuales**: Diferentes mensajes por tipo de error

