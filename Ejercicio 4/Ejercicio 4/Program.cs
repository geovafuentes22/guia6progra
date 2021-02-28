using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, mp = 0;
            int np = 0, nn = 0, m5 = 0;
            Console.WriteLine("Ingrese un total de 10 números para que te ayudemos:" +
                "\n 1-Cuantos de los mismos son positivos o negativos\n" +
                "\n 2-Los multiplos de 15" +
                "\n 3-En su defecto el acumulado de los multiplos ");
            for (int x = 0; x < 10; x++) ;
            {
                Console.WriteLine("Ingrese el dato " + ("x + 1"));
                n = Double.Parse(Console.ReadLine());
                if (n < 0)
                    nn++;
                if (n > 0)
                    np++;
                if (n % 15 == 0)
                    m5++;
                if (n % 2 == 0)
                    mp += n;
            }
            Console.WriteLine("Hay " + nn + " número negativo, " + np +  " número positivo, " + 5m + " múltiplo de 15\n" + "y el conjunto de todo los multiplos de 2 es: " + mp);
            Console.ReadLine();
        }
    }
}
