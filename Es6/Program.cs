using System;
using LibreriaEsArray;
namespace Es6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numeri = 30;
            int[] pari = new int[30];
            int c_pari = 0;
            int[] dispari = new int[30];
            int c_dispari = 0;
            Random r = new Random();
            for (int i = 0; i < numeri; i++)
            {
                int n = r.Next(1, 61);
                if (n % 2 == 0)
                {
                    pari[c_pari] = n;
                    c_pari++;
                }
                else
                {
                    dispari[c_dispari] = n;
                    c_dispari++;
                }
            }
            Console.WriteLine("I pari sono: ");
            Gestione.StampaArrayFinoALunghezza(pari, c_pari);
            Console.WriteLine("I dispari sono: ");
            Gestione.StampaArrayFinoALunghezza(dispari, c_dispari);
        }
    }
}
