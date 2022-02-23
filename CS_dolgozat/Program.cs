using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Negatív

            /*
            int egyik;
            int masik;

            Console.WriteLine("Add meg az egyik számot: ");
            egyik = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Add meg az egyik számot: ");
            masik = int.Parse(Console.ReadLine());

            if ((egyik < 0) && (masik < 0))
                Console.WriteLine("Mindkét szám negatív");
            if ((egyik < 0) && (masik > 0))
                Console.WriteLine("Csak az első szám negatív");
            if ((egyik > 0) && (masik < 0))
                Console.WriteLine("Csak a második szám negatív");
            if ((egyik > 0) && (masik > 0))
                Console.WriteLine("Egyik szám sem negatív");
            */

            // Console.WriteLine();
            // Console.ReadLine();

            /***************************************************************************************************/
            /***************************************************************************************************/
            /***************************************************************************************************/

            // 2. Könyv

            /*
            int pages;
            string title;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Add meg a könyv címét: ");
                title = Console.ReadLine();

                Console.WriteLine("Add meg az oldalszámot: ");
                pages = int.Parse(Console.ReadLine());

                if (pages < 150)
                    Console.WriteLine("A(z) " + title + " egy rövid terjedelmű könyv.\n");
                if (pages >= 150)
                    Console.WriteLine("A(z) " + title + " egy hosszú terjedelmű könyv.\n");
            }
            */

            /***************************************************************************************************/
            /***************************************************************************************************/
            /***************************************************************************************************/

            // 3. Született

            /*
            string[] names = new string[3];
            string[] jobs = new string[3];
            string[] genders = new string[3];
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Add meg a nevet: ");
                names[i] = Console.ReadLine();
                
                Console.WriteLine("Add meg a foglalkozást: ");
                jobs[i] = Console.ReadLine();
                
                Console.WriteLine("Add meg a nemet(f/n): ");
                genders[i] = Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                if (genders[i] == "n")
                    Console.WriteLine(names[i] + " egy " + jobs[i] + " nő, szerencseszáma: " + rnd.Next(1, 50));
                if (genders[i] == "f")
                    Console.WriteLine(names[i] + " egy " + jobs[i] + " férfi, szerencseszáma: " + rnd.Next(1, 50));
            }

            */


            Console.ReadLine();
        }
    }
}
