using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazadaPersonalizada
{
    // Definición del nodo para la lista enlazada
    public class NodoLista
    {
        public int Dato { get; set; }
        public NodoLista? SiguienteNodo { get; set; }

        public NodoLista(int dato)
        {
            Dato = dato;
            SiguienteNodo = null;
        }
    }

    // Clase que representa la lista enlazada simple
    public class ListaEnlazada
    {
        private NodoLista? cabeza;

        public bool EstaVacia() => cabeza == null;

        public void AñadirAlInicio(int valor)
        {
            var nodoNuevo = new NodoLista(valor) { SiguienteNodo = cabeza };
            cabeza = nodoNuevo;
        }

        public void AñadirAlFinal(int valor)
        {
            var nodoNuevo = new NodoLista(valor);
            if (cabeza == null)
            {
                cabeza = nodoNuevo;
                return;
            }

            NodoLista actual = cabeza;
            while (actual.SiguienteNodo != null)
                actual = actual.SiguienteNodo;

            actual.SiguienteNodo = nodoNuevo;
        }

        public bool InsertarDespuesDe(int valorReferencia, int valorNuevo)
        {
            NodoLista? actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == valorReferencia)
                {
                    var nodoNuevo = new NodoLista(valorNuevo)
                    {
                        SiguienteNodo = actual.SiguienteNodo
                    };
                    actual.SiguienteNodo = nodoNuevo;
                    return true;
                }
                actual = actual.SiguienteNodo;
            }
            return false;
        }

        public bool EliminarPrimero()
        {
            if (cabeza == null) return false;
            cabeza = cabeza.SiguienteNodo;
            return true;
        }

        public bool EliminarPorValor(int valor)
        {
            if (cabeza == null) return false;

            if (cabeza.Dato == valor)
            {
                cabeza = cabeza.SiguienteNodo;
                return true;
            }

            NodoLista anterior = cabeza;
            NodoLista? actual = cabeza.SiguienteNodo;

            while (actual != null)
            {
                if (actual.Dato == valor)
                {
                    anterior.SiguienteNodo = actual.SiguienteNodo;
                    return true;
                }
                anterior = actual;
                actual = actual.SiguienteNodo;
            }
            return false;
        }

        public bool EliminarPorPosicion(int posicion)
        {
            if (posicion < 0 || cabeza == null) return false;

            if (posicion == 0)
            {
                cabeza = cabeza.SiguienteNodo;
                return true;
            }

            NodoLista anterior = cabeza;
            NodoLista? actual = cabeza.SiguienteNodo;
            int indice = 1;

            while (actual != null)
            {
                if (indice == posicion)
                {
                    anterior.SiguienteNodo = actual.SiguienteNodo;
                    return true;
                }
                anterior = actual;
                actual = actual.SiguienteNodo;
                indice++;
            }
            return false;
        }

        public int BuscarIndiceDe(int valor)
        {
            int indice = 0;
            NodoLista? actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato == valor)
                    return indice;
                actual = actual.SiguienteNodo;
                indice++;
            }
            return -1;
        }

        public int ContarElementos()
        {
            int contador = 0;
            NodoLista? actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.SiguienteNodo;
            }
            return contador;
        }

        public void VaciarLista()
        {
            cabeza = null;
        }

        public void InvertirLista()
        {
            NodoLista? anterior = null;
            NodoLista? actual = cabeza;

            while (actual != null)
            {
                NodoLista? siguiente = actual.SiguienteNodo;
                actual.SiguienteNodo = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        public IEnumerable<int> ObtenerElementos()
        {
            NodoLista? actual = cabeza;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.SiguienteNodo;
            }
        }

        public override string ToString()
        {
            if (cabeza == null)
                return "[vacía]";

            var sb = new StringBuilder();
            NodoLista? actual = cabeza;

            while (actual != null)
            {
                sb.Append(actual.Dato);
                if (actual.SiguienteNodo != null)
                    sb.Append(" -> ");
                actual = actual.SiguienteNodo;
            }

            return sb.ToString();
        }
    }

    class ProgramaPrincipal
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var lista = new ListaEnlazada();

            while (true)
            {
                MostrarOpciones();
                Console.Write("Elige una opción: ");
                string? opcion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(opcion))
                    continue;

                Console.WriteLine();
                switch (opcion.Trim())
                {
                    case "1":
                        int datoInicio = LeerNumero("Introduce valor para agregar al inicio: ");
                        lista.AñadirAlInicio(datoInicio);
                        Console.WriteLine("Elemento agregado. Lista: " + lista);
                        break;

                    case "2":
                        int datoFinal = LeerNumero("Introduce valor para agregar al final: ");
                        lista.AñadirAlFinal(datoFinal);
                        Console.WriteLine("Elemento agregado. Lista: " + lista);
                        break;

                    case "3":
                        int valorReferencia = LeerNumero("Valor después del cual insertar: ");
                        int valorNuevo = LeerNumero("Nuevo valor a insertar: ");
                        bool exitoInsertar = lista.InsertarDespuesDe(valorReferencia, valorNuevo);
                        Console.WriteLine(exitoInsertar ? "Insertado correctamente." : "Valor de referencia no encontrado.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "4":
                        bool eliminadoPrimero = lista.EliminarPrimero();
                        Console.WriteLine(eliminadoPrimero ? "Primer elemento eliminado." : "La lista está vacía.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "5":
                        int valorEliminar = LeerNumero("Valor a eliminar: ");
                        bool eliminadoValor = lista.EliminarPorValor(valorEliminar);
                        Console.WriteLine(eliminadoValor ? "Elemento eliminado." : "Valor no encontrado.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "6":
                        int posicionEliminar = LeerNumero("Posición a eliminar (desde 0): ");
                        bool eliminadoPos = lista.EliminarPorPosicion(posicionEliminar);
                        Console.WriteLine(eliminadoPos ? "Elemento eliminado." : "Posición inválida.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "7":
                        int valorBuscar = LeerNumero("Valor a buscar: ");
                        int indiceEncontrado = lista.BuscarIndiceDe(valorBuscar);
                        Console.WriteLine(indiceEncontrado >= 0 ? $"Valor encontrado en índice {indiceEncontrado}." : "Valor no encontrado.");
                        break;

                    case "8":
                        Console.WriteLine("Contenido actual de la lista: " + lista);
                        break;

                    case "9":
                        Console.WriteLine("Total de elementos en la lista: " + lista.ContarElementos());
                        break;

                    case "10":
                        lista.InvertirLista();
                        Console.WriteLine("Lista invertida.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "11":
                        lista.VaciarLista();
                        Console.WriteLine("Lista vaciada.");
                        Console.WriteLine("Lista: " + lista);
                        break;

                    case "0":
                        Console.WriteLine("Finalizando programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void MostrarOpciones()
        {
            Console.WriteLine("===== MENÚ =====");
            Console.WriteLine("1) Añadir al inicio");
            Console.WriteLine("2) Añadir al final");
            Console.WriteLine("3) Insertar después de un valor");
            Console.WriteLine("4) Eliminar primero");
            Console.WriteLine("5) Eliminar por valor");
            Console.WriteLine("6) Eliminar por posición");
            Console.WriteLine("7) Buscar valor");
            Console.WriteLine("8) Mostrar lista");
            Console.WriteLine("9) Contar elementos");
            Console.WriteLine("10) Invertir lista");
            Console.WriteLine("11) Vaciar lista");
            Console.WriteLine("0) Salir");
            Console.WriteLine();
        }

        static int LeerNumero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string? entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int numero))
                    return numero;
                Console.WriteLine("Entrada inválida, intenta nuevamente.");
            }
        }
    }
}
