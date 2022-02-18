﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Változó tömbök létrehozása (hónapok)

            int[] January = new int[30];
            int[] February = new int[30];
            int[] March = new int[30];
            int[] April = new int[30];
            int[] May = new int[30];
            int[] June = new int[30];
            int[] July = new int[30];
            int[] August = new int[30];
            int[] September = new int[30];
            int[] October = new int[30];
            int[] November = new int[30];
            int[] December = new int[30];

            //Hónapok neveit tartalmazó tömb

            string[] Months = {"Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Október", "November", "December"};

            // Minimum és maximum érték meghatározása

            Random rnd = new Random();
            //int[][] allTemp = new int[12][];
            int minTemp = 40;
            int maxTemp = -10;

            // Feltölti random értékekkel a hónapokat, "ésszerű" keretek között, azaz határokkal

            for (int i = 0; i < 30; i++)
            {
                January[i] = rnd.Next(-10, 10);
                February[i] = rnd.Next(-10, 10);
                March[i] = rnd.Next(0, 20);
                April[i] = rnd.Next(10, 20);
                May[i] = rnd.Next(20, 30);
                June[i] = rnd.Next(25, 40);
                July[i] = rnd.Next(25, 40);
                August[i] = rnd.Next(25, 40);
                September[i] = rnd.Next(20, 30);
                October[i] = rnd.Next(15, 25);
                November[i] = rnd.Next(5, 15);
                December[i] = rnd.Next(-10, 10);
            };

            // Kezdődik a móka.
            // Külső ciklus, végigmegy a hónapokon egymás után
            for (int i = 0; i < 12; i++)
            {
                // Belső ciklus, végigmegy egy hónap napjain
                // Összehasonlítja az éves minimum és maximum értékeket, és ha 
                for (int j = 0; j < January.Length; j++)
                {
                    if (Months[i][j] < minTemp) //IndexOutOÖfRangeException
                    {
                        minTemp = Months[i][j];
                    }
                    if (Months[i][j] > maxTemp)
                    {
                        maxTemp = Months[i][j];
                    }
                    Console.WriteLine(Months[i] + "i minimum hőmérséklet: " + minTemp);
                    Console.WriteLine(Months[i] + "i maximum hőmérséklet: " + maxTemp);
                    minTemp = 40;
                    maxTemp = -10;
                }
            }
            Console.ReadLine();

        }
    }
}
