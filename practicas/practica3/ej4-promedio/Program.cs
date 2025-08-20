// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 4!");



double[] calificaciones = new double[5];
double suma = 0;


for (int i = 0; i < calificaciones.Length; i++)
{
    Console.Write($"Ingrese la calificación {i + 1}: ");
    calificaciones[i] = Convert.ToDouble(Console.ReadLine());
    suma += calificaciones[i];
}


double promedio = suma / calificaciones.Length;


Console.WriteLine("Notas: [" + string.Join(", ", calificaciones) + "]");
Console.WriteLine($"Promedio: {promedio}");