    # Ejercicio 1 - Encontrar Número Faltante

## 📋 Descripción
Este programa encuentra el número faltante en un arreglo de números consecutivos 'del 1 al n', este programa esta ejecutado en bash con 'dotnet run'

## 🔍 Problema Resuelto
Dado un arreglo de números del 1 al n donde falta exactamente un número, el programa identifica cuál número falta.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje**: C#
- **Plataforma**: .NET
- **Versión**: Compatible con .NET Framework y .NET Core

## 📁 Estructura del Proyecto
```
n = array.Length + 1
suma_total = n*(n+1)/2
return suma_total - array.Sum()
```
