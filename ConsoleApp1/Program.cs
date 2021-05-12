using cardioLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double somma = 0, tot;
            using (StreamReader r = new StreamReader("dati.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Int32.TryParse(line, out int n);
                    somma += n;
                }
                tot = somma / 1440;
            }
            Console.WriteLine(tot);


        }
    }
}
