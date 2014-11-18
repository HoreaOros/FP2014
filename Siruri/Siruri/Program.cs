using System;
using System.Text;


namespace Siruri
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello World!";

            Console.WriteLine(line);
            Console.WriteLine("Lungimea sirului este: {0}", line.Length);

            //CheckPassword();

            StringMethods();

        }

        private static void StringMethods()
        {
            string line = "Hello World!";

            //EndsWith
            if (line.EndsWith("World!"))
                Console.WriteLine("{0} se termina cu World!", line);
            else
                Console.WriteLine("{0} nu se termina cu World!", line);

            //Contains
            if(line.Contains("World"))
                Console.WriteLine("{0} contine World", line);

            //IndexOf
            int index = line.IndexOf("World");
            Console.WriteLine("Cuvantul World apare in sirul {0} la pozitia {1}", line, index);

            //Insert
            string newLine = line.Insert(index, "C# ");
            Console.WriteLine(newLine);

            //ToUpper
            string upperLine = line.ToUpper();
            Console.WriteLine(upperLine);

            //ToLower
            string lowerLine = line.ToLower();
            Console.WriteLine(lowerLine);

            //Trim
            string uglyLine = "   ^$^Hello World!&*()\t^&^%";
            Console.WriteLine(uglyLine);
            char[] c = {' ', '$', '^', '&', '*', '(', ')', '\t', '%'};
            string niceLine = uglyLine.Trim(c);
            Console.WriteLine(niceLine);

            //ToCharArray
            char[] ch = line.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            //Split
            string numbers = "4,234;567,456";
            string[] nums = numbers.Split(',', ';');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += int.Parse(nums[i]);
            }
            Console.WriteLine("Suma numerelor este: {0}", sum);
        }

        private static void CheckPassword()
        {
            string parola = "secret!";
            int contor = 3;
            string line;
            do
            {
                Console.WriteLine("Introduceti parola:");
                line = Console.ReadLine();
                contor--;
            } while (contor > 0 && line != parola);

            if(line == parola)
                Console.WriteLine("Bine ati venit!");
            else
                Console.WriteLine("Ati introdus parola gresit de 3 ori. Accesul este interzis!");

        }
    }
}
