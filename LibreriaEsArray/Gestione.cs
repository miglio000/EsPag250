using System;

namespace LibreriaEsArray
{
    public class Gestione
    {
        public static void LeggiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int n = Convert.ToInt32(Console.ReadLine());
                array[i] = n;
            }
        }
        public static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void StampaQuadratoArray(int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"Sono usciti: {array2[i] * array2[i]}");
            }
        }
        public static void Divisori(int n)
        {
            int[] divisori = new int[100];
            for (int i = 1; i <= n; i++)
            {
                divisori[i] = n / i;
                if (n % i == 0)
                {
                    Console.WriteLine(divisori[i]);
                }
            }
        }
        public static void StampaArrayDecrescente(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void StampaArrayFinoALunghezza(int[] array, int lunghezza)
        {
            for (int i = 0; i < lunghezza; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

