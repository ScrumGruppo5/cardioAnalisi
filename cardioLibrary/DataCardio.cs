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
            string risultato = ($"battiti minimi: {min} battiti massimi: {max}");
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
        public static double SpesaEnergetica(string tipo, double km, double peso)
        {
            if (tipo.ToLower() == "corsa")
                return 0.9 * km * peso;
            else if (tipo.ToLower() == "camminata")
                return 0.50 * km * peso;
            else
                return 1;
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
            int min = dati[1];
            return min;

        }
    }
}
