using System;
using System.Collections.Generic;

class Practice {
    static void Main()
    {
        Stack<int> pila = new Stack<int>();
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine("Pila:");
        while (pila.Count > 0)
        {
            Console.WriteLine(pila.Pop());
        }
    }
}
