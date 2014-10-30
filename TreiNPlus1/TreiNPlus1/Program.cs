using System;


namespace TreiNPlus1
{
    class Program
    {
        static int LungimeSecventa(int n)
        {
            int a, b;
            int contor = 0;
            int maxim = 0;
            b = n;
            while (b != 1)
            {
                if (b > maxim)
                    maxim = b;
                contor++; // contor = contor + 1;
                if (b % 2 == 0)
                    a = b / 2;
                else
                    a = 3 * b + 1;
                Console.Write("{0} ", a);
                b = a;
            }
            Console.WriteLine("Maximul este: {0}", maxim);
            return contor;
        }
        static void Main(string[] args)
        {
            int N = 123;

            int lungime = LungimeSecventa(N);
            Console.WriteLine("Lungimea este: {0}", lungime);

            for (int i = 2; i <= 100; i++)
            {
                Console.Write("{0}: ", i);
                LungimeSecventa(i);
            }
        }
    }
}
