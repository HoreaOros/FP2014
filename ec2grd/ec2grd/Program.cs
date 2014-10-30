using System;
// Programul rezolva ecuatia de gradul II cu o necunoscuta in R. 

namespace ec2grd
{
    class Program
    {
        static void Linie2(int n)
        {
            int i = 1, j = 1;
            int contor = 0;
            while (contor < n)
            {
                Console.WriteLine("{0} ", j);
                contor++;
                j++;
                if (j == i + 1)
                {
                    i++;
                    j = 1;
                }
            }
        }
        static void Linie3(int n)
        {
            int i = 1, j = 1;
            int contor = 0;
            while (contor < n)
            {
                Console.WriteLine("{0} ", j);
                contor++;
                j++;
                if (j == 2 * i)
                {
                    i++;
                    j = i;
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            a = int.Parse(args[0]);
            b = int.Parse(args[1]);
            c = int.Parse(args[2]);

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            //float suma = 0;
            //for (int i = 1; i < 1000000; i = i + 1)
            //    suma = suma + 0.01f;

            // Console.WriteLine("Suma = {0}", suma);

            if (a != 0)
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Ecuatia are doua solutii reale distincte: {0}, {1}", x1, x2);
                }
                else if ( delta == 0)
                {
                    x1 = -b / (2 * (double)a);
                    Console.WriteLine("Ecuatia are o singura solutie reala: {0}", x1);
                }
                else
                    Console.WriteLine("Ecuatia nu are solutii reale");
            }
            else
            {
                if (b != 0)
                {
                    x1 =  -c / (double)b;
                    Console.WriteLine("Solutia ecuatiei este {0}", x1);
                }
                else
                    Console.WriteLine("Ecuatie degenerata!!!");
            }
        }
    }
}
