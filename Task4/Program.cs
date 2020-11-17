using System;
using System.Collections.Generic;
using SportAthlets;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SportAthlet> athelst = new List<SportAthlet>();
            athelst.Add(new Athlet("Evgenii", 3, 50, true));
            athelst.Add(new SportAthlet("Artem", 7, 30));
            athelst.Add(new Athlet("Superman", 600, 500, true));
            athelst.Add(new SportAthlet("Denis", 300, 10000));
            foreach (var athlet in athelst)
            {
                Console.WriteLine(athlet.GetInfoInString() + "\n");
            }
        }
    }
}