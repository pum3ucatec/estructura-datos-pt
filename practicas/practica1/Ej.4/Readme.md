# Ejercicio 4: Menú de Operaciones Aritméticas

## Descripción Completa
Aplicación de consola interactiva que presenta un menú circular con operaciones aritméticas básicas utilizando un bucle `do-while` para garantizar al menos una ejecución.

## Análisis Arquitectónico

### Patrón de Diseño
- **Bucle Controlado por Menú**: Estructura clásica de aplicaciones consola
- **Flujo Circular**: Siempre regresa al menú principal excepto al salir
- **Modularidad Implícita**: Cada operación en caso switch diferente

### Estructura de Control
- **do-while**: Garantiza que el menú se muestre al menos una vez
- **switch-case**: Manejo elegante de múltiples opciones
- **Condición de Salida**: `opcion != 4` - Rompe el bucle

### Aspectos de Experiencia de Usuario
- **Interfaz Consistente**: Mismo formato para todas las operaciones
- **Retroalimentación Inmediata**: Resultados mostrados instantly
- **Manejo de Errores**: Opción default para entradas inválidas

### Vulnerabilidades y Mejoras
**Problemas de Seguridad:**
- `int.Parse()` sin validación - causa excepciones
- Variables duplicadas (num1, num2, num3, etc.)
- No manejo de overflow aritmético

