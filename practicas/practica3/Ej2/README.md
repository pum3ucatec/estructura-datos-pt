# Codigo En PascalCase En CSharp

Este Programa Muestra Como Recorrer Un Arreglo De Numeros Utilizando Un Bucle `for` Y Mostrar Cada Elemento En La Consola.

## Explicacion Del Codigo

1. **Declaracion Del Arreglo**
   ```csharp
   int[] Numeros = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
   ```
   - Se Crea Un Arreglo De Enteros Llamado `Numeros` (En **PascalCase**) Con 10 Elementos.

2. **Bucle For**
   ```csharp
   for (int I = 0; I < Numeros.Length; I++)
   {
       Console.WriteLine("Elemento En Posicion " + I + ": " + Numeros[I]);
   }
   ```
   - `I` Es La Variable De Control Del Bucle.  
   - `I < Numeros.Length` Asegura Que El Recorrido Se Detenga Cuando `I` Sea Igual Al Tamaño Del Arreglo.  
   - `Console.WriteLine(...)` Imprime En Pantalla El Texto `"Elemento En Posicion"` Junto Con El Indice `I` Y El Valor Correspondiente Del Arreglo.

## Salida Esperada

El Programa Imprimira En Consola:

```
Elemento En Posicion 0: 5
Elemento En Posicion 1: 10
Elemento En Posicion 2: 15
Elemento En Posicion 3: 20
Elemento En Posicion 4: 25
Elemento En Posicion 5: 30
Elemento En Posicion 6: 35
Elemento En Posicion 7: 40
Elemento En Posicion 8: 45
Elemento En Posicion 9: 50
```

---

Todo El Codigo Esta Escrito Siguiendo La Convencion **PascalCase** En Sus Identificadores Y Documentacion.
