using System;

Cola miCola = new Cola();
bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- MENÚ COLA ---");
    Console.WriteLine("1. Enqueue (Insertar)");
    Console.WriteLine("2. Dequeue (Eliminar)");
    Console.WriteLine("3. Peek (Ver frente)");
    Console.WriteLine("4. IsEmpty (¿Vacía?)");
    Console.WriteLine("5. Count (Cantidad)");
    Console.WriteLine("6. Contains (Buscar)");
    Console.WriteLine("7. Clear (Vaciar cola)");
    Console.WriteLine("8. Mostrar cola");
    Console.WriteLine("9. Salir");
    Console.Write("Elige una opción: ");

    string opcion = Console.ReadLine();
    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese un texto: ");
            string valor = Console.ReadLine();
            miCola.Enqueue(valor);
            break;

        case "2":
            var eliminado = miCola.Dequeue();
            Console.WriteLine(eliminado == null ? "La cola está vacía." : $"Se eliminó: {eliminado}");
            break;

        case "3":
            var frente = miCola.Peek();
            Console.WriteLine(frente == null ? "La cola está vacía." : $"El frente es: {frente}");
            break;

        case "4":
            Console.WriteLine(miCola.IsEmpty() ? "La cola está vacía." : "La cola tiene elementos.");
            break;

        case "5":
            Console.WriteLine($"Cantidad de elementos: {miCola.Count()}");
            break;

        case "6":
            Console.Write("Ingrese el texto a buscar: ");
            string buscado = Console.ReadLine();
            Console.WriteLine(miCola.Contains(buscado) ? "El valor está en la cola." : "No se encontró en la cola.");
            break;

        case "7":
            miCola.Clear();
            Console.WriteLine("Cola vaciada.");
            break;

        case "8":
            miCola.Mostrar();
            break;

        case "9":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción inválida, intente de nuevo.");
            break;
    }
}
