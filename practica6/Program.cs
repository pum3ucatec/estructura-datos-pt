using System;


class Principal
{
static void Main(string[] args)
{
Console.Write("Capacidad de la COLA: ");
int cap = int.Parse(Console.ReadLine());
MyQueue cola = new MyQueue(cap);
int opcion;


do
{
Console.WriteLine("\n ***** MENÚ COLA *****");
Console.WriteLine("1. Mostrar COLA");
Console.WriteLine("2. Insertar (Enqueue)");
Console.WriteLine("3. Eliminar (Dequeue)");
Console.WriteLine("4. Ver frente (Peek)");
Console.WriteLine("5. Verificar si está vacía");
Console.WriteLine("6. Verificar si está llena");
Console.WriteLine("7. Ver cantidad (Count)");
Console.WriteLine("0. Salir");
Console.Write("Seleccione una opción: ");


opcion = int.Parse(Console.ReadLine());


switch (opcion)
{
case 1:
cola.Mostrar();
break;
case 2:
Console.Write("Ingrese un carácter: ");
char c = Console.ReadLine()[0];
cola.Enqueue(c);
break;
case 3:
char eliminado = cola.Dequeue();
if (eliminado != '\0')
Console.WriteLine("Eliminado: " + eliminado);
break;
case 4:
char frente = cola.Peek();
if (frente != '\0')
Console.WriteLine("Frente: " + frente);
break;
case 5:
Console.WriteLine(cola.IsEmpty() ? "Sí, está vacía" : "No, tiene elementos");
break;
case 6:
Console.WriteLine(cola.IsFull() ? "Sí, está llena" : "No, aún hay espacio");
break;
case 7:
Console.WriteLine("Cantidad de elementos: " + cola.Count());
break;
case 0:
Console.WriteLine("Saliendo...");
break;
default:
Console.WriteLine("Opción no válida.");
break;
}


} while (opcion != 0);
}
}