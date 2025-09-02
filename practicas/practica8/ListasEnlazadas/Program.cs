using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaSimpleConMenu
{
    // Nodo de la lista
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int dato)
        {
            Valor = dato;
            Siguiente = null;
        }
    }

    // Lista enlazada simple
    public class ListaSimple
    {
        private Nodo? inicio;

        public bool EstaVacia => inicio == null;

        public void AgregarAlInicio(int numero)
        {
            var nuevoNodo = new Nodo(numero) { Siguiente = inicio };
            inicio = nuevoNodo;
        }

        public void AgregarAlFinal(int numero)
        {
            var nuevoNodo = new Nodo(numero);
            if (inicio == null)
            {
                inicio = nuevoNodo;
                return;
            }

            var actual = inicio;
            while (actual!.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }

        public bool InsertarDespues(int referencia, int nuevoValor)
        {
            var actual = inicio;
            while (actual != null)
            {
                if (actual.Valor == referencia)
                {
                    var nuevoNodo = new Nodo(nuevoValor) { Siguiente = actual.Siguiente };
                    actual.Siguiente = nuevoNodo;
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public bool EliminarPrimero()
        {
            if (inicio == null) return false;
            inicio = inicio.Siguiente;
            return true;
        }

        public bool EliminarPorValor(int valor)
        {
            if (inicio == null) return false;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Siguiente;
                return true;
            }

            var anterior = inicio;
            var actual = inicio.Siguiente;

            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    anterior.Siguiente = actual.Siguiente;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            return false;
        }

        public bool EliminarPorIndice(int posicion)
        {
            if (posicion < 0 || inicio == null) return false;

            if (posicion == 0)
            {
                inicio = inicio.Siguiente;
                return true;
            }

            var anterior = inicio;
            var actual = inicio.Siguiente;
            int contador = 1;

            while (actual != null)
            {
                if (contador == posicion)
                {
                    anterior.Siguiente = actual.Siguiente;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
                contador++;
            }
            return false;
        }

        public int BuscarIndice(int valor)
        {
            int pos = 0;
            var actual = inicio;
            while (actual != null)
            {
                if (actual.Valor == valor) return pos;
                actual = actual.Siguiente;
                pos++;
            }
            return -1;
        }

        public int Contar()
        {
            int total = 0;
            var actual = inicio;
            while (actual != null)
            {
                total++;
                actual = actual.Siguiente;
            }
            return total;
        }

        public void Vaciar() => inicio = null;

        public void Invertir()
        {
            Nodo? anterior = null;
            var actual = inicio;

            while (actual != null)
            {
                var siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            inicio = anterior;
        }

        public IEnumerable<int> ComoEnumerable()
        {
            var actual = inicio;
            while (actual != null)
            {
                yield return actual.Valor;
                actual = actual.Siguiente;
            }
        }

        public override string ToString()
        {
            if (inicio == null) return "[ vacía ]";

            var sb = new StringBuilder();
            var actual = inicio;
            while (actual != null)
            {
                sb.Append(actual.Valor);
                if (actual.Siguiente != null) sb.Append(" -> ");
                actual = actual.Siguiente;
            }
            return sb.ToString();
        }
    }

    class Principal
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var lista = new ListaSimple();

            while (true)
            {
                MostrarMenu();
                Console.Write("Selecciona una opción: ");
                var opcion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(opcion)) continue;

                Console.WriteLine();
                switch (opcion.Trim())
                {
                    case "1":
                        int datoIni = LeerEntero("Dato para agregar al INICIO: ");
                        lista.AgregarAlInicio(datoIni);
                        Console.WriteLine("Hecho. Lista: " + lista);
                        break;

                    case "2":
                        int datoFin = LeerEntero("Dato para agregar al FINAL: ");
                        lista.AgregarAlFinal(datoFin);
                        Console.WriteLine("Hecho. Lista: " + lista);
                        break;

                    case "3":
                        int refValor = LeerEntero("Insertar después del valor: ");
                        int nuevo = LeerEntero("Nuevo dato: ");
                        bool insertado = lista.InsertarDespues(refValor, nuevo);
                        Console.WriteLine(insertado ? "Insertado." : "Valor no encontrado.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "4":
                        bool elimPrimero = lista.EliminarPrimero();
                        Console.WriteLine(elimPrimero ? "Primer nodo eliminado." : "Lista vacía.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "5":
                        int eliminarValor = LeerEntero("Valor a eliminar: ");
                        bool elimVal = lista.EliminarPorValor(eliminarValor);
                        Console.WriteLine(elimVal ? "Eliminado." : "Valor no hallado.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "6":
                        int eliminarPos = LeerEntero("Posición a eliminar (0-based): ");
                        bool elimPos = lista.EliminarPorIndice(eliminarPos);
                        Console.WriteLine(elimPos ? "Eliminado." : "Índice inválido.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "7":
                        int buscar = LeerEntero("Valor a buscar: ");
                        int pos = lista.BuscarIndice(buscar);
                        Console.WriteLine(pos >= 0 ? $"Encontrado en índice {pos}." : "No encontrado.");
                        break;

                    case "8":
                        Console.WriteLine("Contenido: " + lista);
                        break;

                    case "9":
                        Console.WriteLine("Cantidad de elementos: " + lista.Contar());
                        break;

                    case "10":
                        lista.Invertir();
                        Console.WriteLine("Lista invertida.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "11":
                        lista.Vaciar();
                        Console.WriteLine("Lista vaciada.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("***** MENÚ *****");
            Console.WriteLine("1) Agregar al inicio");
            Console.WriteLine("2) Agregar al final");
            Console.WriteLine("3) Insertar después de un valor");
            Console.WriteLine("4) Eliminar primero");
            Console.WriteLine("5) Eliminar por valor");
            Console.WriteLine("6) Eliminar por posición (0-based)");
            Console.WriteLine("7) Buscar valor (devuelve índice)");
            Console.WriteLine("8) Mostrar lista");
            Console.WriteLine("9) Contar elementos");
            Console.WriteLine("10) Invertir lista");
            Console.WriteLine("11) Vaciar lista");
            Console.WriteLine("0) Salir");
            Console.WriteLine();
        }

        static int LeerEntero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                var entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int numero)) return numero;
                Console.WriteLine("Entrada inválida. Intenta nuevamente.");
            }
        }
    }
}
