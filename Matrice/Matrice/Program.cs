using System;
using System.IO;

namespace Matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m;
            //Citirea matricii
            m = ReadMatrix("input.txt");
            
            //Afisarea matricii
            AfisareMatrice(m);

            // Maxim din matrice
            int max;
            max = MaximMatrice(m);
            Console.WriteLine("Cel mai mare numar din matrice este: {0}", max);

            //maxim de pe fiecare linie
            int[] maximLinii;
            maximLinii = MaximLinii(m);
            for (int i = 0; i < maximLinii.Length; i++)
            {
                Console.WriteLine("Linia {0} - {1} max", i + 1, maximLinii[i]);
            }

            // suma numerelor de pe fiecare coloana
            int[] sumaColoane = SumaColoane(m);
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.WriteLine("Coloana {0} - {1} suma", j + 1, sumaColoane[j]);
            }

            //Matrice patratica
            // suma elementelor de pe diagonala principala
            Console.WriteLine("Suma elementelor de pe diagonala principala este: {0}", SumaDP(m));

            // suma elementelor de pe diagonala secundara
            Console.WriteLine("Suma elementelor de pe diagonala secundara este: {0}", SumaDS(m));

            // Suma elementelor deasupra diagonalei principale
            Console.WriteLine("Suma elementelor deasupra diagonalei principale este: {0}", SumaDDP(m));
        }

        private static int SumaDDP(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < m.GetLength(1) - 1; i++)
            {
                for (int j = i + 1; j < m.GetLength(1); j++)
                {
                    suma += m[i, j];
                }
            }
            return suma;
        }

        private static int SumaDS(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                suma += m[i, m.GetLength(0) - i - 1];
            }
            return suma;
        }

        private static int SumaDP(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                suma += m[i, i];
            }
            return suma;
        }

        private static int[] SumaColoane(int[,] m)
        {
            int[] suma = new int[m.GetLength(1)];
            for (int j = 0; j < m.GetLength(1); j++)
            {
                suma[j] = 0;
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    suma[j] += m[i, j];
                }
            }
            return suma;
        }

        private static int[] MaximLinii(int[,] m)
        {
            int[] max;
            max = new int[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                max[i] = m[i, 0];
                for (int j = 1; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > max[i])
                    {
                        max[i] = m[i, j];
                    }
                }
            }
            return max;
        }

        private static int MaximMatrice(int[,] m)
        {
            int max = m[0, 0];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] > max)
                    {
                        max = m[i, j];
                    }  
                }
            }
            return max;
        }

        private static int[,] ReadMatrix(string filename)
        {
            int[,] m = null;
            try
            {
                
                int linii, coloane;
                StreamReader sr = new StreamReader(filename);

                string line;
                line = sr.ReadLine();

                string[] s = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                linii = int.Parse(s[0]);
                coloane = int.Parse(s[1]);

                m = new int[linii, coloane];
                for (int i = 0; i < linii; i++)
                {
                    line = sr.ReadLine();
                    s = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < coloane; j++)
                    {
                        m[i, j] = int.Parse(s[j]);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return m;
        }

        private static void AfisareMatrice(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", m[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
