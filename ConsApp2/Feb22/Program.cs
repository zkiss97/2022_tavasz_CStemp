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
            // Testtömegindex kiszámítása
            /*
            int heightCm;
            float weight;
            float index;
            

            Console.WriteLine("Adja meg a magasságát (cm): ");
            heightCm = int.Parse(Console.ReadLine());
            float heightM = heightCm / 100;
            Console.WriteLine(heightM + "\n\n");
            // lecsapja a törtrészt. 180 centivel teszteltem, 1-et ad vissza.

            Console.WriteLine("Adja meg a súlyát (kg): ");
            weight = float.Parse(Console.ReadLine());

            float negyzetmeterkisfroccs = heightM * heightM;

            index = (weight / negyzetmeterkisfroccs);
            Console.WriteLine(negyzetmeterkisfroccs);

            Console.WriteLine("Testtömegindexe: " + index);

            */



            // Osztályozás pontszám alapján, működik
            /*
            int pontszam;

            Console.WriteLine("Adja meg a dolgozat pontszámát: ");
            pontszam = int.Parse(Console.ReadLine());

            if ((pontszam >= 0) && (pontszam < 50))
                Console.WriteLine("Elégtelen");
            else if ((pontszam >= 50) && (pontszam < 65))
                Console.WriteLine("Elégséges");
            else if ((pontszam >= 65) && (pontszam < 80))
                Console.WriteLine("Közepes");
            else if ((pontszam >= 80) && (pontszam < 90))
                Console.WriteLine("Jó");
            else if ((pontszam >= 90) && (pontszam <= 100))
                Console.WriteLine("Jeles");
            else if ((pontszam > 100) || (pontszam < 0))
                Console.WriteLine("!!!ÉRVÉNYTELEN!!!");
            */



            // Mezgaz jóslás, működik
            //feltételeztem hogy egész tonna búzát vetettek, és szintén egész tonna termett

            /*
            int elvetett;
            Random rnd = new Random();

            Console.WriteLine("Adja meg mennyi búzát vetett az idén (tonna): ");
            elvetett = int.Parse(Console.ReadLine());

            int hozam = rnd.Next(5, 15);
            Console.WriteLine("Az idén várható hozam: " + elvetett * hozam + " tonna.");
            */




            Console.ReadLine();
        }
    }
}
