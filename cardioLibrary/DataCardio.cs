using System;
using System.Collections.Generic;
using System.IO;

namespace cardioLibrary
{
    public class DataCardio
    {
        public static string FrequenzaConsigliata(int età)
        {
            int f = 220 - età;
            double min = (f * 70) / 100;
            double max = (f * 90) / 100;
            string risultato = ($"minima: {min} massima: {max}");
            return risultato;
        }
        public static string FrequenzaCardiaca(int battiti)
        {
            if (battiti <= 0)
                return "Valore errato";
            if (battiti < 60)
                return "Bradicardia";
            else if (battiti >= 60 && battiti <= 100)
                return "Normale";
            else
                return "Tachicardia";

        }
        public static double CalorieBruciate(string sesso, int età, double peso, double durata, double frequenza)
        {
            double c;
            if (sesso.ToLower() == "uomo")
                c = ((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184;
            else if (sesso.ToLower() == "donna")
                c = ((età * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184;
            else
            {
                return 1;
            }
            c = Math.Round(c, 2);
            return c;
        }
        public static string SpesaEnergetica(string tipo, double km, double peso)
        {
            if (tipo.ToLower() == "corsa")
                return (0.9 * km * peso).ToString();
            else if (tipo.ToLower() == "camminata")
                return (0.50 * km * peso).ToString();
            else
                return "Input Errato";
        }
        public static void GeneraBattiti()
        {
            Random n = new Random();
            using (StreamWriter w = new StreamWriter("dati.txt"))
            {
                for (int i = 0; i < 1440; i++)
                {
                    w.WriteLine(n.Next(50, 71));
                }
                w.Flush();
            }
        }
        public static double MediaBattiti(string file)
        {
            double somma = 0, tot;
            using (StreamReader r = new StreamReader(file))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Int32.TryParse(line, out int n);
                    somma += n;
                }
                tot = somma / 1440;
                tot = Math.Round(tot, 2);
            }
            return tot;

        }
        public static int BattitiRiposo(string file)
        {
            List<int> dati = new List<int>();
            using (StreamReader r = new StreamReader(file))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    Int32.TryParse(line, out int n);
                    dati.Add(n);
                }
            }
            dati.Sort();
            int min = dati[0];
            return min;
        }
        public static int VariabilitàBattiti(string file)
        {
            List<int> dati = new List<int>();
            using StreamReader r = new StreamReader(file);
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Int32.TryParse(line, out int n);
                dati.Add(n);
            }
            dati.Sort();
            int min = dati[0];
            int max = dati[1439];
            int variabilità = max - min;
            return variabilità;
        }
        public static double SogliaAnaerobica(int età)
        {
            int f = 220 - età;
            return Math.Round(f * 0.935, 2);
        }
    }

}