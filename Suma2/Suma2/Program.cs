using System;


namespace Suma2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int suma, n;

                Console.WriteLine("Introduceti un numar natural:");
                string line = Console.ReadLine();
                n = int.Parse(line);

                suma = Suma(n);

                Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", n, suma);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        static int Suma(int n)
        {
            int i = 1, suma = 0;

            while (i <= n)
            {
                suma = suma + i;
                i = i + 1;
            }

            return suma;
        }
    }
}
