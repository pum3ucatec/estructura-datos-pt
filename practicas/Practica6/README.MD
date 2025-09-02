
# Programa de Gestión de Colas en C#

Este programa implementa una interfaz de consola para gestionar una estructura de datos de tipo cola (Queue) con operaciones básicas.

## Descripción General

El programa permite al usuario interactuar con una cola de caracteres mediante un menú de opciones. La cola se implementa usando la clase `MyQueue` que debe estar definida en el mismo namespace.

## Estructura del Programa

### Clase Principal `Program`

Contiene el método `Main` que gestiona la interfaz de usuario y las operaciones de la cola.

#### Método `Main(string[] args)`

Punto de entrada principal del programa.

##### Flujo de Ejecución:
1. **Solicita el tamaño** de la cola al usuario
2. **Valida el tamaño** (si es inválido, usa valor por defecto de 5)
3. **Crea una instancia** de `MyQueue` con el tamaño especificado
4. **Muestra un menú interactivo** con 9 opciones de operación
5. **Procesa las opciones** hasta que el usuario elija salir

#### Opciones del Menú:

| Opción | Descripción | Método MyQueue utilizado |
|--------|-------------|--------------------------|
| **1** | Mostrar estado de la cola | `Mostrar()` | 
| **2** | Insertar elemento (Enqueue) | `Enqueue(char)` |
| **3** | Eliminar elemento (Dequeue) | `Dequeue()` |
| **4** | Ver elemento al frente | `Peek()` |
| **5** | Ver elemento al final | `GetRear()` |
| **6** | Verificar si está vacía | `IsEmpty()` |
| **7** | Verificar si está llena | `IsFull()` |
| **8** | Buscar elemento | `Contains(char)` |
| **9** | Ver cantidad de elementos | `GetCount()` |
| **0** | Salir del programa | - |

### Características de Implementación

- **Manejo de errores**: Validación de entrada del usuario para números y caracteres
- **Interfaz amigable**: Mensajes descriptivos y formato claro
- **Operaciones completas**: Todas las operaciones básicas de una cola están implementadas
- **Persistencia**: La cola mantiene su estado durante toda la ejecución del programa

### Dependencias

- **System**: Para funciones de consola y entrada/salida
- **MyQueue**: Clase personalizada que debe implementar la estructura de datos cola

### Uso

1. Compilar el programa junto con la clase `MyQueue`
2. Ejecutar el programa
3. Seguir las instrucciones en pantalla
4. Seleccionar operaciones del menú según sea necesario

### Notas

- La cola trabaja exclusivamente con caracteres (`char`)
- Las posiciones en la cola se numeran desde 1 (para mejor comprensión del usuario)
- El programa incluye validación robusta de entradas del usuario

### El codigo esta escrito en PascalCase