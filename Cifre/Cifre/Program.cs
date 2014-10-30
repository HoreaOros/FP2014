using System;
using System.Numerics;
// 1. Suma cifrelor unui numar
// 2. Teste de primalitate
// 3. Se da un numar n - Sa se genereze numarul obtinut prin eliminearea
// din n a tuturor cifrelor care sunt multiplu de 3.

namespace Cifre
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12300548;
            
            Console.WriteLine("Suma ciferlor numarului {0} este {1}", n, SumaCifre(n));

            int p = int.MaxValue;
            if (Prim3(p))
                Console.WriteLine("Numarul {0} este prim", p);
            else
                Console.WriteLine("Numarul {0} nu este prim", p);
            BigInteger bigint = new BigInteger();
        }

        private static bool Prim3(int p)
        {
            if (p == 2)
                return true;
            if (p % 2 == 0)
                return false;

            for (int d = 3; d * d <= p; d = d + 2)
            {
                if (d % 10001 == 0)
                {
                    Console.WriteLine(d);
                }
                if (p % d == 0)
                    return false;
            }
            return true;
        }

        // numar divizorii proprii
        private static bool Prim2(int p)
        {
            int contor = 0;


            for (int d = 2; d <= p / 2; d++)
            {
                if (d % 10000 == 0)
                {
                    Console.WriteLine(d);
                }
                if (p % d == 0)
                {
                    contor++;
                }
            }
            if (contor == 0)
                return true;
            else
                return false;
        }

        private static bool Prim1(int p)
        {
            int contor = 0;
            for (int d = 1; d <= p; d++)
            {
                if (d % 10000 == 0)
                {
                    Console.WriteLine(d);
                }
                if (p % d == 0)
                {
                    contor++;
                }
            }
            if (contor == 2)
                return true;
            else
                return false;
        }

        private static int SumaCifre(int n)
        {
            int suma = 0;
            int cifra;

            while (n != 0)
            {
                cifra = n % 10;
                suma = suma + cifra; // SAU suma += cifra
                n = n / 10;
            }
            return suma;
        }
    }
}
