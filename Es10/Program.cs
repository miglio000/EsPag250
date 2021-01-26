using System;
using LibreriaEsArray;
namespace Es10
{
    class Program
    {
        private static int[] array = new int[5];
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Vuoi inserire manualmente o generare random(M/R)?: ");
            bool scelta = Console.ReadLine() == "R";
            if (scelta == true)
                for (int i = 0; i < array.Length; i++)
                    array[i] = r.Next(1, 11);
            else
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Inserisci il {i + 1}° numero: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Vuoi visualizzare il contenuto dell'array in maniera crescente o decrescente?(C/D)");
            bool visualizza = Console.ReadLine() == "C";
            Console.WriteLine("L'array contiene: ");
            if (visualizza == true)
                Gestione.StampaArray(array);
            else
                Gestione.StampaArrayDecrescente(array);
        }
    }
}
