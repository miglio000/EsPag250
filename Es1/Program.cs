using System;
using LibreriaEsArray;
namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int casuale = r.Next(10);
            int[] array = new int[casuale];
            Gestione.LeggiArray(array);
            Gestione.StampaQuadratoArray(array);
        }
    }
}
