using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El sistema te mostrará los números de 1 al 30, exceptuando el número 25");


            for (int x = 1; x < 25; x++)
            {
                Console.WriteLine("" + x + "");
            }
            for (int x = 26; x <= 100; x++)
            {

                Console.ReadKey();
            }
        }
    }
}
