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

        }

        static void Print(int[] v)
        {
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);
        }
    }
}
