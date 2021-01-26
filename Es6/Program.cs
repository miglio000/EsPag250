using System;
using LibreriaEsArray;
namespace Es6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int j = 0, k = 0;
            int[] arraypari = new int[30];
            int[] arraydispari = new int[30];
            for(int i = 0; i < 30; i++)
            {
                int n = r.Next(30);
                if(n % 2 == 0)
                {
                    arraypari[j] = n;
                    j++;
                }
                else
                {
                    arraydispari[k] = n;
                    k++;
                }
            }
            Console.WriteLine("I pari sono: ");
            Gestione.StampaArray(arraypari);
            Console.WriteLine();
            Console.WriteLine("I dispari sono: ");
            Gestione.StampaArray(arraydispari);
            //Console.WriteLine($"I pari sono: {arraypari} \nI dispari sono: {arraydispari[k]}.");
        }
    }
}
