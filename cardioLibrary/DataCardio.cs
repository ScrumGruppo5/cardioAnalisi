using System;

namespace cardioLibrary
{
    public class DataCardio
    {
        public static double Frequenzabattito(int n)
        {
            double f = 220 - n;
            return f;
        }
        public static bool FrequenzaConsigliata(int f)
        {
            double p = (f * 100) / 220;
            if (p > 70 && p < 90)
            {
                return true;
            }
            else
                return false;
        }
        public static string FrequenzaCardiaca(int battiti)
        {
            if (battiti <= 0)
                return "Valore errato";
            {
                if (battiti < 60)
                    return "Bradicardia";
                else if (battiti >= 60 && battiti <= 100)
                    return "Normale";
                else
                    return "Tachicardia";
            }
        }
        public static double CalorieBruciate(string sesso, int età, double frequenza, double peso, double durata)
        {
            double c;
            if (sesso == "uomo" || sesso == "Uomo")
            {
                c = ((età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969) * durata / 4.184;
            }
            else if (sesso == "Donna" || sesso == "donna")
            {
                c = ((età * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184;
            }
            else
                return 1;
            return c;




        }
    }
}
