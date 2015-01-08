using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structuri
{
    struct MyDate
    {
        public int zi, luna, anul;

        public bool NotEqual(MyDate d2)
        {
            if (zi != d2.zi || luna != d2.luna || anul != d2.anul)
                return true;
            else
                return false;
        }

        public void ScadOZi()
        {
            if (zi > 1)
            {
                zi--;
            }
            else
            {
                switch (luna)
                {
                    case 2: case 4: case 6: 
                    case 8: case 9: case 11:
                        zi = 31;
                        luna--;
                        break;
                    case 1:
                        zi = 31;
                        luna = 12;
                        anul--;
                        break;
                    case 5: case 7: case 10: case 12:
                        zi = 30;
                        luna--;
                        break;
                    case 3:
                        if (((anul % 4 == 0) && (anul % 100 != 0)) || (anul % 400 == 0))
                            zi = 29;
                        else
                            zi = 28;
                        luna--;
                        break;
                    default:
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0}", dt.ToLongDateString());

            MyDate d1, d2;
            d1.zi = 10;
            d1.luna = 1;
            d1.anul = 1995;

            d2.zi = 9;
            d2.luna = 12;
            d2.anul = 2014;

            int nrZile = DiferentaZile(d1, d2);
            Console.WriteLine("Ai trait {0}", nrZile);
        }

        private static int DiferentaZile(MyDate d1, MyDate d2)
        {
            int contor = 0;
            while (d1.NotEqual(d2))
            {
                contor++;
                d2.ScadOZi();
            }
            return contor;
        }
    }
}
