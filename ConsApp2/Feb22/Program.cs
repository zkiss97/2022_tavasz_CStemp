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




            //Hiányzások, működik

            /*
            int hianyzas;
            string szuldatum;

            Console.WriteLine("Adja meg a mulasztott órák számát:");
            hianyzas = int.Parse(Console.ReadLine());

            if (hianyzas <= 10)
                Console.WriteLine("It's okay...");
            else if (hianyzas > 10)
            {
                Console.WriteLine("Adja meg a tanuló születési dátumát: ");
                szuldatum = Console.ReadLine();
                if ((hianyzas > 10) && (hianyzas <= 20))
                    Console.WriteLine("A(z) " + szuldatum + " napon született tanulót figyelmeztetésben részesítem.");
                else if ((hianyzas > 20) && (hianyzas <= 30))
                    Console.WriteLine("A(z) " + szuldatum + " napon született tanulót osztályfőnöki intőben részesítem.");
                else if (hianyzas > 30)
                    Console.WriteLine("A(z) " + szuldatum + " napon született tanulót felfüggesztésben részesítem.");
            }
            */

            // Címletezés, működik
            /*

            int osszeg;
            int maradek = 0;
            int db;
            int[] cimletek = new int[12] {20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5};
            

            Console.WriteLine("Adja meg az összeget: ");
            osszeg = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < 12; i++)
            {
                maradek = osszeg % cimletek[i];
                db = osszeg / cimletek[i];
                osszeg = maradek;
                Console.WriteLine(db + " * " + cimletek[i]);
                Console.WriteLine("Maradék: " + maradek + "\n");
                //Console.WriteLine("Összeg: " + osszeg + "\n");
            }
            */

            /*******************/

            // Otthoni feladat, kamatos kamat
            /*
            float osszeg;
            //float vegosszeg;
            float kamatlab;
            int evek;

            Console.WriteLine("összeg input:");
            osszeg = int.Parse(Console.ReadLine());

            Console.WriteLine("évek input:");
            evek = int.Parse(Console.ReadLine());

            Console.WriteLine("kamatláb input:");
            kamatlab = float.Parse(Console.ReadLine()) / 100 + 1;

            for (int i = 0; i < evek; i++)
            {
                osszeg = osszeg * kamatlab;
                Console.WriteLine(osszeg);
            }
            */

            Console.ReadLine();
        }
    }
}

