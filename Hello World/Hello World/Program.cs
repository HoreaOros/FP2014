using System;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int varsta;
                Console.WriteLine("Hello World!");

                Console.WriteLine("Care este varsta dv?");

                string line;
                line = Console.ReadLine();
                varsta = int.Parse(line);

                Console.WriteLine("Varsta dv: este: " + varsta);

                if (varsta < 18)
                    Console.WriteLine("Sunteti minor.");
                else if (varsta < 65)
                    Console.WriteLine("Sunteti adult.");
                else
                    Console.WriteLine("Sunteti pensionar.");
            }
            catch (Exception)
            {
                Console.WriteLine("Oops!!! Something went wrong... Our specialists will investigate."); ;
            }
        }
    }
}
