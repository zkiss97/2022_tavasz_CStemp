using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightCm;
            float weight;
            float index;
            

            Console.WriteLine("Adja meg a magasságát (cm): ");
            heightCm = int.Parse(Console.ReadLine());
            float heightM = heightCm / 100;

            Console.WriteLine("Adja meg a súlyát (kg): ");
            weight = float.Parse(Console.ReadLine());

            float negyzetmeterkisfroccs = heightM * heightM;

            index = (weight / negyzetmeterkisfroccs);
            Console.WriteLine(negyzetmeterkisfroccs);

            Console.WriteLine("Testtömegindexe: " + index);

            Console.ReadLine();
        }
    }
}
