using System;

namespace NewProject
{
    
    class Program
    {
        static int NumarCifre(int n)
        {
            int contor = 0;
            while (n > 0)
            {
                contor++;
                n = n / 10;
            }
            return contor;
        }
        static int GetNextInt()
        {
            string line;
            line = Console.ReadLine();
            return int.Parse(line);
        }
        static void Main(string[] args)
        {
            int i;
            short s;
            float pi = 3.14f;
            char c = 'X';

            string str = "Hello";

            string strLower = str.ToLower();

            int[] v = new int[1000];
            // n = 5, 125, 25, 999, 997, 129
            int k = 3;
            // 998, 996, 995

            int n, nr;
            n = GetNextInt();
            for (i = 0; i < n; i++)
            {
                nr = GetNextInt();
                if (NumarCifre(nr) == 3)
                {
                    v[nr] = 1;
                }
            }
            int[] numere = new int[k];
            int j = 0;
            for(i = 999; (i >= 100) && (j < k); i--)
                if (v[i] == 0)
                {
                    numere[j++] = i;
                }
            if (j == k)
            {
                for (j = 0; j < k; j++)
                {
                    Console.WriteLine("{0} ", numere[j]);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
