using System;


namespace Tablouri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            v = new int[100];

            Print(v);

            VectorInit(v, 0, 1000);

            Print(v);


            Sort(v);
            Print(v);

            // Modificam elementele tabloului a.i. fiecare element
            // sa fie inlocuit cu "cifra sa de control".
            Transform1(v);

            Print(v);


        }

        private static void Sort(int[] v)
        {
            int aux;
            for(int i = 0; i < v.Length; i++)
                for(int j = i + 1; j < v.Length; j++)
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                        //v[i] = v[i] + v[j];
                        //v[j] = v[i] - v[j];
                        //v[i] = v[i] - v[j];
                    }
        }

        static void Transform1(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = CifraControl(v[i]);
        }
        /// <summary>
        /// Cifra de control
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static int CifraControl(int p)
        {
            while (p > 9)
            {
                p = SumaCifre(p);
            }
            return p;
        }
        /// <summary>
        /// Suma cifrelor
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static int SumaCifre(int p)
        {
            int suma = 0;
            while (p > 0)
            {
                suma += p % 10; // suma = suma + p % 10;
                // v[p[i][j]+ k /2] += 2; // utilizare tipica
                p = p / 10;
            }
            return suma;
        }

        /// <summary>
        /// Init vector cu numere din intervalul [low, high)
        /// </summary>
        /// <param name="v">Vector</param>
        /// <param name="low">Valoarea minima</param>
        /// <param name="high">Valoarea maxima</param>
        static void VectorInit(int[] v, int low, int high)
        {
            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
                v[i] = r.Next(low, high);
        }

        static void Print(int[] v)
        {
            for(int i = 0; i < v.Length; i++)
                Console.Write("{0} ", v[i]);
            Console.WriteLine();
        }
    }
}
