using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Alan", "Adrien", "Nicolas", "Sebastian" };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lista de Nombres");
            for (int i = 0; i < names.Count; i++) 
                Console.WriteLine($"{i + 1}. {names[i]}");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Eliminar");
            Console.WriteLine("3. Salir");
            string option = Console.ReadLine();

            if (option == "1") InsertName(names);
            else if (option == "2") DeleteName(names);
            else if (option == "3") break;
            else Console.WriteLine("Opción no válida");
        }
    }

    static void InsertName(List<string> names)
    {
        Console.Write("\nNombre a insertar: ");
        string name = Console.ReadLine();
        if (name == null || name == "") 
        {
            Console.WriteLine("Nombre vacío");
            return;
        }
        names.Add(name);
        Console.WriteLine("Nombre insertado.");
        Console.ReadKey();
    }

    static void DeleteName(List<string> names)
    {
        Console.Write("\nNúmero a eliminar: ");
        string input = Console.ReadLine();
        int index = -1;
        if (input != null && Int32.TryParse(input, out index) && index > 0 && index <= names.Count)
        {
            names.RemoveAt(index - 1);
            Console.WriteLine("Nombre eliminado");
        }
        else
        {
            Console.WriteLine("Número inválido");
        }
        Console.ReadKey();
    }
}
