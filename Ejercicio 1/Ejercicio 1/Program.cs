using System;

namespace Ejercicio_1
{
    class Program
    {
        static void lastablas(int n)
        {
            for (int i = 1; i < 11; i++)
                Console.WriteLine(i + " * " + n + "=" + i * n + "\n");
        }
        static void Main(string[] args)
        {
            int n;
            for (int x = 0; x < 10; x++)
            {
                Console.Write("\nIngrese que tabla de multiplicar desea conocer? ");
                n = int.Parse(Console.ReadLine());
                lastablas(n);
            }
            Console.ReadKey();
        }
    }
}
