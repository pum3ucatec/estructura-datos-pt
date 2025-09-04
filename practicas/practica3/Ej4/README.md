# Codigo En PascalCase En CSharp

Este Programa Solicita Al Usuario Ingresar Varias Calificaciones, Calcula La Suma De Todas Ellas Y Finalmente Obtiene El Promedio. Todo Se Muestra En Consola.

## Explicacion Del Codigo

### 1. **Declaracion Del Arreglo**
   ```csharp
   double[] Calificaciones = new double[5];
   ```
* Se declara Un arreglo LLamado `Calificaciones` Para Almacenar 5 Valores Tipo `double`.
### 2. **Variables Acumuladas**
```Csharp
double Suma = 0;
```
* Se Utiliza La Variable `Suma` Para Acumular El Total de las Calificaciones.

### 3. **Bucle `For` Con Lectura De Datos**
```Csharp
for (int I = 0; I < Calificaciones.Length; I++)
{
    Console.Write("Ingresa La Calificacion #" + (I + 1) + ": ");
    Calificaciones[I] = Convert.ToDouble(Console.ReadLine());
    Suma += Calificaciones[I];
}
```
* El Usuario Ingresa Cada Calificacion.
* En Cada Iteracion, Se guarda El Valor En el Arreglo Y Se Suma Al Acumular `Suma`.
### 4. Calculo Del Promedio
```Csharp
double Promedio = Suma / Calificaciones.Length;
```
* Se Calcula El Promedio Dividiendo La `Suma` Entre La Cantidad Total De Elementos.

### 5. Impresion Del Resultado
```Csharp
Console.WriteLine("El Promedio De Las Calificaciones Es: " + Promedio);
```
* Se Muestra El Promedio Final En Consola.

### Ejemplo De Ejecucion:
```Csharp
Ingresa La Calificacion #1: 80
Ingresa La Calificacion #2: 70
Ingresa La Calificacion #3: 90
Ingresa La Calificacion #4: 60
Ingresa La Calificacion #5: 100
El Promedio De Las Calificaciones Es: 80
```
