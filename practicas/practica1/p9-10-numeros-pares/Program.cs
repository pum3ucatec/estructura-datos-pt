using System;


    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i+= 2;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
