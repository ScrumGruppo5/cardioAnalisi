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
    }
}
