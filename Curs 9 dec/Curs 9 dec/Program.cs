using System;
using System.IO;
// 12 345 234 35 0
// 12 12 9 8

namespace Curs_9_dec
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            int n, x;
            int suma = 0;
            bool superCrescator = true;

            n = ExtractInt(sr);
            for (int i = 0; i < n && superCrescator; i++)
            {
                x = ExtractInt(sr);
                if (x <= suma)
                {
                    superCrescator = false;
                    // break;
                }
                suma += x; // suma = suma + x;
            }

            if (superCrescator)
            {
                Console.WriteLine("Secventa este supercrescatoare");
            }
            else
                Console.WriteLine("Secventa nu este supercrescatoare");
        }

        private static int ExtractInt(StreamReader sr)
        {
            string line;
            line = sr.ReadLine();
            int n = 0;

            //bool rez = int.TryParse(line, out n);
            //if (rez == false)
            //    Console.WriteLine("Nu am reusit sa covertesc in numar sirul de caractere {0}", line);

            // n = Convert.ToInt32(line);

            try
            {
                n = int.Parse(line);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return n;
        }
    }
}
