# 📐 Estándares de Nomenclatura en C#

En C# la legibilidad y consistencia del código es clave. Por eso se siguen convenciones oficiales recomendadas por **Microsoft** y la comunidad .NET.

---

## 🔠 Estilos de nomenclatura más comunes

### 1. **PascalCase**
- ✅ Primera letra de cada palabra en mayúscula.  
- 📌 Usado en:
  - Clases  
  - Métodos  
  - Propiedades  
  - Interfaces  
- 🔹 Ejemplo:
  ```csharp
  public class Persona { }
  public void CalcularEdad() { }
  public string NombreCompleto { get; set; }
  public interface IRepositorio { }
  ```

---

### 2. **camelCase**
- ✅ Primera letra en minúscula y el resto con mayúscula en cada palabra.  
- 📌 Usado en:
  - Variables locales  
  - Parámetros de métodos  
  - Campos privados (a veces con `_` al inicio)  
- 🔹 Ejemplo:
  ```csharp
  int edadActual = 25;
  string nombreCompleto = "Juan Perez";

  public void CalcularPromedio(int totalNotas, int cantidadNotas) { }
  ```

---

### 3. **snake_case**
- ❌ No recomendado en C#, pero a veces usado en **bases de datos** o cuando se trabaja con **JSON**.  
- 🔹 Ejemplo:
  ```csharp
  // Ejemplo típico en JSON
  { "user_name": "jperez", "email_address": "jperez@mail.com" }
  ```

---

### 4. **kebab-case**
- ❌ No permitido en identificadores de C#.  
- Usado en **URLs**, **nombres de archivos estáticos**, o configuraciones en **front-end**.  
- 🔹 Ejemplo:
  ```
  /api/v1/usuario-detalle
  ```

---

## 📘 Guía práctica de C# (Microsoft .NET)

| Elemento          | Convención      | Ejemplo                  |
|-------------------|----------------|--------------------------|
| **Clases**        | PascalCase      | `public class Estudiante` |
| **Métodos**       | PascalCase      | `public void CalcularEdad()` |
| **Propiedades**   | PascalCase      | `public string Nombre { get; set; }` |
| **Interfaces**    | PascalCase + `I` | `public interface IRepository` |
| **Variables**     | camelCase       | `int edadActual = 20;` |
| **Parámetros**    | camelCase       | `CalcularPromedio(int totalNotas)` |
| **Campos privados** | `_camelCase` (opcional) | `private int _contador;` |
| **Constantes**    | PascalCase      | `public const double Pi = 3.1416;` |
| **Enums**         | PascalCase      | `enum Colores { Rojo, Verde, Azul }` |

---

## ⚡ Buenas prácticas

1. **Evita abreviaciones**:  
   ```csharp
   // ❌ Malo
   int cnt;  
   // ✅ Bueno
   int contador;
   ```

2. **Usa nombres descriptivos**:  
   ```csharp
   // ❌ Malo
   var x = GetData();  
   // ✅ Bueno
   var estudiantesActivos = ObtenerEstudiantesActivos();
   ```

3. **Interfaces siempre con "I" inicial**:  
   ```csharp
   public interface IRepository { }
   public class Repository : IRepository { }
   ```

4. **Constantes y campos readonly en PascalCase**:  
   ```csharp
   public const int MaximoIntentos = 3;
   public readonly string RutaArchivo;
   ```