using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa una expresión con paréntesis:");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
            Console.WriteLine(" Los paréntesis están balanceados");
        else
            Console.WriteLine(" Los paréntesis NO están balanceados");
    }

    static bool EstaBalanceada(string exp)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in exp)
        {
            if (c == '(')
            {
                pila.Push(c); // meter en la pila
            }
            else if (c == ')')
            {
                if (pila.Count == 0) return false; // no hay con qué cerrar
                pila.Pop(); // sacar de la pila
            }
        }

        return pila.Count == 0; // si quedó vacía, está correcto
    }
}
