using System;

class Principal
{
    static void Main(string[] args)
    {
        ListaEnlazadaDoble lista = new ListaEnlazadaDoble();
        int opcion;

        do
        {
            Console.WriteLine("\n===== MENÚ DE LISTA DOBLE =====");
            Console.WriteLine("1. Recorrer hacia adelante");
            Console.WriteLine("2. Recorrer hacia atrás");
            Console.WriteLine("3. Agregar al inicio");
            Console.WriteLine("4. Agregar al final");
            Console.WriteLine("5. Quitar al inicio");
            Console.WriteLine("6. Quitar al final");
            Console.WriteLine("7. Quitar en posición específica");
            Console.WriteLine("8. Buscar elemento");
            Console.WriteLine("9. Total de elementos");
            Console.WriteLine("10. Comprobar si está vacía");
            Console.WriteLine("11. Limpiar lista");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");

            bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

            if (!esNumero)
            {
                Console.WriteLine("Entrada inválida. Intenta de nuevo.");
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    lista.RecorrerAdelante();
                    break;
                case 2:
                    lista.RecorrerAtras();
                    break;
                case 3:
                    Console.Write("Valor a insertar al inicio: ");
                    lista.InsertarInicio(int.Parse(Console.ReadLine() ?? "0"));
                    break;
                case 4:
                    Console.Write("Valor a insertar al final: ");
                    lista.InsertarFinal(int.Parse(Console.ReadLine() ?? "0"));
                    break;
                case 5:
                    lista.EliminarInicio();
                    break;
                case 6:
                    lista.EliminarFinal();
                    break;
                case 7:
                    Console.Write("Posición a eliminar: ");
                    lista.EliminarEn(int.Parse(Console.ReadLine() ?? "1"));
                    break;
                case 8:
                    Console.Write("Elemento a buscar: ");
                    lista.BuscarElemento(int.Parse(Console.ReadLine() ?? "0"));
                    break;
                case 9:
                    Console.WriteLine($"Cantidad de nodos: {lista.Tamaño()}");
                    break;
                case 10:
                    Console.WriteLine(lista.Vacia() ? "La lista no contiene elementos." : "La lista contiene nodos.");
                    break;
                case 11:
                    lista.Limpiar();
                    break;
                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;
                default:
                    Console.WriteLine("Opción fuera de rango.");
                    break;
            }
        } while (opcion != 0);
    }
}
