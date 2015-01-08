using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_16_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            P(12345);
            Console.WriteLine();
            Console.WriteLine(Suma(12345));
            Console.WriteLine(SumaRecursiv(12345));
        }

        private static int SumaRecursiv(int p)
        {
            if (p == 0)
            {
                return 0;
            }
            else
                return p % 10 + SumaRecursiv(p / 10);
        }

        private static int Suma(int p)
        {
            int suma = 0;
            while (p > 0)
            {
                suma = suma + p % 10;
                p = p / 10;
            }
            return suma;
        }

        private static void P(int p)
        {
            if (p > 0)
            {
                Console.Write(p % 10);
                P(p / 10);
                Console.Write(p % 10);
            }
        }
    }
}
