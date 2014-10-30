using System;
// Se da n din N*;

// 1, 2, ..., n;

// 1, 
// 1, 2, 
// 1, 2, 3, 
// ...., 
// 1, 2, ..., n

// 1
// 2, 3
// 3, 4, 5
// 4, 5, 6, 7
// ....
// n, n+1, .... , 2n - 1


// Se da secv. 1, 1, 2, 1, 2, 3, ... Sa se afiseze primele n elemente ale sirului. 
// Se da secv. 1, 2, 3, 3, 4, 5, ... Sa se afiseze primele n elemente ale sirului. 
namespace Secvente
{
    class Secvente
    {
        
        static void Linie(int n)
        {
            for (int i = 1; i <= n; i++)
                if (i != n)
                    Console.Write("{0}, ", i);
                else
                    Console.WriteLine("{0}", i);
        }
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(args[0]);

            Linie(n);

            for (int i = 1; i <= n; i++)
                Linie(i);


            Linie2(n);

            Linie3(n);

        }

        static void Linie3(int n)
        {
            int contor = 0;
            int i = 1, j = 1;
            Console.WriteLine("Pr 2");
            while (contor < n)
            {
                Console.Write("{0} ", j);
                contor++; // contor = contor + 1 
                j++;
                if (j == 2 * i)
                {
                    i++;
                    j = i;
                }
            }
            Console.WriteLine();
        }

        static void Linie2(int n)
        {
            int contor = 0;
            int i = 1, j = 1;
            Console.WriteLine("Pr 1");
            while (contor < n)
            {
                Console.Write("{0} ", j);
                contor++; // contor = contor + 1 
                j++;
                if (j > i)
                {
                    j = 1;
                    i++;
                }
            }
            Console.WriteLine();
        }
    }
}
