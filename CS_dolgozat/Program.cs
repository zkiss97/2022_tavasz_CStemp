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

            Console.ReadLine();
        }
    }
}
