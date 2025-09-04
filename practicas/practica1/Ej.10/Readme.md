# Ejercicio 10: Juego de Adivinanza

## Descripción Completa
Juego interactivo donde el usuario debe adivinar un número aleatorio entre 1-100 recibiendo pistas de "muy alto" o "muy bajo" hasta acertar.

## Análisis de Juego

### Mecánica Principal
- **Número Aleatorio**: Generado al inicio del juego
- **Bucle Infinito**: `while (true)` hasta adivinanza correcta
- **Pistas Contextuales**: Guía al jugador hacia la solución
- **Contador de Intentos**: Mide el desempeño del jugador

### Generación Aleatoria
- **Rango**: 1-100 inclusive (`Next(1, 101)`)
- **Distribución**: Uniforme - todos los números igualmente probables
- **Semilla**: Basada en reloj del sistema (diferente cada ejecución)

### Estrategia de Búsqueda Óptima
**Búsqueda Binaria Ideal:**
- **Mejor Caso**: 1 intento (suerte)
- **Peor Caso**: 100 intentos (búsqueda lineal)
- **Estrategia Óptima**: Búsqueda binaria (máximo 7 intentos)
