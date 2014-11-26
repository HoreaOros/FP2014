using System;
using System.IO;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10000];
            int[] frecvente = new int[100];

            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = r.Next(1, 101);
                frecvente[v[i] - 1]++;
            }

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("{0} ", v[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < frecvente.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, frecvente[i]);
            }

            int suma = 0;
            foreach (var item in frecvente)
            {
                suma += item;
            }
            Console.WriteLine("Media aritmetica a frecventelor: {0}", (double)suma / frecvente.Length);

            StreamWriter sw = new StreamWriter("numere.out");
            int index = 0;
            foreach (var item in v)
            {
                sw.Write("{0} ", item);
                index++;
                if(index % 20 == 0)
                    sw.WriteLine();
            }

            StreamReader sr = new StreamReader("input.in");

  
        }
    }
}
